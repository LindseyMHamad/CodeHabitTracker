using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    public class Remove
    {
        public static void Delete()
        {

            string connectionString = @"Data Source=coding-Tracker.db";

            Console.Clear();
            Records.GetRecords();

            var recordId = GetNumberInput.GetNumber("\n\nPlease type the Id of the record you want to delete or type 0 to go back to Main Menu\n\n");

            using (var connection = new SqliteConnection(connectionString))
            {
                connection.Open();
                var tableCmd = connection.CreateCommand();

                tableCmd.CommandText = $"DELETE from writing_code WHERE Id = '{recordId}'";

                int rowCount = tableCmd.ExecuteNonQuery();

                if (rowCount == 0)
                {
                    Console.WriteLine($"\n\nRecord with Id {recordId} doesn't exist. \n\n");
                    Delete();
                }

            }

            Console.WriteLine($"\n\nRecord with Id {recordId} was deleted. \n\n");

            UserInput.GetUserInput();
        }
    }
}