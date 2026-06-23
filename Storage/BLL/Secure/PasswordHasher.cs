using System.Security.Cryptography;
using System.Text;

namespace Storage.BLL.Secure
{
    /// <summary>
    /// Хеширование паролей алгоритмом SHA-256.
    /// </summary>
    public static class PasswordHasher
    {
        /// <summary>Вернуть hex-строку SHA-256 от входного текста.</summary>
        public static string Hash(string plainText)
        {
            using var sha256 = SHA256.Create();
            byte[] bytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(plainText));
            var sb = new StringBuilder(64);
            foreach (byte b in bytes)
                sb.Append(b.ToString("x2"));
            return sb.ToString();
        }
    }
}
