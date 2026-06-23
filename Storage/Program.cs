using System.Configuration;
using System.Data.OleDb;
using Microsoft.Extensions.DependencyInjection;
using Storage.BLL;
using Storage.BLL.Secure;
using Storage.DAL;
using Storage.UI;
using Storage.UI.About;
using Storage.UI.Database;
using Storage.UI.Login;
using Storage.UI.Profile;
using Storage.UI.Reports;
using Storage.UI.Users;

namespace Storage
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            // 1. Проверка драйвера OLE DB 
            if (!CheckOleDbDriver())
            {
                MessageBox.Show(
                    "Не найден драйвер Microsoft Access Database Engine.\n\n" +
                    "Установите: Microsoft Access Database Engine 2016 Redistributable (x64)\n" +
                    "https://www.microsoft.com/en-us/download/details.aspx?id=54920",
                    "Ошибка запуска", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //2. Строка подключения 
            string cs = ConfigurationManager
                .ConnectionStrings["StorageDB"]
                .ConnectionString
                .Replace("|DataDirectory|", AppDomain.CurrentDomain.BaseDirectory);

            // 3. Инициализация БД 
            EnsureUsersTable(cs);

            // 4. DI-контейнер 
            var services = new ServiceCollection();
            ConfigureServices(services, cs);
            var provider = services.BuildServiceProvider();

            // 5. Запуск 
            Application.Run(provider.GetRequiredService<LoginForm>());
        }


        private static void ConfigureServices(ServiceCollection services, string cs)
        {
            // DAL
            services.AddSingleton<IDbManager>(new DbManager(cs));
            services.AddSingleton(new DataRepository(cs));

            // BLL
            services.AddSingleton<UserSession>();
            services.AddSingleton<AuthService>();
            services.AddSingleton<DataService>();

            // UI — Singleton-формы (существуют в одном экземпляре)
            services.AddSingleton<LoginForm>(sp => new LoginForm(
                sp.GetRequiredService<AuthService>(),
                () => sp.GetRequiredService<MainMenu>()
            ));

            services.AddSingleton<MainMenu>(sp => new MainMenu(
                sp.GetRequiredService<DataService>(),
                sp.GetRequiredService<AuthService>(),
                sp.GetRequiredService<UserSession>(),
                () => new DatabaseForm(
                    sp.GetRequiredService<DataService>(),
                    sp.GetRequiredService<UserSession>(),
                    sp.GetRequiredService<MainMenu>()),
                () => new ReportsForm(
                    sp.GetRequiredService<DataService>(),
                    sp.GetRequiredService<MainMenu>()),
                () => new ProfileForm(
                    sp.GetRequiredService<AuthService>(),
                    sp.GetRequiredService<UserSession>()),
                () => new UsersForm(
                    cs,
                    sp.GetRequiredService<UserSession>()),
                () => new AboutForm(
                    sp.GetRequiredService<UserSession>())
            ));
        }


        //  Создание таблицы Пользователи + дефолтный директор/admin

        private static void EnsureUsersTable(string cs)
        {
            try
            {
                using var conn = new OleDbConnection(cs);
                conn.Open();

                // Проверяем наличие таблицы
                var schema = conn.GetOleDbSchemaTable(
                    OleDbSchemaGuid.Tables,
                    new object?[] { null, null, "Пользователи", "TABLE" });

                if (schema == null || schema.Rows.Count == 0)
                {
                    using var create = new OleDbCommand(@"
                        CREATE TABLE Пользователи (
                            Код_Пользователя AUTOINCREMENT PRIMARY KEY,
                            Логин            TEXT(50) NOT NULL,
                            Пароль           TEXT(64) NOT NULL,
                            Роль             TEXT(30) NOT NULL
                        )", conn);
                    create.ExecuteNonQuery();
                }

                // Если нет ни одного Директора — создаём admin/admin
                using var countCmd = new OleDbCommand(
                    "SELECT COUNT(*) FROM Пользователи WHERE Роль = ?", conn);
                countCmd.Parameters.AddWithValue("?", Roles.Director);
                int directors = Convert.ToInt32(countCmd.ExecuteScalar());

                if (directors == 0)
                {
                    string hash = PasswordHasher.Hash("admin");
                    using var ins = new OleDbCommand(
                        "INSERT INTO Пользователи (Логин, Пароль, Роль) VALUES (?, ?, ?)", conn);
                    ins.Parameters.AddWithValue("?", "admin");
                    ins.Parameters.AddWithValue("?", hash);
                    ins.Parameters.AddWithValue("?", Roles.Director);
                    ins.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Не удалось инициализировать базу данных:\n{ex.Message}\n\n" +
                    "Проверьте наличие файла .accdb рядом с приложением.",
                    "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Environment.Exit(1);
            }
        }

        // ─────────────────────────────────────────────────────────────
        private static bool CheckOleDbDriver()
        {
            try
            {
                using var conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;");
                conn.Open();
                return true;
            }
            catch (InvalidOperationException ex)
                when (ex.Message.Contains("provider", StringComparison.OrdinalIgnoreCase) ||
                      ex.Message.Contains("провайдер", StringComparison.OrdinalIgnoreCase))
            {
                return false;
            }
            catch { return true; }
        }
    }
}
