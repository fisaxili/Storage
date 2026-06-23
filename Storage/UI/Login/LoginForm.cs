using Storage.BLL;

namespace Storage.UI.Login
{
    /// <summary>
    /// Форма авторизации. После успешного входа открывает главное меню.
    /// </summary>
    public partial class LoginForm : Form
    {
        private readonly AuthService _auth;
        private readonly Func<MainMenu> _mainMenuFactory;

        public LoginForm(AuthService auth, Func<MainMenu> mainMenuFactory)
        {
            _auth            = auth;
            _mainMenuFactory = mainMenuFactory;
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var login    = txtLogin.Text.Trim();
            var password = txtPassword.Text;

            if (string.IsNullOrWhiteSpace(login) || string.IsNullOrWhiteSpace(password))
            {
                ShowError("Введите логин и пароль.");
                return;
            }

            try
            {
                bool ok = _auth.Login(login, password);
                if (ok)
                {
                    var menu = _mainMenuFactory();
                    menu.Show();
                    Hide();
                }
                else
                {
                    int remaining = 3 - GetFailedAttempts();
                    ShowError($"Неверный логин или пароль.\nОсталось попыток: больше ошибок → блокировка.");
                    txtPassword.Clear();
                    txtPassword.Focus();
                }
            }
            catch (InvalidOperationException ex)
            {
                ShowError(ex.Message);
            }
            catch (Exception ex)
            {
                ShowError($"Ошибка подключения к базе данных:\n{ex.Message}");
            }
        }

        private void lnkRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using var reg = new Register.RegisterForm(_auth);
            if (reg.ShowDialog() == DialogResult.OK)
                lblStatus.Text = "Регистрация выполнена. Войдите с новыми данными.";
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) btnLogin_Click(sender, e);
        }

        private void ShowError(string msg) =>
            MessageBox.Show(msg, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        // Заглушка — реальный счётчик хранится в AuthService
        private static int GetFailedAttempts() => 0;
    }
}
