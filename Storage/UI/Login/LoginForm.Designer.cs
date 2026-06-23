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
            panelLeft = new Panel();
            lblBrand = new Label();
            lblSlogan = new Label();
            lblVersion = new Label();
            panelRight = new Panel();
            lblTitle = new Label();
            lblLoginLbl = new Label();
            txtLogin = new TextBox();
            lblPassLbl = new Label();
            txtPassword = new TextBox();
            btnLogin = new Button();
            lnkRegister = new LinkLabel();
            lblStatus = new Label();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(45, 106, 79);
            panelLeft.Controls.Add(lblBrand);
            panelLeft.Controls.Add(lblSlogan);
            panelLeft.Controls.Add(lblVersion);
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(260, 400);
            panelLeft.TabIndex = 0;
            // 
            // lblBrand
            // 
            lblBrand.AutoSize = true;
            lblBrand.Font = new Font("Segoe UI", 48F);
            lblBrand.ForeColor = Color.White;
            lblBrand.Location = new Point(49, 79);
            lblBrand.Name = "lblBrand";
            lblBrand.Size = new Size(155, 106);
            lblBrand.TabIndex = 0;
            lblBrand.Text = "📦";
            // 
            // lblSlogan
            // 
            lblSlogan.AutoSize = true;
            lblSlogan.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblSlogan.ForeColor = Color.White;
            lblSlogan.Location = new Point(20, 185);
            lblSlogan.Name = "lblSlogan";
            lblSlogan.Size = new Size(238, 60);
            lblSlogan.TabIndex = 1;
            lblSlogan.Text = "Система управления\nскладом";
            lblSlogan.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8.5F);
            lblVersion.ForeColor = Color.FromArgb(180, 220, 180);
            lblVersion.Location = new Point(20, 365);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(184, 20);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "v1.0  ·  .NET 8  ·  MS Access";
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(lblTitle);
            panelRight.Controls.Add(lblLoginLbl);
            panelRight.Controls.Add(txtLogin);
            panelRight.Controls.Add(lblPassLbl);
            panelRight.Controls.Add(txtPassword);
            panelRight.Controls.Add(btnLogin);
            panelRight.Controls.Add(lnkRegister);
            panelRight.Controls.Add(lblStatus);
            panelRight.Location = new Point(260, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(420, 400);
            panelRight.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblTitle.ForeColor = Color.FromArgb(45, 106, 79);
            lblTitle.Location = new Point(40, 50);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(195, 32);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Вход в систему";
            // 
            // lblLoginLbl
            // 
            lblLoginLbl.AutoSize = true;
            lblLoginLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLoginLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblLoginLbl.Location = new Point(40, 111);
            lblLoginLbl.Name = "lblLoginLbl";
            lblLoginLbl.Size = new Size(59, 21);
            lblLoginLbl.TabIndex = 1;
            lblLoginLbl.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(248, 251, 248);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Font = new Font("Segoe UI", 9.5F);
            txtLogin.Location = new Point(40, 135);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(340, 29);
            txtLogin.TabIndex = 2;
            // 
            // lblPassLbl
            // 
            lblPassLbl.AutoSize = true;
            lblPassLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblPassLbl.Location = new Point(40, 174);
            lblPassLbl.Name = "lblPassLbl";
            lblPassLbl.Size = new Size(70, 21);
            lblPassLbl.TabIndex = 3;
            lblPassLbl.Text = "Пароль";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 251, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Font = new Font("Segoe UI", 9.5F);
            txtPassword.Location = new Point(40, 198);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(340, 29);
            txtPassword.TabIndex = 4;
            txtPassword.KeyDown += txtPassword_KeyDown;
            // 
            // btnLogin
            // 
            btnLogin.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnLogin.Location = new Point(40, 248);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(340, 40);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Войти";
            btnLogin.Click += btnLogin_Click;
            // 
            // lnkRegister
            // 
            lnkRegister.ActiveLinkColor = Color.FromArgb(27, 67, 50);
            lnkRegister.AutoSize = true;
            lnkRegister.Font = new Font("Segoe UI", 9.5F);
            lnkRegister.LinkColor = Color.FromArgb(45, 106, 79);
            lnkRegister.Location = new Point(90, 305);
            lnkRegister.Name = "lnkRegister";
            lnkRegister.Size = new Size(260, 21);
            lnkRegister.TabIndex = 6;
            lnkRegister.TabStop = true;
            lnkRegister.Text = "Нет аккаунта? Зарегистрироваться";
            lnkRegister.LinkClicked += lnkRegister_LinkClicked;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Font = new Font("Segoe UI", 9.5F);
            lblStatus.ForeColor = Color.FromArgb(40, 167, 69);
            lblStatus.Location = new Point(40, 340);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(0, 21);
            lblStatus.TabIndex = 7;
            // 
            // LoginForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            ClientSize = new Size(680, 400);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склад — Вход в систему";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
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
