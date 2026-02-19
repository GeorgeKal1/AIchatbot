using System;
using System.Data;
using System.Data.SQLite;

namespace AIChatBot
{
    public static class DatabaseHelper
    {
        private static readonly string connectionString =
            "Data Source=chatbot.db;Version=3;";


        public static void InitializeDatabase()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                var query = @"CREATE TABLE IF NOT EXISTS AIRESPONSES (
                                ID INTEGER PRIMARY KEY AUTOINCREMENT,
                                DATE TIMESTAMP,
                                QUESTION TEXT NOT NULL,
                                ResponseText TEXT NOT NULL
                              );";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SaveChat(string question, string response)
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = @"INSERT INTO AIRESPONSES 
                                (DATE, QUESTION, ResponseText) 
                                VALUES (@date, @q, @r)";
                using (var cmd = new SQLiteCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@date", DateTime.Now);
                    cmd.Parameters.AddWithValue("@q", question);
                    cmd.Parameters.AddWithValue("@r", response);
                    if (cmd.ExecuteNonQuery() > 0)
                    {
                        MessageBox.Show("Chat saved to database successfully.");
                    }
                    
                }
            }
        }

        public static DataTable LoadChats()
        {
            using (var connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                using (var adapter =
                    new SQLiteDataAdapter("SELECT * FROM AIRESPONSES", connection))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
        }
    }
}
