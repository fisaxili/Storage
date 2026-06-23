using System.Data;
using Storage.BLL;

namespace Storage.UI.Reports
{
    /// <summary>Форма отчётов с экспортом в CSV.</summary>
    public partial class ReportsForm : Form
    {
        private readonly DataService _data;
        private readonly MainMenu    _mainMenu;
        private DataTable? _currentReport;

        public ReportsForm(DataService data, MainMenu mainMenu)
        {
            _data     = data;
            _mainMenu = mainMenu;
            InitializeComponent();
        }

        private void ReportsForm_Load(object sender, EventArgs e)
        {
            cmbReport.SelectedIndex = 0;
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                _currentReport = cmbReport.SelectedIndex switch
                {
                    0 => _data.GetTotalValueBySupplier(),
                    1 => _data.GetDetailCountByWarehouse(),
                    2 => _data.GetDetailsByPrice(),
                    3 => _data.GetFullDeliveryInfo(),
                    _ => null
                };

                if (_currentReport != null)
                {
                    dgvReport.DataSource = _currentReport;
                    lblCount.Text        = $"Записей: {_currentReport.Rows.Count}";
                    btnExport.Enabled    = true;
                }
            }
            catch (UnauthorizedAccessException ex)
            {
                MessageBox.Show(ex.Message, "Доступ запрещён",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения запроса:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_currentReport == null) return;
            using var dlg = new SaveFileDialog
            {
                Filter   = "CSV файл (*.csv)|*.csv",
                FileName = $"Отчёт_{DateTime.Now:yyyyMMdd_HHmm}.csv"
            };
            if (dlg.ShowDialog() != DialogResult.OK) return;
            try
            {
                _data.ExportToCsv(_currentReport, dlg.FileName);
                MessageBox.Show($"Файл сохранён:\n{dlg.FileName}",
                    "Экспорт выполнен", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка экспорта:\n{ex.Message}",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            _mainMenu.ShowFromChild();
            Hide();
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            base.OnFormClosed(e);
            _mainMenu.ShowFromChild();
        }
    }
}
