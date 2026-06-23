using System.Data;
using Storage.BLL;

namespace Storage.UI.Database
{
    /// <summary>
    /// Просмотр таблиц БД «Склад»: выбор таблицы, поиск, сортировка, CRUD.
    /// </summary>
    public partial class DatabaseForm : Form
    {
        private readonly DataService _data;
        private readonly UserSession _session;
        private readonly MainMenu    _mainMenu;

        private string    _currentTable = "Детали";
        private DataTable? _currentDt;

        public DatabaseForm(DataService data, UserSession session, MainMenu mainMenu)
        {
            _data     = data;
            _session  = session;
            _mainMenu = mainMenu;
            InitializeComponent();
        }

        // ── Загрузка ──────────────────────────────────────────────────
        private void DatabaseForm_Load(object sender, EventArgs e)
        {
            ApplyRoleRestrictions();
            LoadTable(_currentTable);
        }

        private void ApplyRoleRestrictions()
        {
            btnAdd.Enabled    = _data.CanEdit();
            btnEdit.Enabled   = _data.CanEdit();
            btnDelete.Enabled = _data.CanDelete();

            // Визуально притушить кнопки без прав
            if (!_data.CanEdit())
            {
                btnAdd.BackColor  = Color.FromArgb(150, 150, 150);
                btnEdit.BackColor = Color.FromArgb(150, 150, 150);
            }
            if (!_data.CanDelete())
                btnDelete.BackColor = Color.FromArgb(150, 150, 150);

            lblRole.Text = $"👤  {_session.CurrentUserName}  |  Роль: {_session.CurrentRole}";
        }

        // ── Выбор таблицы ─────────────────────────────────────────────
        private void cmbTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            _currentTable = cmbTable.SelectedItem?.ToString() ?? "Детали";
            LoadTable(_currentTable);
        }

        private void LoadTable(string tableName)
        {
            try
            {
                _currentDt = _data.GetTable(tableName);
                txtSearch.Clear();
                ApplyFilter();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки таблицы:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ── Поиск ─────────────────────────────────────────────────────
        private void txtSearch_TextChanged(object sender, EventArgs e) => ApplyFilter();

        private void ApplyFilter()
        {
            if (_currentDt == null) return;

            var keyword = txtSearch.Text.Trim().ToLower();
            if (string.IsNullOrEmpty(keyword))
            {
                dgv.DataSource   = _currentDt;
                lblRecCount.Text = $"Записей: {_currentDt.Rows.Count}";
                return;
            }

            var view = new DataView(_currentDt);
            var filters = _currentDt.Columns
                .Cast<DataColumn>()
                .Select(c => $"CONVERT([{c.ColumnName}], System.String) LIKE '%{keyword}%'");
            try
            {
                view.RowFilter   = string.Join(" OR ", filters);
                dgv.DataSource   = view;
                lblRecCount.Text = $"Найдено: {view.Count} из {_currentDt.Rows.Count}";
            }
            catch
            {
                dgv.DataSource   = _currentDt;
                lblRecCount.Text = $"Записей: {_currentDt.Rows.Count}";
            }
        }

        // ── CRUD ──────────────────────────────────────────────────────
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (_currentDt == null) return;
            using var dlg = new EditRecordForm(_currentDt, null, _currentTable);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                _data.AddRecord(_currentTable, dlg.Values);
                LoadTable(_currentTable);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (_currentDt == null || dgv.CurrentRow == null) return;
            var row = GetCurrentDataRow();
            if (row == null) return;

            using var dlg = new EditRecordForm(_currentDt, row, _currentTable);
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                var pk = DataService.GetPrimaryKey(_currentTable);
                _data.SaveRecord(_currentTable, row[pk], dlg.Values);
                LoadTable(_currentTable);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (_currentDt == null || dgv.CurrentRow == null) return;
            var row = GetCurrentDataRow();
            if (row == null) return;

            var pk  = DataService.GetPrimaryKey(_currentTable);
            var res = MessageBox.Show(
                $"Удалить запись с {pk} = {row[pk]}?",
                "Подтверждение удаления",
                MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (res != DialogResult.Yes) return;

            try
            {
                _data.DeleteRecord(_currentTable, row[pk]);
                LoadTable(_currentTable);
            }
            catch (Exception ex) { ShowError(ex.Message); }
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadTable(_currentTable);

        // ── Назад в главное меню ──────────────────────────────────────
        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainMenu.ShowFromChild();
            Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _mainMenu.ShowFromChild();
        }

        // ── Вспомогательные ───────────────────────────────────────────
        private DataRow? GetCurrentDataRow()
        {
            if (_currentDt == null || dgv.CurrentRow == null) return null;
            int idx = dgv.CurrentRow.Index;
            if (dgv.DataSource is DataView dv)
                return idx >= 0 && idx < dv.Count ? dv[idx].Row : null;
            return idx >= 0 && idx < _currentDt.Rows.Count ? _currentDt.Rows[idx] : null;
        }

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
    }
}
