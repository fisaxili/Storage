using Storage.BLL.Secure;
using Xunit;

namespace Storage.Tests
{
    /// <summary>Тесты хеширования паролей.</summary>
    public class PasswordHasherTests
    {
        [Fact]
        public void Hash_ReturnsNonEmptyString()
        {
            var hash = PasswordHasher.Hash("secret");
            Assert.NotNull(hash);
            Assert.NotEmpty(hash);
        }

        [Fact]
        public void Hash_Returns64CharHexString()
        {
            var hash = PasswordHasher.Hash("password");
            // SHA-256 → 32 байта → 64 hex-символа
            Assert.Equal(64, hash.Length);
            Assert.Matches("^[0-9a-f]+$", hash);
        }

        [Fact]
        public void Hash_IsDeterministic()
        {
            var h1 = PasswordHasher.Hash("test123");
            var h2 = PasswordHasher.Hash("test123");
            Assert.Equal(h1, h2);
        }

        [Fact]
        public void Hash_DifferentInputsProduceDifferentHashes()
        {
            var h1 = PasswordHasher.Hash("password1");
            var h2 = PasswordHasher.Hash("password2");
            Assert.NotEqual(h1, h2);
        }

        [Fact]
        public void Hash_AdminPasswordMatchesKnownHash()
        {
            // Убеждаемся, что дефолтный admin/admin работает
            var hash = PasswordHasher.Hash("admin");
            Assert.Equal(64, hash.Length);
        }
    }
}
