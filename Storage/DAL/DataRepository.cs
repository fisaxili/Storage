using System.Data;
using System.Data.OleDb;
using System.Text;

namespace Storage.DAL
{
    // Класс для работы с таблицами склада: чтение, добавление, изменение, удаление.
    // Все запросы параметризованы — это защищает от SQL-инъекций.
    public class DataRepository
    {
        private readonly string _connStr;

        // Список допустимых таблиц — чтобы нельзя было передать произвольное имя
        private static readonly List<string> AllowedTables = new()
        {
            "Детали", "Поставщики", "Склады", "Поставка"
        };

        public DataRepository(string connStr)
        {
            _connStr = connStr;
        }

        // Загружаем все строки таблицы в DataTable
        public DataTable GetTable(string tableName)
        {
            CheckTableName(tableName);
            string sql = $"SELECT * FROM [{tableName}]";

            using var conn    = new OleDbConnection(_connStr);
            using var adapter = new OleDbDataAdapter(sql, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Выполняем произвольный SELECT (используется для отчётов)
        public DataTable RunQuery(string sql)
        {
            using var conn    = new OleDbConnection(_connStr);
            using var adapter = new OleDbDataAdapter(sql, conn);
            var dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // Добавить новую запись. values — словарь "имя поля" -> значение
        public void InsertRecord(string tableName, Dictionary<string, object?> values)
        {
            CheckTableName(tableName);

            // Формируем строки вида: [Поле1], [Поле2] и ?, ?
            string cols        = string.Join(", ", values.Keys.Select(k => $"[{k}]"));
            string placeholders = string.Join(", ", values.Keys.Select(_ => "?"));
            string sql         = $"INSERT INTO [{tableName}] ({cols}) VALUES ({placeholders})";

            RunNonQuery(sql, values.Values.ToArray());
        }

        // Обновить существующую запись по первичному ключу
        public void UpdateRecord(string tableName, string pkCol, object pkVal,
                                 Dictionary<string, object?> values)
        {
            CheckTableName(tableName);

            string setClause = string.Join(", ", values.Keys.Select(k => $"[{k}] = ?"));
            string sql       = $"UPDATE [{tableName}] SET {setClause} WHERE [{pkCol}] = ?";

            // Параметры: сначала значения полей, потом значение ключа
            var parameters = values.Values.Concat(new[] { pkVal }).ToArray();
            RunNonQuery(sql, parameters);
        }

        // Удалить запись по первичному ключу
        public void DeleteRecord(string tableName, string pkCol, object pkVal)
        {
            CheckTableName(tableName);
            string sql = $"DELETE FROM [{tableName}] WHERE [{pkCol}] = ?";
            RunNonQuery(sql, new[] { pkVal });
        }

        //Готовые запросы для отчётов 

        // Отчёт 1: сколько на сумму поставил каждый поставщик
        // Отчёт 1: сколько на сумму поставил каждый поставщик
        public DataTable GetSupplierTotals()
        {
            string sql = @"
        SELECT п.Название_Поставщика,
               SUM(д.Цена_Детали * пост.Количество_Деталей) AS Общая_Стоимость
        FROM (Поставщики AS п 
        INNER JOIN Поставка AS пост ON п.Код_Поставщика = пост.Код_Поставщика)
        INNER JOIN Детали AS д ON пост.Код_Детали = д.Код_Детали
        GROUP BY п.Название_Поставщика
        ORDER BY SUM(д.Цена_Детали * пост.Количество_Деталей) DESC";
            return RunQuery(sql);
        }

        // Отчёт 2: сколько всего деталей хранится на каждом складе
        public DataTable GetWarehouseStockReport()
        {
            string sql = @"
                SELECT с.Номер_Склада, с.ФИО_Кладовщика,
                       SUM(п.Количество_Деталей) AS Всего_Деталей
                FROM Склады AS с
                    INNER JOIN Поставка AS п ON с.Код_Склада = п.Код_Склада
                GROUP BY с.Номер_Склада, с.ФИО_Кладовщика
                ORDER BY Всего_Деталей DESC";
            return RunQuery(sql);
        }
        // Отчёт 3: список деталей, отсортированных по цене (дорогие сверху)
        public DataTable GetPartsByPrice()
        {
            string sql = @"
                SELECT Наименование_Детали, Цена_Детали
                FROM Детали
                ORDER BY Цена_Детали DESC";
            return RunQuery(sql);
        }

        // Отчёт 4: полная информация о каждой поставке (JOIN 4 таблиц)
        public DataTable GetDeliveryDetails()
        {
            string sql = @"
                SELECT пост.Код_Поставки,
                       с.Номер_Склада,
                       п.Название_Поставщика,
                       д.Наименование_Детали,
                       д.Цена_Детали,
                       пост.Количество_Деталей,
                       д.Цена_Детали * пост.Количество_Деталей AS Сумма
                FROM ((Поставка AS пост
                    INNER JOIN Склады AS с ON пост.Код_Склада = с.Код_Склада)
                    INNER JOIN Поставщики AS п ON пост.Код_Поставщика = п.Код_Поставщика)
                    INNER JOIN Детали AS д ON пост.Код_Детали = д.Код_Детали
                ORDER BY пост.Код_Поставки";
            return RunQuery(sql);
        }

        // Выполняем INSERT / UPDATE / DELETE с параметрами
        private void RunNonQuery(string sql, object?[] parameters)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(sql, conn);
            foreach (var p in parameters)
                cmd.Parameters.AddWithValue("?", p ?? DBNull.Value);
            cmd.ExecuteNonQuery();
        }

        // Проверяем что имя таблицы входит в список допустимых
        private static void CheckTableName(string name)
        {
            if (!AllowedTables.Contains(name))
                throw new ArgumentException($"Таблица '{name}' не найдена.");
        }

        // Сохраняем DataTable в CSV-файл (разделитель — точка с запятой, кодировка UTF-8)
        public static void SaveToCsv(DataTable dt, string filePath)
        {
            var sb = new StringBuilder();

            // Первая строка — заголовки столбцов
            var headers = dt.Columns.Cast<DataColumn>().Select(c => WrapCsvValue(c.Caption));
            sb.AppendLine(string.Join(";", headers));

            // Остальные строки — данные
            foreach (DataRow row in dt.Rows)
            {
                var cells = row.ItemArray.Select(f => WrapCsvValue(f?.ToString() ?? ""));
                sb.AppendLine(string.Join(";", cells));
            }

            File.WriteAllText(filePath, sb.ToString(), Encoding.UTF8);
        }

        // Если значение содержит ; или " — оборачиваем в кавычки
        private static string WrapCsvValue(string value)
        {
            if (value.Contains(';') || value.Contains('"') || value.Contains('\n'))
                return $"\"{value.Replace("\"", "\"\"")}\"";
            return value;
        }
    }
}
