namespace Storage.UI.Login
{
    partial class LoginForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            panelLeft    = new Panel();
            lblBrand     = new Label();
            lblSlogan    = new Label();
            lblVersion   = new Label();
            panelRight   = new Panel();
            lblTitle     = new Label();
            lblLoginLbl  = new Label();
            txtLogin     = new TextBox();
            lblPassLbl   = new Label();
            txtPassword  = new TextBox();
            btnLogin     = new Button();
            lnkRegister  = new LinkLabel();
            lblStatus    = new Label();

            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();

            //  Form
            ClientSize      = new Size(680, 400);
            Text            = "Склад — Вход в систему";
            StartPosition   = FormStartPosition.CenterScreen;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox     = false;
            BackColor       = Theme.BgPage;
            Font            = Theme.FontBase;

            // panelLeft 
            panelLeft.BackColor = Theme.Accent;
            panelLeft.Location  = new Point(0, 0);
            panelLeft.Size      = new Size(260, 400);

            lblBrand.Text      = "📦";
            lblBrand.Font      = new Font("Segoe UI", 48f);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location  = new Point(85, 80);
            lblBrand.AutoSize  = true;

            lblSlogan.Text      = "Система управления\nскладом";
            lblSlogan.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location  = new Point(20, 185);
            lblSlogan.AutoSize  = true;
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;

            lblVersion.Text      = "v1.0  ·  .NET 8  ·  MS Access";
            lblVersion.Font      = Theme.FontSmall;
            lblVersion.ForeColor = Color.FromArgb(180, 220, 180);
            lblVersion.Location  = new Point(20, 365);
            lblVersion.AutoSize  = true;

            panelLeft.Controls.AddRange(new Control[] { lblBrand, lblSlogan, lblVersion });

            // panelRight
            panelRight.BackColor = Theme.BgCard;
            panelRight.Location  = new Point(260, 0);
            panelRight.Size      = new Size(420, 400);

            lblTitle.Text      = "Вход в систему";
            lblTitle.Font      = Theme.FontHeader;
            lblTitle.ForeColor = Theme.Accent;
            lblTitle.Location  = new Point(40, 50);
            lblTitle.AutoSize  = true;

            lblLoginLbl.Text     = "Логин";
            lblLoginLbl.Font     = Theme.FontBold;
            lblLoginLbl.ForeColor = Theme.TextMuted;
            lblLoginLbl.Location = new Point(40, 115);
            lblLoginLbl.AutoSize = true;

            txtLogin.Location    = new Point(40, 135);
            txtLogin.Size        = new Size(340, 28);
            txtLogin.Font        = Theme.FontBase;
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.BackColor   = Color.FromArgb(248, 251, 248);

            lblPassLbl.Text      = "Пароль";
            lblPassLbl.Font      = Theme.FontBold;
            lblPassLbl.ForeColor = Theme.TextMuted;
            lblPassLbl.Location  = new Point(40, 178);
            lblPassLbl.AutoSize  = true;

            txtPassword.Location     = new Point(40, 198);
            txtPassword.Size         = new Size(340, 28);
            txtPassword.PasswordChar = '●';
            txtPassword.Font         = Theme.FontBase;
            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.BackColor    = Color.FromArgb(248, 251, 248);
            txtPassword.KeyDown     += txtPassword_KeyDown;

            btnLogin.Text     = "Войти";
            btnLogin.Location = new Point(40, 248);
            btnLogin.Size     = new Size(340, 40);
            Theme.StyleAccentButton(btnLogin);
            btnLogin.Font   = new Font("Segoe UI", 11f, FontStyle.Bold);
            btnLogin.Click += btnLogin_Click;

            lnkRegister.Text         = "Нет аккаунта? Зарегистрироваться";
            lnkRegister.Location     = new Point(90, 305);
            lnkRegister.AutoSize     = true;
            lnkRegister.Font         = Theme.FontBase;
            lnkRegister.LinkColor    = Theme.Accent;
            lnkRegister.ActiveLinkColor = Theme.AccentHover;
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;

            lblStatus.AutoSize  = true;
            lblStatus.Location  = new Point(40, 340);
            lblStatus.ForeColor = Theme.Success;
            lblStatus.Font      = Theme.FontBase;

            panelRight.Controls.AddRange(new Control[]
            {
                lblTitle, lblLoginLbl, txtLogin, lblPassLbl, txtPassword,
                btnLogin, lnkRegister, lblStatus
            });

            Controls.AddRange(new Control[] { panelLeft, panelRight });

            panelLeft.ResumeLayout();
            panelRight.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel     panelLeft, panelRight;
        private Label     lblBrand, lblSlogan, lblVersion;
        private Label     lblTitle, lblLoginLbl, lblPassLbl, lblStatus;
        private TextBox   txtLogin, txtPassword;
        private Button    btnLogin;
        private LinkLabel lnkRegister;
    }
    #endregion
}
