namespace Storage.UI.Database
{
    partial class DatabaseForm
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
            panelTop    = new Panel();
            lblAppBar   = new Label();
            btnBack     = new Button();
            panelFilter = new Panel();
            lblTableLbl = new Label();
            cmbTable    = new ComboBox();
            lblSearch   = new Label();
            txtSearch   = new TextBox();
            btnRefresh  = new Button();
            dgv         = new DataGridView();
            panelBottom = new Panel();
            btnAdd      = new Button();
            btnEdit     = new Button();
            btnDelete   = new Button();
            panelRole   = new Panel();
            lblRole     = new Label();
            lblRecCount = new Label();

            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBottom.SuspendLayout();
            panelRole.SuspendLayout();
            SuspendLayout();

            // Form 
            ClientSize    = new Size(980, 620);
            Text          = "База данных — Склад";
            StartPosition = FormStartPosition.CenterScreen;
            BackColor     = Theme.BgPage;
            Font          = Theme.FontBase;
            Load         += DatabaseForm_Load;

            //panelTop 
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

            lblAppBar.Text      = "📦  База данных склада";
            lblAppBar.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location  = new Point(178, 13);
            lblAppBar.AutoSize  = true;

            panelTop.Controls.AddRange(new Control[] { btnBack, lblAppBar });

            //panelFilter 
            panelFilter.BackColor = Color.White;
            panelFilter.Dock      = DockStyle.Top;
            panelFilter.Height    = 52;

            lblTableLbl.Text      = "Таблица:";
            lblTableLbl.Font      = Theme.FontBold;
            lblTableLbl.ForeColor = Theme.TextMuted;
            lblTableLbl.Location  = new Point(14, 17);
            lblTableLbl.AutoSize  = true;

            cmbTable.Location      = new Point(88, 13);
            cmbTable.Size          = new Size(175, 26);
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.Font          = Theme.FontBase;
            cmbTable.Items.AddRange(new object[]
                { "Детали", "Поставщики", "Склады", "Поставка" });
            cmbTable.SelectedIndex         = 0;
            cmbTable.SelectedIndexChanged += cmbTable_SelectedIndexChanged;

            lblSearch.Text      = "🔍";
            lblSearch.Font      = new Font("Segoe UI", 11f);
            lblSearch.Location  = new Point(282, 14);
            lblSearch.AutoSize  = true;

            txtSearch.Location        = new Point(312, 13);
            txtSearch.Size            = new Size(320, 26);
            txtSearch.Font            = Theme.FontBase;
            txtSearch.BorderStyle     = BorderStyle.FixedSingle;
            txtSearch.BackColor       = Color.FromArgb(248, 251, 248);
            txtSearch.PlaceholderText = "Поиск по всем полям...";
            txtSearch.TextChanged    += txtSearch_TextChanged;

            btnRefresh.Text      = "↻";
            btnRefresh.Font      = new Font("Segoe UI", 13f, FontStyle.Bold);
            btnRefresh.Location  = new Point(645, 10);
            btnRefresh.Size      = new Size(36, 30);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.FlatAppearance.BorderColor = Theme.AccentLight;
            btnRefresh.ForeColor = Theme.Accent;
            btnRefresh.Cursor    = Cursors.Hand;
            btnRefresh.Click    += btnRefresh_Click;

            panelFilter.Controls.AddRange(new Control[]
                { lblTableLbl, cmbTable, lblSearch, txtSearch, btnRefresh });

            // dgv 
            dgv.Dock = DockStyle.Fill;
            Theme.StyleGrid(dgv);

            //  panelRole 
            panelRole.BackColor = Color.FromArgb(232, 241, 235);
            panelRole.Dock      = DockStyle.Bottom;
            panelRole.Height    = 28;

            lblRole.AutoSize  = true;
            lblRole.Location  = new Point(14, 7);
            lblRole.Font      = Theme.FontSmall;
            lblRole.ForeColor = Theme.AccentLight;

            lblRecCount.AutoSize  = true;
            lblRecCount.Location  = new Point(760, 7);
            lblRecCount.Font      = Theme.FontSmall;
            lblRecCount.ForeColor = Theme.TextMuted;

            panelRole.Controls.AddRange(new Control[] { lblRole, lblRecCount });

            //panelBottom 
            panelBottom.BackColor = Color.White;
            panelBottom.Dock      = DockStyle.Bottom;
            panelBottom.Height    = 58;

            btnAdd.Text     = "+  Добавить";
            btnAdd.Location = new Point(14, 11);
            btnAdd.Size     = new Size(145, 36);
            Theme.StyleColorButton(btnAdd, Theme.Success);
            btnAdd.Font   = Theme.FontBold;
            btnAdd.Click += btnAdd_Click;

            btnEdit.Text     = "✎  Изменить";
            btnEdit.Location = new Point(169, 11);
            btnEdit.Size     = new Size(145, 36);
            Theme.StyleColorButton(btnEdit, Theme.Info);
            btnEdit.Font   = Theme.FontBold;
            btnEdit.Click += btnEdit_Click;

            btnDelete.Text     = "✕  Удалить";
            btnDelete.Location = new Point(324, 11);
            btnDelete.Size     = new Size(145, 36);
            Theme.StyleColorButton(btnDelete, Theme.Danger);
            btnDelete.Font   = Theme.FontBold;
            btnDelete.Click += btnDelete_Click;

            panelBottom.Controls.AddRange(new Control[] { btnAdd, btnEdit, btnDelete });

            Controls.AddRange(new Control[]
                { dgv, panelFilter, panelTop, panelBottom, panelRole });

            panelTop.ResumeLayout();
            panelFilter.ResumeLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBottom.ResumeLayout();
            panelRole.ResumeLayout();
            ResumeLayout(false);
        }

        private Panel        panelTop, panelFilter, panelBottom, panelRole;
        private Label        lblAppBar, lblTableLbl, lblSearch, lblRole, lblRecCount;
        private Button       btnBack, btnRefresh, btnAdd, btnEdit, btnDelete;
        private ComboBox     cmbTable;
        private TextBox      txtSearch;
        private DataGridView dgv;
    }
    #endregion
}
