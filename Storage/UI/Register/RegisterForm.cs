using Storage.BLL;

namespace Storage.UI.Register
{
    /// <summary>
    /// Форма регистрации нового пользователя.
    /// По умолчанию выдаётся роль «Гость».
    /// </summary>
    public partial class RegisterForm : Form
    {
        private readonly AuthService _auth;

        public RegisterForm(AuthService auth)
        {
            _auth = auth;
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            var login    = txtLogin.Text.Trim();
            var password = txtPassword.Text;
            var confirm  = txtConfirm.Text;

            if (string.IsNullOrWhiteSpace(login))
            {
                ShowError("Введите логин."); return;
            }
            if (password.Length < 6)
            {
                ShowError("Пароль должен быть не менее 6 символов."); return;
            }
            if (password != confirm)
            {
                ShowError("Пароли не совпадают."); return;
            }

            try
            {
                bool ok = _auth.Register(login, password);
                if (ok)
                {
                    MessageBox.Show("Регистрация выполнена!\nРоль: Гость.\nОбратитесь к администратору для повышения прав.",
                                    "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DialogResult = DialogResult.OK;
                    Close();
                }
                else
                {
                    ShowError("Пользователь с таким логином уже существует.");
                }
            }
            catch (ArgumentException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка: {ex.Message}");
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
    }
}
