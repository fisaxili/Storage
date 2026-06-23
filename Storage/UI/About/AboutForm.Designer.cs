namespace Storage.UI.About
{
    partial class AboutForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));
            panelTop = new Panel();
            lblIcon = new Label();
            lblAppName = new Label();
            lblVersion = new Label();
            panelBody = new Panel();
            lblDesc = new Label();
            panelTech = new Panel();
            lblTechTitle = new Label();
            lblTech = new Label();
            panelRoles = new Panel();
            lblRolesTitle = new Label();
            lblRoles = new Label();
            panelAuthor = new Panel();
            lblAuthorTitle = new Label();
            lblAuthor = new Label();
            lblCurrentUser = new Label();
            btnClose = new Button();
            panelTop.SuspendLayout();
            panelBody.SuspendLayout();
            panelTech.SuspendLayout();
            panelRoles.SuspendLayout();
            panelAuthor.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 106, 79);
            panelTop.Controls.Add(lblIcon);
            panelTop.Controls.Add(lblAppName);
            panelTop.Controls.Add(lblVersion);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(500, 110);
            panelTop.TabIndex = 0;
            // 
            // lblIcon
            // 
            lblIcon.AutoSize = true;
            lblIcon.Font = new Font("Segoe UI", 40F);
            lblIcon.ForeColor = Color.White;
            lblIcon.Location = new Point(20, 28);
            lblIcon.Name = "lblIcon";
            lblIcon.Size = new Size(130, 89);
            lblIcon.TabIndex = 0;
            lblIcon.Text = "📦";
            // 
            // lblAppName
            // 
            lblAppName.AutoSize = true;
            lblAppName.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAppName.ForeColor = Color.White;
            lblAppName.Location = new Point(110, 28);
            lblAppName.Name = "lblAppName";
            lblAppName.Size = new Size(378, 35);
            lblAppName.TabIndex = 1;
            lblAppName.Text = "Система управления складом";
            // 
            // lblVersion
            // 
            lblVersion.AutoSize = true;
            lblVersion.Font = new Font("Segoe UI", 8.5F);
            lblVersion.ForeColor = Color.FromArgb(185, 225, 185);
            lblVersion.Location = new Point(112, 65);
            lblVersion.Name = "lblVersion";
            lblVersion.Size = new Size(146, 20);
            lblVersion.TabIndex = 2;
            lblVersion.Text = "Версия 1.0  ·  2026 г.";
            // 
            // panelBody
            // 
            panelBody.AutoScroll = true;
            panelBody.BackColor = Color.White;
            panelBody.Controls.Add(lblDesc);
            panelBody.Controls.Add(panelTech);
            panelBody.Controls.Add(panelRoles);
            panelBody.Controls.Add(panelAuthor);
            panelBody.Controls.Add(lblCurrentUser);
            panelBody.Controls.Add(btnClose);
            panelBody.Location = new Point(0, 110);
            panelBody.Name = "panelBody";
            panelBody.Size = new Size(500, 400);
            panelBody.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.Font = new Font("Segoe UI", 9.5F);
            lblDesc.ForeColor = Color.FromArgb(23, 37, 23);
            lblDesc.Location = new Point(20, 16);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(460, 56);
            lblDesc.TabIndex = 0;
            lblDesc.Text = "Настольное приложение для автоматизации учёта\nна складе: ведение справочников деталей и поставщиков,\nуправление поставками, формирование аналитических отчётов.";
            // 
            // panelTech
            // 
            panelTech.BackColor = Color.FromArgb(232, 241, 235);
            panelTech.Controls.Add(lblTechTitle);
            panelTech.Controls.Add(lblTech);
            panelTech.Location = new Point(16, 82);
            panelTech.Name = "panelTech";
            panelTech.Padding = new Padding(12, 8, 12, 8);
            panelTech.Size = new Size(466, 90);
            panelTech.TabIndex = 1;
            // 
            // lblTechTitle
            // 
            lblTechTitle.AutoSize = true;
            lblTechTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTechTitle.ForeColor = Color.FromArgb(45, 106, 79);
            lblTechTitle.Location = new Point(12, 10);
            lblTechTitle.Name = "lblTechTitle";
            lblTechTitle.Size = new Size(141, 21);
            lblTechTitle.TabIndex = 0;
            lblTechTitle.Text = "Стек технологий";
            // 
            // lblTech
            // 
            lblTech.Font = new Font("Segoe UI", 9.5F);
            lblTech.ForeColor = Color.FromArgb(23, 37, 23);
            lblTech.Location = new Point(12, 32);
            lblTech.Name = "lblTech";
            lblTech.Size = new Size(442, 52);
            lblTech.TabIndex = 1;
            lblTech.Text = "• Платформа: .NET 8 (Windows)\n• Интерфейс: Windows Forms\n• База данных: Microsoft Access (.accdb) через OLE DB\n• Тесты: xUnit  ·  DI: Microsoft.Extensions.DependencyInjection";
            // 
            // panelRoles
            // 
            panelRoles.BackColor = Color.White;
            panelRoles.Controls.Add(lblRolesTitle);
            panelRoles.Controls.Add(lblRoles);
            panelRoles.Location = new Point(16, 182);
            panelRoles.Name = "panelRoles";
            panelRoles.Size = new Size(466, 136);
            panelRoles.TabIndex = 2;
            // 
            // lblRolesTitle
            // 
            lblRolesTitle.AutoSize = true;
            lblRolesTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblRolesTitle.ForeColor = Color.FromArgb(45, 106, 79);
            lblRolesTitle.Location = new Point(0, 0);
            lblRolesTitle.Name = "lblRolesTitle";
            lblRolesTitle.Size = new Size(174, 21);
            lblRolesTitle.TabIndex = 0;
            lblRolesTitle.Text = "Роли пользователей";
            // 
            // lblRoles
            // 
            lblRoles.Font = new Font("Segoe UI", 9.5F);
            lblRoles.ForeColor = Color.FromArgb(23, 37, 23);
            lblRoles.Location = new Point(0, 24);
            lblRoles.Name = "lblRoles";
            lblRoles.Size = new Size(466, 106);
            lblRoles.TabIndex = 1;
            lblRoles.Text = resources.GetString("lblRoles.Text");
            lblRoles.Click += lblRoles_Click_1;
            // 
            // panelAuthor
            // 
            panelAuthor.BackColor = Color.FromArgb(232, 241, 235);
            panelAuthor.Controls.Add(lblAuthorTitle);
            panelAuthor.Controls.Add(lblAuthor);
            panelAuthor.Location = new Point(16, 310);
            panelAuthor.Name = "panelAuthor";
            panelAuthor.Size = new Size(466, 62);
            panelAuthor.TabIndex = 3;
            // 
            // lblAuthorTitle
            // 
            lblAuthorTitle.AutoSize = true;
            lblAuthorTitle.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblAuthorTitle.ForeColor = Color.FromArgb(45, 106, 79);
            lblAuthorTitle.Location = new Point(12, 10);
            lblAuthorTitle.Name = "lblAuthorTitle";
            lblAuthorTitle.Size = new Size(118, 21);
            lblAuthorTitle.TabIndex = 0;
            lblAuthorTitle.Text = "Безопасность";
            // 
            // lblAuthor
            // 
            lblAuthor.Font = new Font("Segoe UI", 9.5F);
            lblAuthor.ForeColor = Color.FromArgb(23, 37, 23);
            lblAuthor.Location = new Point(12, 32);
            lblAuthor.Name = "lblAuthor";
            lblAuthor.Size = new Size(442, 22);
            lblAuthor.TabIndex = 1;
            lblAuthor.Text = "🔒 Пароли хранятся как SHA-256 хеш  ·  🛡 Защита от SQL-инъекций  ·  ⏱ Брутфорс: 3 попытки → блокировка 30 мин";
            // 
            // lblCurrentUser
            // 
            lblCurrentUser.AutoSize = true;
            lblCurrentUser.Font = new Font("Segoe UI", 8.5F);
            lblCurrentUser.ForeColor = Color.FromArgb(82, 121, 111);
            lblCurrentUser.Location = new Point(20, 380);
            lblCurrentUser.Name = "lblCurrentUser";
            lblCurrentUser.Size = new Size(0, 20);
            lblCurrentUser.TabIndex = 4;
            // 
            // btnClose
            // 
            btnClose.DialogResult = DialogResult.Cancel;
            btnClose.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnClose.Location = new Point(178, 355);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(144, 36);
            btnClose.TabIndex = 5;
            btnClose.Text = "Закрыть";
            // 
            // AboutForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            CancelButton = btnClose;
            ClientSize = new Size(500, 560);
            Controls.Add(panelTop);
            Controls.Add(panelBody);
            Font = new Font("Segoe UI", 9.5F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "AboutForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "О программе";
            Load += AboutForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelBody.ResumeLayout(false);
            panelBody.PerformLayout();
            panelTech.ResumeLayout(false);
            panelTech.PerformLayout();
            panelRoles.ResumeLayout(false);
            panelRoles.PerformLayout();
            panelAuthor.ResumeLayout(false);
            panelAuthor.PerformLayout();
            ResumeLayout(false);
        }

        private Panel  panelTop, panelBody, panelTech, panelRoles, panelAuthor;
        private Label  lblIcon, lblAppName, lblVersion;
        private Label  lblDesc;
        private Label  lblTechTitle, lblTech;
        private Label  lblRolesTitle, lblRoles;
        private Label  lblAuthorTitle, lblAuthor;
        private Label  lblCurrentUser;
        private Button btnClose;
    }
}
