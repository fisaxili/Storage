namespace Storage.UI.Profile
{
    partial class ProfileForm
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
            panelTop = new Panel();
            lblAppBar = new Label();
            panelCard = new Panel();
            lblAvatarBg = new Panel();
            lblAvatar = new Label();
            lblLoginVal = new Label();
            lblRoleBadge = new Label();
            groupPassword = new GroupBox();
            lblOldPass = new Label();
            txtOldPass = new TextBox();
            lblNewPass = new Label();
            txtNewPass = new TextBox();
            lblConfirmLbl = new Label();
            txtConfirm = new TextBox();
            btnChangePassword = new Button();
            panelTop.SuspendLayout();
            panelCard.SuspendLayout();
            lblAvatarBg.SuspendLayout();
            groupPassword.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 106, 79);
            panelTop.Controls.Add(lblAppBar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(460, 48);
            panelTop.TabIndex = 0;
            // 
            // lblAppBar
            // 
            lblAppBar.AutoSize = true;
            lblAppBar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location = new Point(16, 12);
            lblAppBar.Name = "lblAppBar";
            lblAppBar.Size = new Size(236, 30);
            lblAppBar.TabIndex = 0;
            lblAppBar.Text = "👤  Личный кабинет";
            // 
            // panelCard
            // 
            panelCard.BackColor = Color.White;
            panelCard.Controls.Add(lblAvatarBg);
            panelCard.Controls.Add(lblLoginVal);
            panelCard.Controls.Add(lblRoleBadge);
            panelCard.Location = new Point(20, 60);
            panelCard.Name = "panelCard";
            panelCard.Size = new Size(420, 90);
            panelCard.TabIndex = 1;
            // 
            // lblAvatarBg
            // 
            lblAvatarBg.BackColor = Color.FromArgb(45, 106, 79);
            lblAvatarBg.Controls.Add(lblAvatar);
            lblAvatarBg.Location = new Point(15, 15);
            lblAvatarBg.Name = "lblAvatarBg";
            lblAvatarBg.Size = new Size(60, 60);
            lblAvatarBg.TabIndex = 0;
            // 
            // lblAvatar
            // 
            lblAvatar.AutoSize = true;
            lblAvatar.Font = new Font("Segoe UI", 22F);
            lblAvatar.ForeColor = Color.White;
            lblAvatar.Location = new Point(-4, 10);
            lblAvatar.Name = "lblAvatar";
            lblAvatar.Size = new Size(73, 50);
            lblAvatar.TabIndex = 0;
            lblAvatar.Text = "👤";
            // 
            // lblLoginVal
            // 
            lblLoginVal.AutoSize = true;
            lblLoginVal.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblLoginVal.ForeColor = Color.FromArgb(23, 37, 23);
            lblLoginVal.Location = new Point(90, 15);
            lblLoginVal.Name = "lblLoginVal";
            lblLoginVal.Size = new Size(0, 30);
            lblLoginVal.TabIndex = 1;
            // 
            // lblRoleBadge
            // 
            lblRoleBadge.AutoSize = true;
            lblRoleBadge.BackColor = Color.FromArgb(82, 121, 111);
            lblRoleBadge.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRoleBadge.ForeColor = Color.White;
            lblRoleBadge.Location = new Point(90, 48);
            lblRoleBadge.Name = "lblRoleBadge";
            lblRoleBadge.Padding = new Padding(6, 2, 6, 2);
            lblRoleBadge.Size = new Size(12, 25);
            lblRoleBadge.TabIndex = 2;
            // 
            // groupPassword
            // 
            groupPassword.BackColor = Color.White;
            groupPassword.Controls.Add(lblOldPass);
            groupPassword.Controls.Add(txtOldPass);
            groupPassword.Controls.Add(lblNewPass);
            groupPassword.Controls.Add(txtNewPass);
            groupPassword.Controls.Add(lblConfirmLbl);
            groupPassword.Controls.Add(txtConfirm);
            groupPassword.Controls.Add(btnChangePassword);
            groupPassword.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            groupPassword.ForeColor = Color.FromArgb(45, 106, 79);
            groupPassword.Location = new Point(20, 165);
            groupPassword.Name = "groupPassword";
            groupPassword.Size = new Size(420, 280);
            groupPassword.TabIndex = 2;
            groupPassword.TabStop = false;
            groupPassword.Text = "  Смена пароля";
            // 
            // lblOldPass
            // 
            lblOldPass.AutoSize = true;
            lblOldPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblOldPass.ForeColor = Color.FromArgb(100, 120, 100);
            lblOldPass.Location = new Point(15, 24);
            lblOldPass.Name = "lblOldPass";
            lblOldPass.Size = new Size(141, 21);
            lblOldPass.TabIndex = 0;
            lblOldPass.Text = "Текущий пароль";
            // 
            // txtOldPass
            // 
            txtOldPass.BackColor = Color.FromArgb(248, 251, 248);
            txtOldPass.BorderStyle = BorderStyle.FixedSingle;
            txtOldPass.Location = new Point(15, 48);
            txtOldPass.Name = "txtOldPass";
            txtOldPass.PasswordChar = '●';
            txtOldPass.Size = new Size(385, 29);
            txtOldPass.TabIndex = 1;
            // 
            // lblNewPass
            // 
            lblNewPass.AutoSize = true;
            lblNewPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblNewPass.ForeColor = Color.FromArgb(100, 120, 100);
            lblNewPass.Location = new Point(15, 84);
            lblNewPass.Name = "lblNewPass";
            lblNewPass.Size = new Size(313, 21);
            lblNewPass.TabIndex = 2;
            lblNewPass.Text = "Новый пароль  (не менее 6 символов)";
            // 
            // txtNewPass
            // 
            txtNewPass.BackColor = Color.FromArgb(248, 251, 248);
            txtNewPass.BorderStyle = BorderStyle.FixedSingle;
            txtNewPass.Location = new Point(15, 108);
            txtNewPass.Name = "txtNewPass";
            txtNewPass.PasswordChar = '●';
            txtNewPass.Size = new Size(385, 29);
            txtNewPass.TabIndex = 3;
            // 
            // lblConfirmLbl
            // 
            lblConfirmLbl.AutoSize = true;
            lblConfirmLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblConfirmLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblConfirmLbl.Location = new Point(15, 144);
            lblConfirmLbl.Name = "lblConfirmLbl";
            lblConfirmLbl.Size = new Size(231, 21);
            lblConfirmLbl.TabIndex = 4;
            lblConfirmLbl.Text = "Подтвердите новый пароль";
            // 
            // txtConfirm
            // 
            txtConfirm.BackColor = Color.FromArgb(248, 251, 248);
            txtConfirm.BorderStyle = BorderStyle.FixedSingle;
            txtConfirm.Location = new Point(15, 168);
            txtConfirm.Name = "txtConfirm";
            txtConfirm.PasswordChar = '●';
            txtConfirm.Size = new Size(385, 29);
            txtConfirm.TabIndex = 5;
            // 
            // btnChangePassword
            // 
            btnChangePassword.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnChangePassword.Location = new Point(15, 215);
            btnChangePassword.Name = "btnChangePassword";
            btnChangePassword.Size = new Size(385, 40);
            btnChangePassword.TabIndex = 6;
            btnChangePassword.Text = "Изменить пароль";
            btnChangePassword.Click += btnChangePassword_Click;
            // 
            // ProfileForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            ClientSize = new Size(460, 480);
            Controls.Add(panelTop);
            Controls.Add(panelCard);
            Controls.Add(groupPassword);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ProfileForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Личный кабинет";
            Load += ProfileForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            lblAvatarBg.ResumeLayout(false);
            lblAvatarBg.PerformLayout();
            groupPassword.ResumeLayout(false);
            groupPassword.PerformLayout();
            ResumeLayout(false);
        }

        private Panel    panelTop, panelCard, lblAvatarBg;
        private Label    lblAppBar, lblAvatar, lblLoginVal, lblRoleBadge;
        private GroupBox groupPassword;
        private Label    lblOldPass, lblNewPass, lblConfirmLbl;
        private TextBox  txtOldPass, txtNewPass, txtConfirm;
        private Button   btnChangePassword;
    }
    #endregion
}
