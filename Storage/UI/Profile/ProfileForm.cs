using Storage.BLL;

namespace Storage.UI.Profile
{
    /// <summary>
    /// Личный кабинет: отображение роли и смена пароля.
    /// </summary>
    public partial class ProfileForm : Form
    {
        private readonly AuthService _auth;
        private readonly UserSession _session;

        public ProfileForm(AuthService auth, UserSession session)
        {
            _auth    = auth;
            _session = session;
            InitializeComponent();
        }

        private void ProfileForm_Load(object sender, EventArgs e)
        {
            lblLoginVal.Text  = _session.CurrentUserName ?? "—";
            lblRoleBadge.Text = $"  {_session.CurrentRole ?? "—"}  ";

            // Цвет бейджа по роли
            lblRoleBadge.BackColor = (_session.CurrentRole) switch
            {
                BLL.Roles.Director   => Color.FromArgb(192, 57, 43),
                BLL.Roles.Storekeeper => Theme.Accent,
                BLL.Roles.Accountant => Color.FromArgb(52, 152, 219),
                _                    => Theme.TextMuted
            };
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            var oldPass  = txtOldPass.Text;
            var newPass  = txtNewPass.Text;
            var confirm  = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(oldPass) ||
                string.IsNullOrWhiteSpace(newPass)  ||
                string.IsNullOrWhiteSpace(confirm))
            {
                ShowError("Заполните все поля."); return;
            }

            if (newPass != confirm)
            {
                ShowError("Новый пароль и подтверждение не совпадают."); return;
            }

            try
            {
                bool ok = _auth.ChangePassword(oldPass, newPass);
                if (ok)
                {
                    MessageBox.Show("Пароль успешно изменён.",
                                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtOldPass.Clear();
                    txtNewPass.Clear();
                    txtConfirm.Clear();
                }
                else
                {
                    ShowError("Старый пароль введён неверно.");
                }
            }
            catch (ArgumentException ex) { ShowError(ex.Message); }
            catch (Exception ex)         { ShowError($"Ошибка: {ex.Message}"); }
        }

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
