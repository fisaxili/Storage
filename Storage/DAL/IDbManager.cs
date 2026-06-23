namespace Storage.DAL
{
    // Интерфейс нужен чтобы в тестах можно было подменить реальную БД
    // на заглушку без подключения к файлу Access
    public interface IDbManager
    {
        // Проверяет логин и хеш пароля, возвращает роль или null
        string? CheckLogin(string login, string passwordHash);

        // Добавляет нового пользователя, false если логин занят
        bool AddNewUser(string login, string passwordHash, string role);

        // Меняет пароль, false если старый хеш не совпал
        bool UpdatePassword(string login, string oldHash, string newHash);

        // Возвращает роль пользователя по логину (или null)
        string? FindUserRole(string login);
    }
}
