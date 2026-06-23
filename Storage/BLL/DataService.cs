using System.Data;
using Storage.DAL;

namespace Storage.BLL
{
    // Сервис для работы с данными склада.
    // Перед каждой операцией проверяет права текущего пользователя.
    //
    // Права доступа:
    //   Директор   — всё: просмотр, добавление, редактирование, удаление, отчёты
    //   Кладовщик  — просмотр, добавление и редактирование (без удаления)
    //   Бухгалтер  — просмотр и отчёты (без редактирования)
    //   Гость      — только просмотр
    public class DataService
    {
        private readonly DataRepository _repo;
        private readonly UserSession    _session;

        // Первичные ключи каждой таблицы — нужны для UPDATE и DELETE
        private static readonly Dictionary<string, string> PrimaryKeys =
            new(StringComparer.OrdinalIgnoreCase)
            {
                { "Детали",     "Код_Детали"     },
                { "Поставщики", "Код_Поставщика" },
                { "Склады",     "Код_Склада"      },
                { "Поставка",   "Код_Поставки"   }
            };

        public DataService(DataRepository repo, UserSession session)
        {
            _repo    = repo;
            _session = session;
        }

        //Проверки прав 

        // Редактировать могут Директор и Кладовщик
        public bool CanEdit() =>
            _session.CurrentRole is Roles.Director or Roles.Storekeeper;

        // Удалять может только Директор
        public bool CanDelete() =>
            _session.CurrentRole == Roles.Director;

        // Отчёты доступны Директору и Бухгалтеру
        public bool CanReport() =>
            _session.CurrentRole is Roles.Director or Roles.Accountant;



        // Загружаем таблицу — доступно всем авторизованным пользователям
        public DataTable GetTable(string tableName) =>
            _repo.GetTable(tableName);

        //CRUD 

        public void AddRecord(string tableName, Dictionary<string, object?> values)
        {
            CheckCanEdit();
            _repo.InsertRecord(tableName, values);
        }

        public void SaveRecord(string tableName, object pkValue,
                               Dictionary<string, object?> values)
        {
            CheckCanEdit();
            _repo.UpdateRecord(tableName, GetPrimaryKey(tableName), pkValue, values);
        }

        public void DeleteRecord(string tableName, object pkValue)
        {
            if (!CanDelete())
                throw new UnauthorizedAccessException(
                    "Удалять записи может только Директор.");
            _repo.DeleteRecord(tableName, GetPrimaryKey(tableName), pkValue);
        }

        // Отчёты 

        public DataTable GetTotalValueBySupplier()
        {
            CheckCanReport();
            return _repo.GetSupplierTotals();
        }

        public DataTable GetDetailCountByWarehouse()
        {
            CheckCanReport();
            return _repo.GetWarehouseStockReport();
        }

        public DataTable GetDetailsByPrice()
        {
            CheckCanReport();
            return _repo.GetPartsByPrice();
        }

        public DataTable GetFullDeliveryInfo()
        {
            CheckCanReport();
            return _repo.GetDeliveryDetails();
        }

        public void ExportToCsv(DataTable dt, string filePath)
        {
            CheckCanReport();
            DataRepository.SaveToCsv(dt, filePath);
        }
        //Ошибки

        // Находим первичный ключ таблицы
        public static string GetPrimaryKey(string tableName) =>
            PrimaryKeys.TryGetValue(tableName, out var pk)
                ? pk
                : throw new ArgumentException($"Неизвестная таблица: {tableName}");

        private void CheckCanEdit()
        {
            if (!CanEdit())
                throw new UnauthorizedAccessException(
                    "Добавлять и редактировать записи может Директор или Кладовщик.");
        }

        private void CheckCanReport()
        {
            if (!CanReport())
                throw new UnauthorizedAccessException(
                    "Отчёты доступны Директору и Бухгалтеру.");
        }
    }
}
