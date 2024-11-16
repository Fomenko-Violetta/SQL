using System;
using System.Data.SqlClient;
{
    
}

namespace ZooLab_1.Services
{
    public static class DatabaseHelper
    {
        private const string ConnectionString = "YourConnectionStringHere";

        public static void TestConnection()
        {
            using (SqlConnection connection = new SqlConnection(ConnectionString))
            {
                try
                {
                    connection.Open();
                    Console.WriteLine("З'єднання з базою даних успішне!");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Не вдалося підключитися до бази даних: {ex.Message}");
                }
            }
        }
    }
}

