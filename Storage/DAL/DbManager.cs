using System.Data.OleDb;

namespace Storage.DAL
{
    // Класс отвечает за работу с таблицей Пользователи:
    // вход в систему, регистрация, смена пароля
    public class DbManager : IDbManager
    {
        private readonly string _connStr;

        public DbManager(string connStr)
        {
            _connStr = connStr;
        }

        // Ищем пользователя по логину и хешу пароля.
        // Если нашли — возвращаем его роль, иначе null
        public string? CheckLogin(string login, string passwordHash)
        {
            string sql = "SELECT Роль FROM Пользователи WHERE Логин = ? AND Пароль = ?";

            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(sql, conn);
            // Используем ? вместо именованных параметров — так требует OLE DB провайдер
            cmd.Parameters.AddWithValue("?", login);
            cmd.Parameters.AddWithValue("?", passwordHash);

            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }

        // Регистрируем нового пользователя.
        // Сначала проверяем — вдруг такой логин уже есть
        public bool AddNewUser(string login, string passwordHash, string role)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();

            // Проверка на дубликат
            using var checkCmd = new OleDbCommand(
                "SELECT COUNT(*) FROM Пользователи WHERE Логин = ?", conn);
            checkCmd.Parameters.AddWithValue("?", login);
            int count = Convert.ToInt32(checkCmd.ExecuteScalar());

            if (count > 0)
                return false; // логин занят

            using var insertCmd = new OleDbCommand(
                "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (?, ?, ?)", conn);
            insertCmd.Parameters.AddWithValue("?", login);
            insertCmd.Parameters.AddWithValue("?", passwordHash);
            insertCmd.Parameters.AddWithValue("?", role);
            insertCmd.ExecuteNonQuery();
            return true;
        }

        // Меняем пароль — только если старый хеш совпал
        public bool UpdatePassword(string login, string oldHash, string newHash)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(
                "UPDATE Пользователи SET Пароль = ? WHERE Логин = ? AND Пароль = ?", conn);
            cmd.Parameters.AddWithValue("?", newHash);
            cmd.Parameters.AddWithValue("?", login);
            cmd.Parameters.AddWithValue("?", oldHash);

            int rows = cmd.ExecuteNonQuery();
            return rows > 0; // 0 строк — старый пароль неверный
        }

        // Получаем роль пользователя по логину
        public string? FindUserRole(string login)
        {
            using var conn = new OleDbConnection(_connStr);
            conn.Open();
            using var cmd = new OleDbCommand(
                "SELECT Роль FROM Пользователи WHERE Логин = ?", conn);
            cmd.Parameters.AddWithValue("?", login);

            var result = cmd.ExecuteScalar();
            return result?.ToString();
        }
    }
}
