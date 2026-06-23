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
        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            panelHeader = new Panel();
            lblHeader = new Label();
            panelBody = new Panel();
            lblLogin = new Label();
            txtLogin = new TextBox();
            lblPass = new Label();
            txtPassword = new TextBox();
            lblConfirm = new Label();
            txtConfirm = new TextBox();
            lblRoleNote = new Label();
            btnRegister = new Button();
            btnCancel = new Button();
            panelHeader.SuspendLayout();
            panelBody.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.FromArgb(45, 106, 79);
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(420, 56);
            panelHeader.TabIndex = 0;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(16, 15);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(220, 30);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "📋  Новый аккаунт";
            // 
            // panelBody
            // 
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lblLogin);
            panelBody.Controls.Add(txtLogin);
            panelBody.Controls.Add(lblPass);
            panelBody.Controls.Add(txtPassword);
            panelBody.Controls.Add(lblConfirm);
            panelBody.Controls.Add(txtConfirm);
            panelBody.Controls.Add(lblRoleNote);
            panelBody.Controls.Add(btnRegister);
            panelBody.Controls.Add(btnCancel);
            panelBody.Location = new Point(20, 72);
            panelBody.Name = "panelBody";
            panelBody.Padding = new Padding(20);
            panelBody.Size = new Size(380, 300);
            panelBody.TabIndex = 1;
            // 
            // lblLogin
            // 
            lblLogin.AutoSize = true;
            lblLogin.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLogin.ForeColor = Color.FromArgb(100, 120, 100);
            lblLogin.Location = new Point(20, 11);
            lblLogin.Name = "lblLogin";
            lblLogin.Size = new Size(59, 21);
            lblLogin.TabIndex = 0;
            lblLogin.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(248, 251, 248);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(20, 35);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(340, 29);
            txtLogin.TabIndex = 1;
            // 
            // lblPass
            // 
            lblPass.AutoSize = true;
            lblPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPass.ForeColor = Color.FromArgb(100, 120, 100);
            lblPass.Location = new Point(20, 71);
            lblPass.Name = "lblPass";
            lblPass.Size = new Size(257, 21);
            lblPass.TabIndex = 2;
            lblPass.Text = "Пароль  (не менее 6 символов)";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 251, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(20, 95);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(340, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblConfirm
            // 
            lblConfirm.AutoSize = true;
            lblConfirm.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirm.ForeColor = Color.FromArgb(100, 120, 100);
            lblConfirm.Location = new Point(20, 134);
            lblConfirm.Name = "lblConfirm";
            lblConfirm.Size = new Size(175, 21);
            lblConfirm.TabIndex = 4;
            lblConfirm.Text = "Подтвердите пароль";
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.FromArgb(248, 251, 248);
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Location = new Point(20, 158);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '●';
            txtConfirm.Size = new Size(340, 29);
            txtConfirm.TabIndex = 5;
            // 
            // lblRoleNote
            // 
            lblRoleNote.Font = new Font("Segoe UI", 8.5F);
            lblRoleNote.ForeColor = Color.FromArgb(82, 121, 111);
            lblRoleNote.Location = new Point(20, 200);
            lblRoleNote.Name = "lblRoleNote";
            lblRoleNote.Size = new Size(340, 32);
            lblRoleNote.TabIndex = 6;
            lblRoleNote.Text = "ℹ  Начальная роль — «Гость». Директор может повысить роль.";
            // 
            // btnRegister
            // 
            btnRegister.Location = new Point(20, 245);
            btnRegister.Name = "btnRegister";
            btnRegister.Size = new Size(165, 36);
            btnRegister.TabIndex = 7;
            btnRegister.Text = "Зарегистрироваться";
            btnRegister.Click += btnRegister_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.White;
            btnCancel.Cursor = Cursors.Hand;
            btnCancel.FlatAppearance.BorderColor = Color.FromArgb(82, 121, 111);
            btnCancel.FlatStyle = FlatStyle.Flat;
            btnCancel.Font = new Font("Segoe UI", 9.5F);
            btnCancel.ForeColor = Color.FromArgb(45, 106, 79);
            btnCancel.Location = new Point(195, 245);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(165, 36);
            btnCancel.TabIndex = 8;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // RegisterForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            ClientSize = new Size(420, 400);
            Controls.Add(panelHeader);
            Controls.Add(panelBody);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RegisterForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Регистрация нового пользователя";
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            ResumeLayout(false);
        }

        private Panel   panelHeader, panelBody;
        private Label   lblHeader, lblLogin, lblPass, lblConfirm, lblRoleNote;
        private TextBox txtLogin, txtPassword, txtConfirm;
        private Button  btnRegister, btnCancel;
    }
    #endregion
}
