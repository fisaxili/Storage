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
        private void InitializeComponent()
        {
            panelHeader  = new Panel();
            lblAppIcon   = new Label();
            lblAppTitle  = new Label();
            lblWelcome   = new Label();
            lblRole      = new Label();
            btnLogout    = new Button();
            panelCards   = new Panel();
            cardDatabase = new Panel();
            cardReports  = new Panel();
            cardUsers    = new Panel();
            cardProfile  = new Panel();
            cardAbout    = new Panel();
            panelFooter  = new Panel();
            lblFooter    = new Label();

            panelHeader.SuspendLayout();
            panelCards.SuspendLayout();
            SuspendLayout();

            // Form 
            ClientSize    = new Size(1000, 540);
            Text          = "Склад — Главное меню";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor     = Theme.BgPage;
            Font          = Theme.FontBase;
            Load         += MainMenu_Load;

            // panelHeader 
            panelHeader.BackColor = Theme.Accent;
            panelHeader.Dock      = DockStyle.Top;
            panelHeader.Height    = 72;

            lblAppIcon.Text      = "📦";
            lblAppIcon.Font      = new Font("Segoe UI", 22f);
            lblAppIcon.ForeColor = Color.White;
            lblAppIcon.Location  = new Point(18, 18);
            lblAppIcon.AutoSize  = true;

            lblAppTitle.Text      = "Система управления складом";
            lblAppTitle.Font      = new Font("Segoe UI", 15f, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location  = new Point(64, 12);
            lblAppTitle.AutoSize  = true;

            lblWelcome.Text      = "";
            lblWelcome.Font      = Theme.FontBase;
            lblWelcome.ForeColor = Color.FromArgb(185, 225, 185);
            lblWelcome.Location  = new Point(66, 44);
            lblWelcome.AutoSize  = true;

            lblRole.Text      = "";
            lblRole.Font      = new Font("Segoe UI", 9f, FontStyle.Bold);
            lblRole.ForeColor = Color.FromArgb(185, 225, 185);
            lblRole.Location  = new Point(440, 44);
            lblRole.AutoSize  = true;

            btnLogout.Text      = "⏻  Выйти";
            btnLogout.Location  = new Point(878, 20);
            btnLogout.Size      = new Size(108, 32);
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.BackColor = Color.FromArgb(180, 50, 40);
            btnLogout.FlatAppearance.BorderSize = 0;
            btnLogout.Font      = Theme.FontBold;
            btnLogout.Cursor    = Cursors.Hand;
            btnLogout.Click    += btnLogout_Click;

            panelHeader.Controls.AddRange(new Control[]
                { lblAppIcon, lblAppTitle, lblWelcome, lblRole, btnLogout });

            // panelCards 
            panelCards.BackColor = Theme.BgPage;
            panelCards.Dock      = DockStyle.Fill;

            // Хелпер создания карточки
            Panel MakeCard(string icon, string title, string desc, int x, int y, EventHandler handler)
            {
                var card = new Panel
                {
                    Size      = new Size(185, 170),
                    Location  = new Point(x, y),
                    BackColor = Theme.Accent,
                    Cursor    = Cursors.Hand
                };

                var ico = new Label
                {
                    Text      = icon,
                    Font      = new Font("Segoe UI", 28f),
                    ForeColor = Color.White,
                    Location  = new Point(65, 14),
                    AutoSize  = true
                };

                var lTitle = new Label
                {
                    Text      = title,
                    Font      = new Font("Segoe UI", 10f, FontStyle.Bold),
                    ForeColor = Color.White,
                    Location  = new Point(8, 80),
                    Size      = new Size(169, 20),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                var lDesc = new Label
                {
                    Text      = desc,
                    Font      = Theme.FontSmall,
                    ForeColor = Color.FromArgb(200, 235, 200),
                    Location  = new Point(8, 104),
                    Size      = new Size(169, 36),
                    TextAlign = ContentAlignment.MiddleCenter
                };

                card.Controls.AddRange(new Control[] { ico, lTitle, lDesc });

                card.MouseEnter += (_, _) => { if (card.Enabled) card.BackColor = Theme.AccentHover; };
                card.MouseLeave += (_, _) => { if (card.Enabled) card.BackColor = Theme.Accent; };

                card.Click += handler;
                foreach (Control c in card.Controls) c.Click += handler;

                return card;
            }

            // Ряд 1
            cardDatabase = MakeCard("📦", "База данных",
                "Таблицы, поиск,\nдобавление записей",
                30, 30,
                (_, _) => cardDatabase_Click(null!, EventArgs.Empty));

            cardReports = MakeCard("📊", "Отчёты",
                "Аналитика\nи экспорт CSV",
                240, 30,
                (_, _) => cardReports_Click(null!, EventArgs.Empty));

            cardUsers = MakeCard("👥", "Пользователи",
                "Управление\nаккаунтами",
                450, 30,
                (_, _) => cardUsers_Click(null!, EventArgs.Empty));

            // Ряд 2
            cardProfile = MakeCard("👤", "Личный кабинет",
                "Профиль\nи смена пароля",
                135, 220,
                (_, _) => cardProfile_Click(null!, EventArgs.Empty));

            cardAbout = MakeCard("ℹ", "О программе",
                "Версия, стек,\nроли, безопасность",
                345, 220,
                (_, _) => cardAbout_Click(null!, EventArgs.Empty));

            panelCards.Controls.AddRange(new Control[]
                { cardDatabase, cardReports, cardUsers, cardProfile, cardAbout });

            //panelFooter
            panelFooter.BackColor = Color.White;
            panelFooter.Dock      = DockStyle.Bottom;
            panelFooter.Height    = 28;

            lblFooter.Text      = "Система управления складом  ·  .NET 8  ·  Windows Forms  ·  MS Access  ·  xUnit";
            lblFooter.Font      = Theme.FontSmall;
            lblFooter.ForeColor = Theme.TextMuted;
            lblFooter.Location  = new Point(14, 7);
            lblFooter.AutoSize  = true;

            panelFooter.Controls.Add(lblFooter);

            Controls.AddRange(new Control[]
                { panelCards, panelHeader, panelFooter });

            panelHeader.ResumeLayout();
            panelCards.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel  panelHeader, panelCards, panelFooter;
        private Label  lblAppIcon, lblAppTitle, lblWelcome, lblRole, lblFooter;
        private Button btnLogout;
        private Panel  cardDatabase, cardReports, cardUsers, cardProfile, cardAbout;
    }
}
