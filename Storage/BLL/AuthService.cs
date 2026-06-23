using Storage.BLL.Secure;
using Storage.DAL;

namespace Storage.BLL
{
    // Сервис авторизации: вход, регистрация, смена пароля.
    // Дополнительно защищает от перебора паролей —
    // после 3 неверных попыток вход блокируется на 30 минут.
    public class AuthService
    {
        private readonly IDbManager  _db;
        private readonly UserSession _session;

        // Счётчик неудачных попыток и время окончания блокировки
        private int       _failedAttempts;
        private DateTime? _lockedUntil;

        private const int MaxAttempts       = 3;
        private const int LockoutMinutes    = 30;
        private const int MinPasswordLength = 6;

        public AuthService(IDbManager db, UserSession session)
        {
            _db      = db;
            _session = session;
        }

        // Сколько времени осталось до снятия блокировки (null = не заблокирован)
        public TimeSpan? LockoutRemaining =>
            _lockedUntil.HasValue && DateTime.Now < _lockedUntil.Value
                ? _lockedUntil.Value - DateTime.Now
                : null;

        // ── Вход ──────────────────────────────────────────────────────

        // Пытаемся войти. Возвращает true при успехе.
        // Если слишком много ошибок — выбрасывает исключение с пояснением
        public bool Login(string login, string plainPassword)
        {
            // Сначала проверяем не заблокирован ли аккаунт
            if (IsLocked())
            {
                var left = LockoutRemaining!.Value;
                throw new InvalidOperationException(
                    $"Слишком много неверных попыток. " +
                    $"Попробуйте через {(int)left.TotalMinutes} мин {left.Seconds} сек.");
            }

            // Хешируем пароль и ищем пользователя в БД
            string hash = PasswordHasher.Hash(plainPassword);
            string? role = _db.CheckLogin(login, hash);

            if (role != null)
            {
                // Успех — сбрасываем счётчик и сохраняем пользователя в сессии
                _failedAttempts = 0;
                _lockedUntil    = null;
                _session.SetUser(login, role);
                return true;
            }

            // Неудача — увеличиваем счётчик, при необходимости блокируем
            _failedAttempts++;
            if (_failedAttempts >= MaxAttempts)
                _lockedUntil = DateTime.Now.AddMinutes(LockoutMinutes);

            return false;
        }

        // ── Регистрация ───────────────────────────────────────────────

        // Регистрируем нового пользователя.
        // Новые аккаунты всегда получают роль "Гость" — директор может повысить потом
        public bool Register(string login, string plainPassword)
        {
            ValidateCredentials(login, plainPassword);
            string hash = PasswordHasher.Hash(plainPassword);
            return _db.AddNewUser(login, hash, Roles.Guest);
        }

        // ── Смена пароля ──────────────────────────────────────────────

        public bool ChangePassword(string oldPlain, string newPlain)
        {
            if (!_session.IsLoggedIn)
                throw new InvalidOperationException("Необходимо войти в систему.");

            if (newPlain.Length < MinPasswordLength)
                throw new ArgumentException($"Пароль должен быть не менее {MinPasswordLength} символов.");

            string oldHash = PasswordHasher.Hash(oldPlain);
            string newHash = PasswordHasher.Hash(newPlain);
            return _db.UpdatePassword(_session.CurrentUserName!, oldHash, newHash);
        }

        // ── Выход ─────────────────────────────────────────────────────

        public void LogOut() => _session.Clear();

        // ── Вспомогательные ───────────────────────────────────────────

        private bool IsLocked() =>
            _lockedUntil.HasValue && DateTime.Now < _lockedUntil.Value;

        private static void ValidateCredentials(string login, string password)
        {
            if (string.IsNullOrWhiteSpace(login))
                throw new ArgumentException("Логин не может быть пустым.");
            if (password.Length < MinPasswordLength)
                throw new ArgumentException($"Пароль должен быть не менее {MinPasswordLength} символов.");
        }
    }
}
