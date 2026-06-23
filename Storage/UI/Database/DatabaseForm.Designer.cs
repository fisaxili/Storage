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
            panelTop = new Panel();
            btnBack = new Button();
            lblAppBar = new Label();
            panelFilter = new Panel();
            lblTableLbl = new Label();
            cmbTable = new ComboBox();
            lblSearch = new Label();
            txtSearch = new TextBox();
            btnRefresh = new Button();
            dgv = new DataGridView();
            panelBottom = new Panel();
            btnAdd = new Button();
            btnEdit = new Button();
            btnDelete = new Button();
            panelRole = new Panel();
            lblRole = new Label();
            lblRecCount = new Label();
            panelTop.SuspendLayout();
            panelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            panelBottom.SuspendLayout();
            panelRole.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(45, 106, 79);
            panelTop.Controls.Add(btnBack);
            panelTop.Controls.Add(lblAppBar);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(980, 50);
            panelTop.TabIndex = 2;
            // 
            // btnBack
            // 
            btnBack.BackColor = Color.FromArgb(27, 67, 50);
            btnBack.Cursor = Cursors.Hand;
            btnBack.FlatAppearance.BorderColor = Color.FromArgb(100, 150, 100);
            btnBack.FlatStyle = FlatStyle.Flat;
            btnBack.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnBack.ForeColor = Color.White;
            btnBack.Location = new Point(12, 11);
            btnBack.Name = "btnBack";
            btnBack.Size = new Size(150, 28);
            btnBack.TabIndex = 0;
            btnBack.Text = "◀  Главное меню";
            btnBack.UseVisualStyleBackColor = false;
            btnBack.Click += btnBack_Click;
            // 
            // lblAppBar
            // 
            lblAppBar.AutoSize = true;
            lblAppBar.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            lblAppBar.ForeColor = Color.White;
            lblAppBar.Location = new Point(178, 13);
            lblAppBar.Name = "lblAppBar";
            lblAppBar.Size = new Size(273, 30);
            lblAppBar.TabIndex = 1;
            lblAppBar.Text = "📦  База данных склада";
            // 
            // panelFilter
            // 
            panelFilter.BackColor = Color.White;
            panelFilter.Controls.Add(lblTableLbl);
            panelFilter.Controls.Add(cmbTable);
            panelFilter.Controls.Add(lblSearch);
            panelFilter.Controls.Add(txtSearch);
            panelFilter.Controls.Add(btnRefresh);
            panelFilter.Dock = DockStyle.Top;
            panelFilter.Location = new Point(0, 50);
            panelFilter.Name = "panelFilter";
            panelFilter.Size = new Size(980, 52);
            panelFilter.TabIndex = 1;
            // 
            // lblTableLbl
            // 
            lblTableLbl.AutoSize = true;
            lblTableLbl.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            lblTableLbl.ForeColor = Color.FromArgb(100, 120, 100);
            lblTableLbl.Location = new Point(12, 17);
            lblTableLbl.Name = "lblTableLbl";
            lblTableLbl.Size = new Size(80, 21);
            lblTableLbl.TabIndex = 0;
            lblTableLbl.Text = "Таблица:";
            // 
            // cmbTable
            // 
            cmbTable.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTable.Font = new Font("Segoe UI", 9.5F);
            cmbTable.Items.AddRange(new object[] { "Детали", "Поставщики", "Склады", "Поставка" });
            cmbTable.Location = new Point(91, 13);
            cmbTable.Name = "cmbTable";
            cmbTable.Size = new Size(175, 29);
            cmbTable.TabIndex = 1;
            cmbTable.SelectedIndexChanged += cmbTable_SelectedIndexChanged;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Font = new Font("Segoe UI", 11F);
            lblSearch.Location = new Point(282, 14);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(33, 25);
            lblSearch.TabIndex = 2;
            lblSearch.Text = "🔍";
            // 
            // txtSearch
            // 
            txtSearch.BackColor = Color.FromArgb(248, 251, 248);
            txtSearch.BorderStyle = BorderStyle.FixedSingle;
            txtSearch.Font = new Font("Segoe UI", 9.5F);
            txtSearch.Location = new Point(312, 13);
            txtSearch.Name = "txtSearch";
            txtSearch.PlaceholderText = "Поиск по всем полям...";
            txtSearch.Size = new Size(320, 29);
            txtSearch.TabIndex = 3;
            txtSearch.TextChanged += txtSearch_TextChanged;
            // 
            // btnRefresh
            // 
            btnRefresh.Cursor = Cursors.Hand;
            btnRefresh.FlatAppearance.BorderColor = Color.FromArgb(82, 121, 111);
            btnRefresh.FlatStyle = FlatStyle.Flat;
            btnRefresh.Font = new Font("Segoe UI", 13F, FontStyle.Bold);
            btnRefresh.ForeColor = Color.FromArgb(45, 106, 79);
            btnRefresh.Location = new Point(638, 4);
            btnRefresh.Name = "btnRefresh";
            btnRefresh.Size = new Size(45, 45);
            btnRefresh.TabIndex = 4;
            btnRefresh.Text = "↻";
            btnRefresh.Click += btnRefresh_Click;
            // 
            // dgv
            // 
            dgv.ColumnHeadersHeight = 29;
            dgv.Dock = DockStyle.Fill;
            dgv.Location = new Point(0, 102);
            dgv.Name = "dgv";
            dgv.RowHeadersWidth = 51;
            dgv.Size = new Size(980, 432);
            dgv.TabIndex = 0;
            // 
            // panelBottom
            // 
            panelBottom.BackColor = Color.White;
            panelBottom.Controls.Add(btnAdd);
            panelBottom.Controls.Add(btnEdit);
            panelBottom.Controls.Add(btnDelete);
            panelBottom.Dock = DockStyle.Bottom;
            panelBottom.Location = new Point(0, 534);
            panelBottom.Name = "panelBottom";
            panelBottom.Size = new Size(980, 58);
            panelBottom.TabIndex = 3;
            // 
            // btnAdd
            // 
            btnAdd.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnAdd.Location = new Point(14, 11);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(145, 36);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "+  Добавить";
            btnAdd.Click += btnAdd_Click;
            // 
            // btnEdit
            // 
            btnEdit.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnEdit.Location = new Point(169, 11);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(145, 36);
            btnEdit.TabIndex = 1;
            btnEdit.Text = "✎  Изменить";
            btnEdit.Click += btnEdit_Click;
            // 
            // btnDelete
            // 
            btnDelete.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            btnDelete.Location = new Point(324, 11);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(145, 36);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "✕  Удалить";
            btnDelete.Click += btnDelete_Click;
            // 
            // panelRole
            // 
            panelRole.BackColor = Color.FromArgb(232, 241, 235);
            panelRole.Controls.Add(lblRole);
            panelRole.Controls.Add(lblRecCount);
            panelRole.Dock = DockStyle.Bottom;
            panelRole.Location = new Point(0, 592);
            panelRole.Name = "panelRole";
            panelRole.Size = new Size(980, 28);
            panelRole.TabIndex = 4;
            // 
            // lblRole
            // 
            lblRole.AutoSize = true;
            lblRole.Font = new Font("Segoe UI", 8.5F);
            lblRole.ForeColor = Color.FromArgb(82, 121, 111);
            lblRole.Location = new Point(14, 7);
            lblRole.Name = "lblRole";
            lblRole.Size = new Size(0, 20);
            lblRole.TabIndex = 0;
            // 
            // lblRecCount
            // 
            lblRecCount.AutoSize = true;
            lblRecCount.Font = new Font("Segoe UI", 8.5F);
            lblRecCount.ForeColor = Color.FromArgb(100, 120, 100);
            lblRecCount.Location = new Point(760, 7);
            lblRecCount.Name = "lblRecCount";
            lblRecCount.Size = new Size(0, 20);
            lblRecCount.TabIndex = 1;
            // 
            // DatabaseForm
            // 
            BackColor = Color.FromArgb(240, 244, 240);
            ClientSize = new Size(980, 620);
            Controls.Add(dgv);
            Controls.Add(panelFilter);
            Controls.Add(panelTop);
            Controls.Add(panelBottom);
            Controls.Add(panelRole);
            Font = new Font("Segoe UI", 9.5F);
            Name = "DatabaseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "База данных — Склад";
            Load += DatabaseForm_Load;
            panelTop.ResumeLayout(false);
            panelTop.PerformLayout();
            panelFilter.ResumeLayout(false);
            panelFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            panelBottom.ResumeLayout(false);
            panelRole.ResumeLayout(false);
            panelRole.PerformLayout();
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
