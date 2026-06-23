using Storage.DAL;

namespace Storage.Tests
{
    // Заглушка вместо реальной БД — используется только в тестах.
    // Хранит пользователей в обычном словаре в памяти.
    internal class FakeDbManager : IDbManager
    {
        private readonly Dictionary<string, (string Hash, string Role)> _users = new();

        // Добавляем тестового пользователя напрямую (без хеширования)
        public void AddUser(string login, string hash, string role)
            => _users[login] = (hash, role);

        public string? CheckLogin(string login, string hash)
        {
            if (_users.TryGetValue(login, out var u) && u.Hash == hash)
                return u.Role;
            return null;
        }

        public bool AddNewUser(string login, string hash, string role)
        {
            if (_users.ContainsKey(login)) return false;
            _users[login] = (hash, role);
            return true;
        }

        public bool UpdatePassword(string login, string oldHash, string newHash)
        {
            if (!_users.TryGetValue(login, out var u)) return false;
            if (u.Hash != oldHash) return false;
            _users[login] = (newHash, u.Role);
            return true;
        }

        public string? FindUserRole(string login) =>
            _users.TryGetValue(login, out var u) ? u.Role : null;

        // Вспомогательный метод для проверки в тестах
        public string? GetUserRole(string login) => FindUserRole(login);
    }
}
