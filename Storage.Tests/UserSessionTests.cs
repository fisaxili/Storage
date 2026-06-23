using Storage.BLL;
using Xunit;

namespace Storage.Tests
{
    /// <summary>Тесты состояния сессии пользователя.</summary>
    public class UserSessionTests
    {
        [Fact]
        public void Session_InitiallyNotLoggedIn()
        {
            var session = new UserSession();
            Assert.False(session.IsLoggedIn);
            Assert.Null(session.CurrentUserName);
            Assert.Null(session.CurrentRole);
        }

        [Fact]
        public void SetUser_SetsCredentials()
        {
            var session = new UserSession();
            session.SetUser("admin", Roles.Director);

            Assert.True(session.IsLoggedIn);
            Assert.Equal("admin",        session.CurrentUserName);
            Assert.Equal(Roles.Director, session.CurrentRole);
        }

        [Fact]
        public void Clear_ResetsSession()
        {
            var session = new UserSession();
            session.SetUser("user1", Roles.Storekeeper);
            session.Clear();

            Assert.False(session.IsLoggedIn);
            Assert.Null(session.CurrentUserName);
            Assert.Null(session.CurrentRole);
        }

        [Fact]
        public void SetUser_CanBeCalledMultipleTimes()
        {
            var session = new UserSession();
            session.SetUser("user1", Roles.Guest);
            session.SetUser("admin", Roles.Director);

            Assert.Equal("admin",        session.CurrentUserName);
            Assert.Equal(Roles.Director, session.CurrentRole);
        }
    }
}
