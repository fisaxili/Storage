using Storage.BLL;
using Storage.UI.About;
using Storage.UI.Database;
using Storage.UI.Profile;
using Storage.UI.Reports;
using Storage.UI.Users;

namespace Storage.UI
{
    /// <summary>Главное меню — навигационные карточки разделов.</summary>
    public partial class MainMenu : Form
    {
        private readonly DataService        _data;
        private readonly AuthService        _auth;
        private readonly UserSession        _session;
        private readonly Func<DatabaseForm> _dbFactory;
        private readonly Func<ReportsForm>  _repFactory;
        private readonly Func<ProfileForm>  _profFactory;
        private readonly Func<UsersForm>    _usersFactory;
        private readonly Func<AboutForm>    _aboutFactory;

        public MainMenu(
            DataService        data,
            AuthService        auth,
            UserSession        session,
            Func<DatabaseForm> dbFactory,
            Func<ReportsForm>  repFactory,
            Func<ProfileForm>  profFactory,
            Func<UsersForm>    usersFactory,
            Func<AboutForm>    aboutFactory)
        {
            _data         = data;
            _auth         = auth;
            _session      = session;
            _dbFactory    = dbFactory;
            _repFactory   = repFactory;
            _profFactory  = profFactory;
            _usersFactory = usersFactory;
            _aboutFactory = aboutFactory;
            InitializeComponent();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {
            lblWelcome.Text = $"Добро пожаловать, {_session.CurrentUserName}!";
            lblRole.Text    = $"Роль: {_session.CurrentRole}";

            SetCardState(cardReports, _data.CanReport());
            SetCardState(cardUsers,   _session.CurrentRole == Roles.Director);
        }

        private static void SetCardState(Panel card, bool enabled)
        {
            card.Enabled   = enabled;
            card.BackColor = enabled ? Theme.Accent : Color.FromArgb(150, 165, 150);
            foreach (Control c in card.Controls)
            {
                c.Enabled   = enabled;
                c.ForeColor = enabled ? Color.White : Color.FromArgb(200, 210, 200);
            }
        }

        // ── Навигация ─────────────────────────────────────────────────

        private void cardDatabase_Click(object sender, EventArgs e)
        {
            OpenChildForm(_dbFactory());
        }

        private void cardReports_Click(object sender, EventArgs e)
        {
            if (!_data.CanReport()) return;
            OpenChildForm(_repFactory());
        }

        private void cardUsers_Click(object sender, EventArgs e)
        {
            if (_session.CurrentRole != Roles.Director) return;
            using var form = _usersFactory();
            form.ShowDialog(this);
        }

        private void cardProfile_Click(object sender, EventArgs e)
        {
            using var form = _profFactory();
            form.ShowDialog(this);
        }

        private void cardAbout_Click(object sender, EventArgs e)
        {
            using var form = _aboutFactory();
            form.ShowDialog(this);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var res = MessageBox.Show(
                "Выйти из системы?", "Выход",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res != DialogResult.Yes) return;
            _auth.LogOut();
            Application.Restart();
        }

        private void OpenChildForm(Form form)
        {
            form.Show();
            Hide();
        }

        public void ShowFromChild()
        {
            Show();
            BringToFront();
        }
    }
}
