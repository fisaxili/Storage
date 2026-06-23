using System.Data;
using System.Data.OleDb;
using Storage.BLL;
using Storage.BLL.Secure;

namespace Storage.UI.Users
{
    /// <summary>
    /// Управление пользователями системы.
    /// Доступно только Директору: просмотр, добавление, смена роли, удаление.
    /// </summary>
    public partial class UsersForm : Form
    {
        private readonly string      _connectionString;
        private readonly UserSession _session;
        private DataTable?           _dt;

        public UsersForm(string connectionString, UserSession session)
        {
            _connectionString = connectionString;
            _session          = session;
            InitializeComponent();
        }

        private void UsersForm_Load(object sender, EventArgs e)
        {
            cmbRole.Items.AddRange(Roles.All.Cast<object>().ToArray());
            LoadUsers();
        }

        // ── Загрузка ──────────────────────────────────────────────────
        private void LoadUsers()
        {
            try
            {
                using var conn    = new OleDbConnection(_connectionString);
                using var adapter = new OleDbDataAdapter(
                    "SELECT Код_Пользователя, Логин, Роль FROM Пользователи ORDER BY Логин",
                    conn);
                _dt = new DataTable();
                adapter.Fill(_dt);
                dgv.DataSource = _dt;

                // Скрываем технический столбец
                if (dgv.Columns.Contains("Код_Пользователя"))
                    dgv.Columns["Код_Пользователя"]!.Visible = false;

                lblCount.Text = $"Пользователей: {_dt.Rows.Count}";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Добавить пользователя ─────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var login    = txtLogin.Text.Trim();
            var password = txtPassword.Text;
            var role     = cmbRole.SelectedItem?.ToString() ?? Roles.Guest;

            if (string.IsNullOrWhiteSpace(login))
            { ShowError("Введите логин."); return; }

            if (password.Length < 6)
            { ShowError("Пароль должен содержать не менее 6 символов."); return; }

            try
            {
                using var conn = new OleDbConnection(_connectionString);
                conn.Open();

                // Проверка уникальности
                using var check = new OleDbCommand(
                    "SELECT COUNT(*) FROM Пользователи WHERE Логин = ?", conn);
                check.Parameters.AddWithValue("?", login);
                if (Convert.ToInt32(check.ExecuteScalar()) > 0)
                { ShowError("Пользователь с таким логином уже существует."); return; }

                string hash = PasswordHasher.Hash(password);
                using var ins = new OleDbCommand(
                    "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (?, ?, ?)", conn);
                ins.Parameters.AddWithValue("?", login);
                ins.Parameters.AddWithValue("?", hash);
                ins.Parameters.AddWithValue("?", role);
                ins.ExecuteNonQuery();

                txtLogin.Clear();
                txtPassword.Clear();
                cmbRole.SelectedIndex = 0;
                LoadUsers();

                MessageBox.Show($"Пользователь «{login}» добавлен с ролью «{role}».",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        // ── Изменить роль ─────────────────────────────────────────────
        private void btnChangeRole_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || _dt == null) return;

            var row   = _dt.Rows[dgv.CurrentRow.Index];
            var login = row["Логин"].ToString()!;
            var newRole = cmbRole.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(newRole)) { ShowError("Выберите роль."); return; }

            // Нельзя менять роль себе
            if (login == _session.CurrentUserName)
            { ShowError("Нельзя изменить свою собственную роль."); return; }

            var res = MessageBox.Show(
                $"Назначить пользователю «{login}» роль «{newRole}»?",
                "Подтверждение", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;

            try
            {
                using var conn = new OleDbConnection(_connectionString);
                conn.Open();
                using var cmd = new OleDbCommand(
                    "UPDATE Пользователи SET Роль = ? WHERE Логин = ?", conn);
                cmd.Parameters.AddWithValue("?", newRole);
                cmd.Parameters.AddWithValue("?", login);
                cmd.ExecuteNonQuery();
                LoadUsers();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        // ── Сбросить пароль ───────────────────────────────────────────
        private void btnResetPass_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || _dt == null) return;

            var login = _dt.Rows[dgv.CurrentRow.Index]["Логин"].ToString()!;

            var res = MessageBox.Show(
                $"Сбросить пароль пользователя «{login}» на «123456»?",
                "Сброс пароля", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes) return;

            try
            {
                string hash = PasswordHasher.Hash("123456");
                using var conn = new OleDbConnection(_connectionString);
                conn.Open();
                using var cmd = new OleDbCommand(
                    "UPDATE Пользователи SET Пароль = ? WHERE Логин = ?", conn);
                cmd.Parameters.AddWithValue("?", hash);
                cmd.Parameters.AddWithValue("?", login);
                cmd.ExecuteNonQuery();

                MessageBox.Show($"Пароль пользователя «{login}» сброшен на «123456».",
                    "Готово", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        // ── Удалить пользователя ──────────────────────────────────────
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgv.CurrentRow == null || _dt == null) return;

            var login = _dt.Rows[dgv.CurrentRow.Index]["Логин"].ToString()!;

            if (login == _session.CurrentUserName)
            { ShowError("Нельзя удалить собственный аккаунт."); return; }

            var res = MessageBox.Show(
                $"Удалить пользователя «{login}»? Это действие необратимо.",
                "Удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes) return;

            try
            {
                using var conn = new OleDbConnection(_connectionString);
                conn.Open();
                using var cmd = new OleDbCommand(
                    "DELETE FROM Пользователи WHERE Логин = ?", conn);
                cmd.Parameters.AddWithValue("?", login);
                cmd.ExecuteNonQuery();
                LoadUsers();
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadUsers();

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
