namespace Storage.UI
{
    partial class MainMenu
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
            lblAppIcon = new Label();
            lblAppTitle = new Label();
            lblWelcome = new Label();
            lblRole = new Label();
            btnLogout = new Button();
            panelCards = new Panel();
            cardDatabase = new Panel();
            cardReports = new Panel();
            cardUsers = new Panel();
            cardProfile = new Panel();
            cardAbout = new Panel();
            panelFooter = new Panel();
            lblFooter = new Label();
            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // panelHeader
            // 
            panelHeader.Controls.Add(lblAppIcon);
            panelHeader.Controls.Add(lblAppTitle);
            panelHeader.Controls.Add(lblWelcome);
            panelHeader.Controls.Add(lblRole);
            panelHeader.Controls.Add(btnLogout);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1000, 72);
            panelHeader.TabIndex = 1;
            // 
            // lblAppIcon
            // 
            lblAppIcon.AutoSize = true;
            lblAppIcon.Font = new Font("Segoe UI", 22F);
            lblAppIcon.ForeColor = Color.White;
            lblAppIcon.Location = new Point(3, 9);
            lblAppIcon.Name = "lblAppIcon";
            lblAppIcon.Size = new Size(73, 50);
            lblAppIcon.TabIndex = 0;
            lblAppIcon.Text = "📦";
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 15F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(82, 9);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(378, 35);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Система управления складом";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.ForeColor = Color.FromArgb(185, 225, 185);
            lblWelcome.Location = new Point(82, 44);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(0, 20);
            lblWelcome.TabIndex = 2;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(185, 225, 185);
            lblRole.Location = new Point(440, 44);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 20);
            lblRole.TabIndex = 3;
            // 
            // btnLogout
            // 
            btnLogout.BackColor = Color.FromArgb(180, 50, 40);
            btnLogout.Cursor = Cursors.Hand;
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(878, 20);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(108, 32);
            btnLogout.TabIndex = 4;
            btnLogout.Text = "\u23fb  Выйти";
            btnLogout.UseVisualStyleBackColor = false;
            btnLogout.Click += btnLogout_Click;
            // 
            // panelCards
            // 
            panelCards.Controls.Add(cardDatabase);
            panelCards.Controls.Add(cardReports);
            panelCards.Controls.Add(cardUsers);
            panelCards.Controls.Add(cardProfile);
            panelCards.Controls.Add(cardAbout);
            panelCards.Dock = DockStyle.Fill;
            panelCards.Location = new Point(0, 72);
            panelCards.Name = "panelCards";
            panelCards.Size = new Size(1000, 440);
            panelCards.TabIndex = 0;
            // 
            // cardDatabase
            // 
            cardDatabase.Cursor = Cursors.Hand;
            cardDatabase.Location = new Point(30, 30);
            cardDatabase.Name = "cardDatabase";
            cardDatabase.Size = new Size(185, 170);
            cardDatabase.TabIndex = 0;
            // 
            // cardReports
            // 
            cardReports.Cursor = Cursors.Hand;
            cardReports.Location = new Point(240, 30);
            cardReports.Name = "cardReports";
            cardReports.Size = new Size(185, 170);
            cardReports.TabIndex = 1;
            // 
            // cardUsers
            // 
            cardUsers.Cursor = Cursors.Hand;
            cardUsers.Location = new Point(450, 30);
            cardUsers.Name = "cardUsers";
            cardUsers.Size = new Size(185, 170);
            cardUsers.TabIndex = 2;
            // 
            // cardProfile
            // 
            cardProfile.Cursor = Cursors.Hand;
            cardProfile.Location = new Point(135, 220);
            cardProfile.Name = "cardProfile";
            cardProfile.Size = new Size(185, 170);
            cardProfile.TabIndex = 3;
            // 
            // cardAbout
            // 
            cardAbout.Cursor = Cursors.Hand;
            cardAbout.Location = new Point(345, 220);
            cardAbout.Name = "cardAbout";
            cardAbout.Size = new Size(185, 170);
            cardAbout.TabIndex = 4;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(lblFooter);
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 512);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(1000, 28);
            panelFooter.TabIndex = 2;
            // 
            // lblFooter
            // 
            lblFooter.AutoSize = true;
            lblFooter.Location = new Point(14, 7);
            lblFooter.Name = "lblFooter";
            lblFooter.Size = new Size(542, 20);
            lblFooter.TabIndex = 0;
            lblFooter.Text = "Система управления складом  ·  .NET 8  ·  Windows Forms  ·  MS Access  ·  xUnit";
            // 
            // MainMenu
            // 
            ClientSize = new Size(1000, 540);
            Controls.Add(panelCards);
            Controls.Add(panelHeader);
            Controls.Add(panelFooter);
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Склад — Главное меню";
            Load += MainMenu_Load;
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelCards.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        private Panel panelHeader, panelCards, panelFooter;
        private Label lblAppIcon, lblAppTitle, lblWelcome, lblRole, lblFooter;
        private Button btnLogout;
        private Panel cardDatabase, cardReports, cardUsers, cardProfile, cardAbout;
        #endregion
    }
}