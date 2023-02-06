using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    public class InsertRecord
    {
        public static void Insert()
        {
                string connectionString = @"Data Source=coding-Tracker.db";
                
                string date = GetDate.GetDateInput();

                string startTime = GetTime.GetTimeInput("Enter the start time first and then end time in format (HH:mm)");

                string endTime = GetTime.GetTimeInput("Enter the start time first and then end time in format (HH:mm)");

                DateTime startTimeTime = DateTime.ParseExact(startTime, "HH:mm", null);
                DateTime endTimeTime = DateTime.ParseExact(endTime, "HH:mm", null);
                TimeSpan durationTime = endTimeTime - startTimeTime;

                string duration = durationTime.ToString();

                

                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var tableCmd = connection.CreateCommand();
                    tableCmd.CommandText =
                    $"INSERT INTO writing_code(date, startTime, endTime, duration) VALUES('{date}', '{startTime}', '{endTime}', '{duration}')";

                    tableCmd.ExecuteNonQuery();

                    connection.Close();
                }
                
    
        }
    }
}
