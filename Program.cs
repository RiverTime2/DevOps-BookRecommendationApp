using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace BookRecommendationApp
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Инициализация базы данных
            InitializeDatabase();

            ApplicationConfiguration.Initialize();
            Application.Run(new Main());
        }

        private static void InitializeDatabase()
        {
            string connectionString = "Data Source=books.db;Version=3;";

            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                string createTableQuery = @"
                    CREATE TABLE IF NOT EXISTS Books (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Title TEXT NOT NULL,
                        Author TEXT NOT NULL,
                        Genre TEXT NOT NULL,
                        Rating REAL NOT NULL
                    )";

                var command = new SQLiteCommand(createTableQuery, connection);
                command.ExecuteNonQuery();
            }
        }
    }
}
