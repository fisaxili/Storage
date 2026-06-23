namespace Storage.UI
{
    /// <summary>
    /// Единая цветовая палитра и шрифты приложения «Склад».
    /// Складская тематика: тёмно-зелёный / оливковый.
    /// </summary>
    public static class Theme
    {
        // ── Цвета ─────────────────────────────────────────────────────
        public static readonly Color Accent      = Color.FromArgb(45, 106, 79);   // тёмно-зелёный
        public static readonly Color AccentHover = Color.FromArgb(27,  67, 50);   // при наведении
        public static readonly Color AccentLight = Color.FromArgb(82, 121, 111);  // мягкий зелёный

        public static readonly Color BgPage      = Color.FromArgb(240, 244, 240); // фон формы
        public static readonly Color BgCard      = Color.White;                   // карточки/панели
        public static readonly Color BgAltRow    = Color.FromArgb(232, 241, 235); // чередование строк DGV

        public static readonly Color TextPrimary = Color.FromArgb(23, 37, 23);    // основной текст
        public static readonly Color TextMuted   = Color.FromArgb(100, 120, 100); // второстепенный
        public static readonly Color TextOnAccent = Color.White;

        // Статусные
        public static readonly Color Success = Color.FromArgb(40,  167, 69);
        public static readonly Color Danger  = Color.FromArgb(192, 57,  43);
        public static readonly Color Info    = Color.FromArgb(52,  152, 219);

        // ── Шрифты ────────────────────────────────────────────────────
        public static readonly Font FontBase    = new("Segoe UI", 9.5f);
        public static readonly Font FontBold    = new("Segoe UI", 9.5f, FontStyle.Bold);
        public static readonly Font FontTitle   = new("Segoe UI", 13f,  FontStyle.Bold);
        public static readonly Font FontHeader  = new("Segoe UI", 14f,  FontStyle.Bold);
        public static readonly Font FontSmall   = new("Segoe UI", 8.5f);

        // ── Вспомогательные методы ────────────────────────────────────

        /// <summary>Применить стиль основной кнопки-акцента.</summary>
        public static void StyleAccentButton(Button btn)
        {
            btn.BackColor = Accent;
            btn.ForeColor = TextOnAccent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize  = 0;
            btn.Font      = FontBold;
            btn.Cursor    = Cursors.Hand;
            btn.MouseEnter += (_, _) => btn.BackColor = AccentHover;
            btn.MouseLeave += (_, _) => btn.BackColor = Accent;
        }

        /// <summary>Применить стиль кнопки действия с указанным цветом.</summary>
        public static void StyleColorButton(Button btn, Color baseColor)
        {
            btn.BackColor = baseColor;
            btn.ForeColor = TextOnAccent;
            btn.FlatStyle = FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font   = FontBase;
            btn.Cursor = Cursors.Hand;
        }

        /// <summary>Применить стиль шапки DataGridView.</summary>
        public static void StyleGrid(DataGridView dgv)
        {
            dgv.BackgroundColor     = BgCard;
            dgv.BorderStyle         = BorderStyle.None;
            dgv.GridColor           = Color.FromArgb(210, 225, 210);
            dgv.RowHeadersVisible   = false;
            dgv.AllowUserToAddRows    = false;
            dgv.AllowUserToDeleteRows = false;
            dgv.ReadOnly              = true;
            dgv.AutoSizeColumnsMode   = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.SelectionMode         = DataGridViewSelectionMode.FullRowSelect;
            dgv.EnableHeadersVisualStyles = false;

            dgv.ColumnHeadersDefaultCellStyle.BackColor  = Accent;
            dgv.ColumnHeadersDefaultCellStyle.ForeColor  = TextOnAccent;
            dgv.ColumnHeadersDefaultCellStyle.Font       = FontBold;
            dgv.ColumnHeadersDefaultCellStyle.Padding    = new Padding(6, 4, 6, 4);

            dgv.AlternatingRowsDefaultCellStyle.BackColor = BgAltRow;
            dgv.DefaultCellStyle.SelectionBackColor       = AccentLight;
            dgv.DefaultCellStyle.SelectionForeColor       = TextOnAccent;
            dgv.DefaultCellStyle.Font                     = FontBase;
            dgv.RowTemplate.Height                        = 26;
        }
    }
}
