using System;
using System.Collections.Generic;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    class Program
    {
        static string connectionString = @"Data Source=coding-Tracker.db";
        static void Main(string[] args)
        {
            using (var connection = new SqliteConnection(connectionString))
            {

                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText =
                    @"CREATE TABLE IF NOT EXISTS writing_code (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Date Text, 
                        StartTime TEXT,
                        EndTime TEXT,
                        Duration TEXT
                        )";

                tableCmd.ExecuteNonQuery();

                connection.Close();

            }

            UserInput.GetUserInput();
           
        }

        
        
    }
}