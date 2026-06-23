using Storage.BLL;
using Storage.BLL.Secure;
using Xunit;

namespace Storage.Tests
{
    /// <summary>Тесты бизнес-логики авторизации.</summary>
    public class AuthServiceTests
    {
        private static AuthService BuildService(out FakeDbManager fake, out UserSession session)
        {
            fake    = new FakeDbManager();
            session = new UserSession();
            return new AuthService(fake, session);
        }

        // ─── Login ────────────────────────────────────────────────────

        [Fact]
        public void Login_ValidCredentials_ReturnsTrue()
        {
            var svc = BuildService(out var fake, out var session);
            fake.AddUser("admin", PasswordHasher.Hash("admin"), Roles.Director);

            bool result = svc.Login("admin", "admin");

            Assert.True(result);
            Assert.True(session.IsLoggedIn);
            Assert.Equal("admin",        session.CurrentUserName);
            Assert.Equal(Roles.Director, session.CurrentRole);
        }

        [Fact]
        public void Login_WrongPassword_ReturnsFalse()
        {
            var svc = BuildService(out var fake, out _);
            fake.AddUser("admin", PasswordHasher.Hash("admin"), Roles.Director);

            bool result = svc.Login("admin", "wrong");

            Assert.False(result);
        }

        [Fact]
        public void Login_UnknownUser_ReturnsFalse()
        {
            var svc = BuildService(out _, out _);
            Assert.False(svc.Login("nobody", "pass"));
        }

        [Fact]
        public void Login_ThreeFailures_ThrowsLockoutException()
        {
            var svc = BuildService(out _, out _);

            svc.Login("x", "1");
            svc.Login("x", "2");
            svc.Login("x", "3");

            Assert.Throws<InvalidOperationException>(() => svc.Login("x", "4"));
        }

        [Fact]
        public void Login_LockoutReturnsRemainingTime()
        {
            var svc = BuildService(out _, out _);

            svc.Login("x", "1");
            svc.Login("x", "2");
            svc.Login("x", "3");

            Assert.NotNull(svc.LockoutRemaining);
            Assert.True(svc.LockoutRemaining!.Value.TotalMinutes > 29);
        }

        // ─── Register ─────────────────────────────────────────────────

        [Fact]
        public void Register_NewUser_GetsGuestRole()
        {
            var svc = BuildService(out var fake, out _);
            bool ok = svc.Register("newuser", "pass123");

            Assert.True(ok);
            Assert.Equal(Roles.Guest, fake.GetUserRole("newuser"));
        }

        [Fact]
        public void Register_DuplicateLogin_ReturnsFalse()
        {
            var svc = BuildService(out _, out _);
            svc.Register("user1", "pass123");

            bool second = svc.Register("user1", "other456");
            Assert.False(second);
        }

        [Fact]
        public void Register_ShortPassword_ThrowsArgumentException()
        {
            var svc = BuildService(out _, out _);
            Assert.Throws<ArgumentException>(() => svc.Register("user", "123"));
        }

        // ─── ChangePassword ───────────────────────────────────────────

        [Fact]
        public void ChangePassword_Correct_ReturnsTrue()
        {
            var svc = BuildService(out var fake, out _);
            fake.AddUser("user1", PasswordHasher.Hash("oldpass"), Roles.Storekeeper);
            svc.Login("user1", "oldpass");

            bool ok = svc.ChangePassword("oldpass", "newpass123");
            Assert.True(ok);
        }

        [Fact]
        public void ChangePassword_WrongOldPassword_ReturnsFalse()
        {
            var svc = BuildService(out var fake, out _);
            fake.AddUser("user1", PasswordHasher.Hash("realpass"), Roles.Storekeeper);
            svc.Login("user1", "realpass");

            bool ok = svc.ChangePassword("wrongold", "newpass123");
            Assert.False(ok);
        }

        // ─── LogOut ───────────────────────────────────────────────────

        [Fact]
        public void LogOut_ClearsSession()
        {
            var svc = BuildService(out var fake, out var session);
            fake.AddUser("admin", PasswordHasher.Hash("admin"), Roles.Director);
            svc.Login("admin", "admin");

            svc.LogOut();

            Assert.False(session.IsLoggedIn);
        }
    }
}
