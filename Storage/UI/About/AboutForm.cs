using Storage.BLL;

namespace Storage.UI.About
{
    /// <summary>Краткая информация о программе.</summary>
    public partial class AboutForm : Form
    {
        private readonly UserSession _session;

        public AboutForm(UserSession session)
        {
            _session = session;
            InitializeComponent();
        }

        private void AboutForm_Load(object sender, EventArgs e)
        {
            lblCurrentUser.Text = $"Текущий пользователь: {_session.CurrentUserName}  " +
                                  $"({_session.CurrentRole})";
        }

        private void lblRoles_Click(object sender, EventArgs e)
        {

        }

        private void lblRoles_Click_1(object sender, EventArgs e)
        {

        }
    }
}
