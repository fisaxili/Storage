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

        private void InitializeComponent()
        {
            panelTop     = new Panel();
            lblAppBar    = new Label();
            panelLeft    = new Panel();
            grpAdd       = new GroupBox();
            lblLoginLbl  = new Label();
            txtLogin     = new TextBox();
            lblPassLbl   = new Label();
            txtPassword  = new TextBox();
            lblRoleLbl   = new Label();
            cmbRole      = new ComboBox();
            btnAdd       = new Button();
            grpActions   = new GroupBox();
            lblActHint   = new Label();
            btnChangeRole  = new Button();
            btnResetPass   = new Button();
            btnDelete      = new Button();
            panelRight   = new Panel();
            dgv          = new DataGridView();
            panelBot     = new Panel();
            lblCount     = new Label();
            btnRefresh   = new Button();

            panelTop.SuspendLayout();
            panelLeft.SuspendLayout();
            grpAdd.SuspendLayout();
            grpActions.SuspendLayout();
            panelRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBot.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────────
            ClientSize      = new Size(920, 580);
            Text            = "Управление пользователями";
            StartPosition   = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            BackColor       = Theme.BgPage;
            Font            = Theme.FontBase;
            Load           += UsersForm_Load;

            // ── panelTop ──────────────────────────────────────────────
            panelTop.BackColor = Theme.Accent;
            panelTop.Dock      = DockStyle.Top;
            panelTop.Height    = 48;

            lblAppBar.Text      = "👥  Управление пользователями  (только Директор)";
            lblAppBar.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location  = new Point(16, 12);
            lblAppBar.AutoSize  = true;
            panelTop.Controls.Add(lblAppBar);

            // ── panelLeft — форма добавления + действия ───────────────
            panelLeft.BackColor = Theme.BgPage;
            panelLeft.Location  = new Point(0, 48);
            panelLeft.Size      = new Size(290, 500);

            // grpAdd — добавить нового пользователя
            grpAdd.Text      = "  Новый пользователь";
            grpAdd.Font      = Theme.FontBold;
            grpAdd.ForeColor = Theme.Accent;
            grpAdd.BackColor = Color.White;
            grpAdd.Location  = new Point(10, 10);
            grpAdd.Size      = new Size(270, 220);

            lblLoginLbl.Text      = "Логин";
            lblLoginLbl.Font      = Theme.FontBold;
            lblLoginLbl.ForeColor = Theme.TextMuted;
            lblLoginLbl.Location  = new Point(12, 28);
            lblLoginLbl.AutoSize  = true;

            txtLogin.Location    = new Point(12, 46);
            txtLogin.Size        = new Size(246, 26);
            txtLogin.BorderStyle = BorderStyle.FixedSingle;
            txtLogin.BackColor   = Color.FromArgb(248, 251, 248);

            lblPassLbl.Text      = "Пароль (≥ 6 символов)";
            lblPassLbl.Font      = Theme.FontBold;
            lblPassLbl.ForeColor = Theme.TextMuted;
            lblPassLbl.Location  = new Point(12, 82);
            lblPassLbl.AutoSize  = true;

            txtPassword.Location     = new Point(12, 100);
            txtPassword.Size         = new Size(246, 26);
            txtPassword.PasswordChar = '●';
            txtPassword.BorderStyle  = BorderStyle.FixedSingle;
            txtPassword.BackColor    = Color.FromArgb(248, 251, 248);

            lblRoleLbl.Text      = "Роль";
            lblRoleLbl.Font      = Theme.FontBold;
            lblRoleLbl.ForeColor = Theme.TextMuted;
            lblRoleLbl.Location  = new Point(12, 136);
            lblRoleLbl.AutoSize  = true;

            cmbRole.Location      = new Point(12, 154);
            cmbRole.Size          = new Size(246, 26);
            cmbRole.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbRole.Font          = Theme.FontBase;

            btnAdd.Text     = "+  Добавить пользователя";
            btnAdd.Location = new Point(12, 188);
            btnAdd.Size     = new Size(246, 20);
            btnAdd.Size     = new Size(246, 36);
            Theme.StyleColorButton(btnAdd, Theme.Success);
            btnAdd.Font   = Theme.FontBold;
            btnAdd.Click += btnAdd_Click;

            grpAdd.Controls.AddRange(new Control[]
                { lblLoginLbl, txtLogin, lblPassLbl, txtPassword,
                  lblRoleLbl, cmbRole, btnAdd });

            // grpActions — действия над выбранным пользователем
            grpActions.Text      = "  Выбранный пользователь";
            grpActions.Font      = Theme.FontBold;
            grpActions.ForeColor = Theme.Accent;
            grpActions.BackColor = Color.White;
            grpActions.Location  = new Point(10, 240);
            grpActions.Size      = new Size(270, 200);

            lblActHint.Text      = "Выберите строку в таблице,\nзатем выберите роль и нажмите действие:";
            lblActHint.Font      = Theme.FontSmall;
            lblActHint.ForeColor = Theme.TextMuted;
            lblActHint.Location  = new Point(12, 24);
            lblActHint.Size      = new Size(246, 36);

            btnChangeRole.Text     = "✎  Изменить роль";
            btnChangeRole.Location = new Point(12, 68);
            btnChangeRole.Size     = new Size(246, 34);
            Theme.StyleColorButton(btnChangeRole, Theme.Info);
            btnChangeRole.Font   = Theme.FontBold;
            btnChangeRole.Click += btnChangeRole_Click;

            btnResetPass.Text     = "🔑  Сбросить пароль → 123456";
            btnResetPass.Location = new Point(12, 112);
            btnResetPass.Size     = new Size(246, 34);
            Theme.StyleColorButton(btnResetPass, Color.FromArgb(230, 126, 34));
            btnResetPass.Font   = Theme.FontBold;
            btnResetPass.Click += btnResetPass_Click;

            btnDelete.Text     = "✕  Удалить пользователя";
            btnDelete.Location = new Point(12, 156);
            btnDelete.Size     = new Size(246, 34);
            Theme.StyleColorButton(btnDelete, Theme.Danger);
            btnDelete.Font   = Theme.FontBold;
            btnDelete.Click += btnDelete_Click;

            grpActions.Controls.AddRange(new Control[]
                { lblActHint, btnChangeRole, btnResetPass, btnDelete });

            panelLeft.Controls.AddRange(new Control[] { grpAdd, grpActions });

            // ── panelRight — таблица пользователей ────────────────────
            panelRight.BackColor = Color.White;
            panelRight.Location  = new Point(290, 48);
            panelRight.Size      = new Size(630, 500);

            dgv.Location = new Point(0, 0);
            dgv.Size     = new Size(630, 472);
            Theme.StyleGrid(dgv);

            panelRight.Controls.Add(dgv);

            // ── panelBot ──────────────────────────────────────────────
            panelBot.BackColor = Color.FromArgb(232, 241, 235);
            panelBot.Dock      = DockStyle.Bottom;
            panelBot.Height    = 30;

            lblCount.AutoSize  = true;
            lblCount.Location  = new Point(14, 8);
            lblCount.Font      = Theme.FontSmall;
            lblCount.ForeColor = Theme.AccentLight;

            btnRefresh.Text      = "↻ Обновить";
            btnRefresh.Location  = new Point(820, 4);
            btnRefresh.Size      = new Size(90, 22);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.ForeColor = Theme.Accent;
            btnRefresh.FlatAppearance.BorderColor = Theme.AccentLight;
            btnRefresh.Click += btnRefresh_Click;

            panelBot.Controls.AddRange(new Control[] { lblCount, btnRefresh });

            Controls.AddRange(new Control[]
                { panelTop, panelLeft, panelRight, panelBot });

            panelTop.ResumeLayout();
            panelLeft.ResumeLayout();
            grpAdd.ResumeLayout();
            grpActions.ResumeLayout();
            panelRight.ResumeLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBot.ResumeLayout();
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
}
