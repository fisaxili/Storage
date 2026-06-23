using System.Data;

namespace Storage.UI.Database
{
    /// <summary>
    /// Диалоговое окно для добавления или редактирования одной записи таблицы.
    /// Генерирует поля динамически на основе структуры DataTable.
    /// </summary>
    public class EditRecordForm : Form
    {
        public Dictionary<string, object?> Values { get; } = new();

        private readonly DataTable  _schema;
        private readonly DataRow?   _existingRow;
        private readonly string     _tableName;
        private readonly string     _pkColumn;

        // Словарь: имя колонки → TextBox (или ComboBox)
        private readonly Dictionary<string, Control> _inputs = new();

        public EditRecordForm(DataTable schema, DataRow? existingRow, string tableName)
        {
            _schema      = schema;
            _existingRow = existingRow;
            _tableName   = tableName;
            _pkColumn    = BLL.DataService.GetPrimaryKey(tableName);

            BuildForm();
        }

        private void BuildForm()
        {
            Text            = _existingRow == null ? $"Добавить — {_tableName}" : $"Изменить — {_tableName}";
            StartPosition   = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox     = false;
            BackColor       = Color.FromArgb(244, 246, 250);
            Font            = new Font("Segoe UI", 9.5f);
            AutoScroll      = true;

            int y      = 15;
            int width  = 380;

            foreach (DataColumn col in _schema.Columns)
            {
                // Счётчик (PK) — пропускаем при добавлении
                bool isPk = col.ColumnName == _pkColumn;
                if (isPk && _existingRow == null) continue;

                var lbl = new Label
                {
                    Text     = col.ColumnName + ":",
                    Location = new Point(15, y),
                    AutoSize = true
                };
                Controls.Add(lbl);
                y += 20;

                var txt = new TextBox
                {
                    Location  = new Point(15, y),
                    Size      = new Size(width, 26),
                    ReadOnly  = isPk,    // ПК не редактируем
                    BackColor = isPk ? Color.FromArgb(240, 240, 240) : Color.White
                };

                if (_existingRow != null)
                    txt.Text = _existingRow[col.ColumnName]?.ToString() ?? "";

                Controls.Add(txt);
                _inputs[col.ColumnName] = txt;
                y += 35;
            }

            // Кнопки
            var btnOk = new Button
            {
                Text      = "Сохранить",
                Location  = new Point(15, y + 10),
                Size      = new Size(180, 34),
                BackColor = Color.FromArgb(46, 74, 107),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat,
                DialogResult = DialogResult.None
            };
            btnOk.FlatAppearance.BorderSize = 0;
            btnOk.Click += BtnOk_Click;

            var btnCancel = new Button
            {
                Text         = "Отмена",
                Location     = new Point(210, y + 10),
                Size         = new Size(180, 34),
                FlatStyle    = FlatStyle.Flat,
                DialogResult = DialogResult.Cancel
            };

            Controls.AddRange(new Control[] { btnOk, btnCancel });
            ClientSize   = new Size(width + 30, y + 65);
            AcceptButton = btnOk;
            CancelButton = btnCancel;
        }

        private void BtnOk_Click(object? sender, EventArgs e)
        {
            Values.Clear();
            foreach (var (colName, ctrl) in _inputs)
            {
                if (colName == _pkColumn && _existingRow == null) continue;

                var text  = ctrl is TextBox tb ? tb.Text.Trim() : ctrl.Text.Trim();
                var col   = _schema.Columns[colName]!;

                // Не включаем ПК в словарь обновления
                if (colName == _pkColumn) continue;

                // Преобразуем тип
                if (string.IsNullOrEmpty(text))
                {
                    Values[colName] = DBNull.Value;
                }
                else
                {
                    try
                    {
                        Values[colName] = Convert.ChangeType(text, col.DataType);
                    }
                    catch
                    {
                        MessageBox.Show($"Некорректное значение для поля «{colName}».\nОжидается тип: {col.DataType.Name}",
                                        "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                }
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
