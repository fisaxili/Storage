namespace Storage.BLL
{
    // Хранит информацию о текущем вошедшем пользователе.
    // Используется во всём приложении чтобы знать кто работает и какая у него роль.
    public class UserSession
    {
        public string? CurrentUserName { get; private set; }
        public string? CurrentRole     { get; private set; }

        // Удобное свойство — вошёл ли кто-то вообще
        public bool IsLoggedIn => CurrentUserName != null;

        // Устанавливаем данные при успешном входе
        public void SetUser(string login, string role)
        {
            CurrentUserName = login;
            CurrentRole     = role;
        }

        // Сбрасываем при выходе из системы
        public void Clear()
        {
            CurrentUserName = null;
            CurrentRole     = null;
        }
    }
}
