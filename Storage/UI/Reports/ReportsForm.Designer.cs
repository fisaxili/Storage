namespace Storage.UI.Reports
{
    partial class ReportsForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            panelTop   = new Panel();
            btnBack    = new Button();
            lblAppBar  = new Label();
            panelCtrl  = new Panel();
            lblReport  = new Label();
            cmbReport  = new ComboBox();
            btnExecute = new Button();
            btnExport  = new Button();
            dgvReport  = new DataGridView();
            panelBot   = new Panel();
            lblCount   = new Label();

            panelTop.SuspendLayout();
            panelCtrl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).BeginInit();
            panelBot.SuspendLayout();
            SuspendLayout();

            // ── Form ──────────────────────────────────────────────────
            ClientSize    = new Size(960, 600);
            Text          = "Отчёты — Склад";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor     = Theme.BgPage;
            Font          = Theme.FontBase;
            Load         += ReportsForm_Load;

            // ── panelTop ──────────────────────────────────────────────
            panelTop.BackColor = Theme.Accent;
            panelTop.Dock      = DockStyle.Top;
            panelTop.Height    = 50;

            btnBack.Text      = "◀  Главное меню";
            btnBack.Location  = new Point(12, 11);
            btnBack.Size      = new Size(150, 28);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.ForeColor = Color.White;
            btnBack.BackColor = Color.FromArgb(27, 67, 50);
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(100, 150, 100);
            btnBack.FlatAppearance.BorderSize  = 1;
            btnBack.Font      = Theme.FontBold;
            btnBack.Cursor    = Cursors.Hand;
            btnBack.Click    += btnBack_Click;

            lblAppBar.Text      = "📊  Отчёты и аналитика";
            lblAppBar.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location  = new Point(178, 13);
            lblAppBar.AutoSize  = true;

            panelTop.Controls.AddRange(new Control[] { btnBack, lblAppBar });

            // ── panelCtrl ─────────────────────────────────────────────
            panelCtrl.BackColor = Color.White;
            panelCtrl.Dock      = DockStyle.Top;
            panelCtrl.Height    = 56;

            lblReport.Text      = "Отчёт:";
            lblReport.Font      = Theme.FontBold;
            lblReport.ForeColor = Theme.TextMuted;
            lblReport.Location  = new Point(14, 19);
            lblReport.AutoSize  = true;

            cmbReport.Location      = new Point(76, 15);
            cmbReport.Size          = new Size(410, 26);
            cmbReport.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbReport.Font          = Theme.FontBase;
            cmbReport.Items.AddRange(new object[]
            {
                "Общая стоимость поставок по поставщику",
                "Суммарное количество деталей по складу",
                "Детали по убыванию цены",
                "Полная расшифровка поставок"
            });

            btnExecute.Text     = "▶  Выполнить";
            btnExecute.Location = new Point(500, 12);
            btnExecute.Size     = new Size(145, 32);
            Theme.StyleAccentButton(btnExecute);
            btnExecute.Click += btnExecute_Click;

            btnExport.Text     = "💾  Экспорт CSV";
            btnExport.Location = new Point(655, 12);
            btnExport.Size     = new Size(150, 32);
            Theme.StyleColorButton(btnExport, Theme.AccentLight);
            btnExport.Enabled  = false;
            btnExport.Click   += btnExport_Click;

            panelCtrl.Controls.AddRange(new Control[]
                { lblReport, cmbReport, btnExecute, btnExport });

            // ── dgvReport ─────────────────────────────────────────────
            dgvReport.Dock = DockStyle.Fill;
            Theme.StyleGrid(dgvReport);

            // ── panelBot ──────────────────────────────────────────────
            panelBot.BackColor = Color.FromArgb(232, 241, 235);
            panelBot.Dock      = DockStyle.Bottom;
            panelBot.Height    = 28;

            lblCount.AutoSize  = true;
            lblCount.Location  = new Point(14, 7);
            lblCount.Font      = Theme.FontSmall;
            lblCount.ForeColor = Theme.AccentLight;
            lblCount.Text      = "Выберите отчёт и нажмите «Выполнить»";
            panelBot.Controls.Add(lblCount);

            Controls.AddRange(new Control[]
                { dgvReport, panelCtrl, panelTop, panelBot });

            panelTop.ResumeLayout();
            panelCtrl.ResumeLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReport).EndInit();
            panelBot.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel        panelTop, panelCtrl, panelBot;
        private Label        lblAppBar, lblReport, lblCount;
        private Button       btnBack, btnExecute, btnExport;
        private ComboBox     cmbReport;
        private DataGridView dgvReport;
    }
}
