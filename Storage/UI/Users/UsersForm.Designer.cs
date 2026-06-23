namespace Storage.UI.Users
{
    partial class UsersForm
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
            panelLeft = new Panel();
            grpAdd = new GroupBox();
            lblLoginLbl = new Label();
            txtLogin = new TextBox();
            lblPassLbl = new Label();
            txtPassword = new TextBox();
            lblRoleLbl = new Label();
            cmbRole = new ComboBox();
            btnAdd = new Button();
            grpActions = new GroupBox();
            lblActHint = new Label();
            btnChangeRole = new Button();
            btnResetPass = new Button();
            btnDelete = new Button();
            panelRight = new Panel();
            dgv = new DataGridView();
            panelBot = new Panel();
            lblCount = new Label();
            btnRefresh = new Button();
            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            grpAdd.SuspendLayout();
            grpActions.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBot.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 106, 79);
            panelTop.Controls.Add(lblAppBar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(920, 48);
            panelTop.TabIndex = 0;
            // 
            // lblAppBar
            // 
            lblAppBar.AutoSize = true;
            lblAppBar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location = new Point(22, 9);
            lblAppBar.Name = "lblAppBar";
            lblAppBar.Size = new Size(583, 30);
            lblAppBar.TabIndex = 0;
            lblAppBar.Text = "👥  Управление пользователями  (только Директор)";
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(240, 244, 240);
            panelLeft.Controls.Add(grpAdd);
            panelLeft.Controls.Add(grpActions);
            panelLeft.Location = new Point(0, 48);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(290, 500);
            panelLeft.TabIndex = 1;
            // 
            // grpAdd
            // 
            grpAdd.BackColor = Color.White;
            grpAdd.Controls.Add(lblLoginLbl);
            grpAdd.Controls.Add(txtLogin);
            grpAdd.Controls.Add(lblPassLbl);
            grpAdd.Controls.Add(txtPassword);
            grpAdd.Controls.Add(lblRoleLbl);
            grpAdd.Controls.Add(cmbRole);
            grpAdd.Controls.Add(btnAdd);
            grpAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpAdd.ForeColor = Color.FromArgb(45, 106, 79);
            grpAdd.Location = new Point(10, 10);
            grpAdd.Name = "grpAdd";
            grpAdd.Size = new Size(270, 232);
            grpAdd.TabIndex = 0;
            grpAdd.TabStop = false;
            grpAdd.Text = "  Новый пользователь";
            // 
            // lblLoginLbl
            // 
            lblLoginLbl.AutoSize = true;
            lblLoginLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblLoginLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblLoginLbl.Location = new Point(12, 22);
            lblLoginLbl.Name = "lblLoginLbl";
            lblLoginLbl.Size = new Size(59, 21);
            lblLoginLbl.TabIndex = 0;
            lblLoginLbl.Text = "Логин";
            // 
            // txtLogin
            // 
            txtLogin.BackColor = Color.FromArgb(248, 251, 248);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.Location = new Point(12, 46);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(246, 29);
            txtLogin.TabIndex = 1;
            // 
            // lblPassLbl
            // 
            lblPassLbl.AutoSize = true;
            lblPassLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblPassLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblPassLbl.Location = new Point(12, 76);
            lblPassLbl.Name = "lblPassLbl";
            lblPassLbl.Size = new Size(192, 21);
            lblPassLbl.TabIndex = 2;
            lblPassLbl.Text = "Пароль (≥ 6 символов)";
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(248, 251, 248);
            txtPassword.BorderStyle = BorderStyle.FixedSingle;
            txtPassword.Location = new Point(12, 100);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '●';
            txtPassword.Size = new Size(246, 29);
            txtPassword.TabIndex = 3;
            // 
            // lblRoleLbl
            // 
            lblRoleLbl.AutoSize = true;
            lblRoleLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRoleLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblRoleLbl.Location = new Point(12, 130);
            lblRoleLbl.Name = "lblRoleLbl";
            lblRoleLbl.Size = new Size(49, 21);
            lblRoleLbl.TabIndex = 4;
            lblRoleLbl.Text = "Роль";
            // 
            // cmbRole
            // 
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font = new Font("Segoe UI", 9.5F);
            cmbRole.Location = new Point(12, 154);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(246, 29);
            cmbRole.TabIndex = 5;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.Location = new Point(12, 188);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(246, 36);
            btnAdd.TabIndex = 6;
            btnAdd.Text = "+  Добавить пользователя";
            btnAdd.Click += btnAdd_Click;
            // 
            // grpActions
            // 
            grpActions.BackColor = Color.White;
            grpActions.Controls.Add(lblActHint);
            grpActions.Controls.Add(btnChangeRole);
            grpActions.Controls.Add(btnResetPass);
            grpActions.Controls.Add(btnDelete);
            grpActions.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            grpActions.ForeColor = Color.FromArgb(45, 106, 79);
            grpActions.Location = new Point(10, 240);
            grpActions.Name = "grpActions";
            grpActions.Size = new Size(270, 200);
            grpActions.TabIndex = 1;
            grpActions.TabStop = false;
            grpActions.Text = "  Выбранный пользователь";
            // 
            // lblActHint
            // 
            lblActHint.Font = new Font("Segoe UI", 8.5F);
            lblActHint.ForeColor = Color.FromArgb(100, 120, 100);
            lblActHint.Location = new Point(12, 24);
            lblActHint.Name = "lblActHint";
            lblActHint.Size = new Size(246, 36);
            lblActHint.TabIndex = 0;
            lblActHint.Text = "Выберите строку в таблице,\nзатем выберите роль и нажмите действие:";
            // 
            // btnChangeRole
            // 
            btnChangeRole.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnChangeRole.Location = new Point(12, 68);
            btnChangeRole.Name = "btnChangeRole";
            btnChangeRole.Size = new Size(246, 34);
            btnChangeRole.TabIndex = 1;
            btnChangeRole.Text = "✎  Изменить роль";
            btnChangeRole.Click += btnChangeRole_Click;
            // 
            // btnResetPass
            // 
            btnResetPass.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnResetPass.Location = new Point(12, 112);
            btnResetPass.Name = "btnResetPass";
            btnResetPass.Size = new Size(246, 34);
            btnResetPass.TabIndex = 2;
            btnResetPass.Text = "🔑  Сбросить пароль → 123456";
            btnResetPass.Click += btnResetPass_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.Location = new Point(12, 156);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(246, 34);
            btnDelete.TabIndex = 3;
            btnDelete.Text = "✕  Удалить пользователя";
            btnDelete.Click += btnDelete_Click;
            // 
            // panelRight
            // 
            panelRight.BackColor = Color.White;
            panelRight.Controls.Add(dgv);
            panelRight.Location = new Point(290, 48);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(630, 500);
            panelRight.TabIndex = 2;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeight = 29;
            dgv.Location = new Point(0, 0);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(630, 472);
            dgv.TabIndex = 0;
            // 
            // panelBot
            // 
            panelBot.BackColor = Color.FromArgb(232, 241, 235);
            panelBot.Controls.Add(lblCount);
            panelBot.Controls.Add(btnRefresh);
            panelBot.Dock = DockStyle.Bottom;
            panelBot.Location = new Point(0, 500);
            panelBot.Name = "panelBot";
            panelBot.Size = new Size(920, 91);
            panelBot.TabIndex = 3;
            panelBot.Paint += panelBot_Paint;
            // 
            // lblCount
            // 
            lblCount.AutoSize = true;
            lblCount.Font = new Font("Segoe UI", 8.5F);
            lblCount.ForeColor = Color.FromArgb(82, 121, 111);
            lblCount.Location = new Point(14, 8);
            lblCount.Name = "lblCount";
            lblCount.Size = new Size(0, 20);
            lblCount.TabIndex = 0;
            // 
            // btnRefresh
            // 
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(82, 121, 111);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Color.FromArgb(45, 106, 79);
            btnRefresh.Location = new Point(863, 53);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 35);
            btnRefresh.TabIndex = 1;
            btnRefresh.Text = "↻ Обновить";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // UsersForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            ClientSize = new Size(920, 591);
            Controls.Add(panelTop);
            Controls.Add(panelLeft);
            Controls.Add(panelRight);
            Controls.Add(panelBot);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "UsersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Управление пользователями";
            Load += UsersForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelLeft.ResumeLayout(false);
            grpAdd.ResumeLayout(false);
            grpAdd.PerformLayout();
            grpActions.ResumeLayout(false);
            panelRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBot.ResumeLayout(false);
            panelBot.PerformLayout();
            ResumeLayout(false);
        }

        private Panel        panelTop, panelLeft, panelRight, panelBot;
        private Label        lblAppBar, lblLoginLbl, lblPassLbl, lblRoleLbl;
        private Label        lblActHint, lblCount;
        private GroupBox     grpAdd, grpActions;
        private TextBox      txtLogin, txtPassword;
        private ComboBox     cmbRole;
        private Button       btnAdd, btnChangeRole, btnResetPass, btnDelete, btnRefresh;
        private DataGridView dgv;
    }
    #endregion
}
