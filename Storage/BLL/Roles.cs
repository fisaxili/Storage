namespace Storage.BLL
{
    /// <summary>Роли пользователей системы управления складом.</summary>
    public static class Roles
    {
        /// <summary>Директор — полный доступ: CRUD по всем таблицам, удаление, отчёты.</summary>
        public const string Director = "Директор";

        /// <summary>Кладовщик — добавление и редактирование поставок, деталей, складов.</summary>
        public const string Storekeeper = "Кладовщик";

        /// <summary>Бухгалтер — только просмотр и формирование/экспорт отчётов.</summary>
        public const string Accountant = "Бухгалтер";

        /// <summary>Гость — только просмотр таблиц, без отчётов.</summary>
        public const string Guest = "Гость";

        public static readonly string[] All =
        {
            Director, Storekeeper, Accountant, Guest
        };
    }
}
