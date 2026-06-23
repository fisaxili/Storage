namespace Storage.UI.Register
{
    partial class RegisterForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader   = new Label();
            panelBody   = new Panel();
            lblLogin    = new Label();
            txtLogin    = new TextBox();
            lblPass     = new Label();
            txtPassword = new TextBox();
            lblConfirm  = new Label();
            txtConfirm  = new TextBox();
            lblRoleNote = new Label();
            btnRegister = new Button();
            btnCancel   = new Button();

            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();

            // Form
            ClientSize      = new Size(420, 400);
            Text            = "Регистрация нового пользователя";
            StartPosition   = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            BackColor       = Theme.BgPage;
            Font            = Theme.FontBase;

            // panelHeader
            panelHeader.BackColor = Theme.Accent;
            panelHeader.Dock      = DockStyle.Top;
            panelHeader.Height    = 56;

            lblHeader.Text      = "📋  Новый аккаунт";
            lblHeader.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location  = new Point(16, 15);
            lblHeader.AutoSize  = true;
            panelHeader.Controls.Add(lblHeader);

            // panelBody
            panelBody.BackColor = Theme.BgCard;
            panelBody.Location  = new Point(20, 72);
            panelBody.Size      = new Size(380, 300);
            panelBody.Padding   = new Padding(20);

            lblLogin.Text      = "Логин";
            lblLogin.Font      = Theme.FontBold;
            lblLogin.ForeColor = Theme.TextMuted;
            lblLogin.Location  = new Point(20, 15);
            lblLogin.AutoSize  = true;

            txtLogin.Location    = new Point(20, 35);
            txtLogin.Size        = new Size(340, 28);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.BackColor   = Color.FromArgb(248, 251, 248);

            lblPass.Text      = "Пароль  (не менее 6 символов)";
            lblPass.Font      = Theme.FontBold;
            lblPass.ForeColor = Theme.TextMuted;
            lblPass.Location  = new Point(20, 75);
            lblPass.AutoSize  = true;

            txtPassword.Location     = new Point(20, 95);
            txtPassword.Size         = new Size(340, 28);
            txtPassword.PasswordChar = '●';
            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.BackColor    = Color.FromArgb(248, 251, 248);

            lblConfirm.Text      = "Подтвердите пароль";
            lblConfirm.Font      = Theme.FontBold;
            lblConfirm.ForeColor = Theme.TextMuted;
            lblConfirm.Location  = new Point(20, 138);
            lblConfirm.AutoSize  = true;

            txtConfirm.Location     = new Point(20, 158);
            txtConfirm.Size         = new Size(340, 28);
            txtConfirm.PasswordChar = '●';
            txtConfirm.BorderStyle  = BorderStyle.FixedSingle;
            txtConfirm.BackColor    = Color.FromArgb(248, 251, 248);

            lblRoleNote.Text      = "ℹ  Начальная роль — «Гость». Директор может повысить роль.";
            lblRoleNote.Font      = Theme.FontSmall;
            lblRoleNote.ForeColor = Theme.AccentLight;
            lblRoleNote.Location  = new Point(20, 200);
            lblRoleNote.Size      = new Size(340, 32);

            btnRegister.Text     = "Зарегистрироваться";
            btnRegister.Location = new Point(20, 245);
            btnRegister.Size     = new Size(165, 36);
            Theme.StyleAccentButton(btnRegister);
            btnRegister.Click += btnRegister_Click;

            btnCancel.Text      = "Отмена";
            btnCancel.Location  = new Point(195, 245);
            btnCancel.Size      = new Size(165, 36);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.FlatAppearance.BorderColor = Theme.AccentLight;
            btnCancel.ForeColor = Theme.Accent;
            btnCancel.BackColor = Color.White;
            btnCancel.Font      = Theme.FontBase;
            btnCancel.Cursor    = Cursors.Hand;
            btnCancel.Click    += btnCancel_Click;

            panelBody.Controls.AddRange(new Control[]
            {
                lblLogin, txtLogin, lblPass, txtPassword,
                lblConfirm, txtConfirm, lblRoleNote, btnRegister, btnCancel
            });

            Controls.AddRange(new Control[] { panelHeader, panelBody });
            panelHeader.ResumeLayout();
            panelBody.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel   panelHeader, panelBody;
        private Label   lblHeader, lblLogin, lblPass, lblConfirm, lblRoleNote;
        private TextBox txtLogin, txtPassword, txtConfirm;
        private Button  btnRegister, btnCancel;
    }
}
