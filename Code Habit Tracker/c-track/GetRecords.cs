using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    public class Records
    {
        public static void GetRecords()
        {
             string connectionString = @"Data Source=coding-Tracker.db";
            
                Console.Clear();
            
                using (var connection = new SqliteConnection(connectionString))
                {
                    connection.Open();
                    var tableCmd = connection.CreateCommand();
                    tableCmd.CommandText =
                        $"SELECT * FROM writing_code";

                    List<CodeTime> tableData = new();

                    SqliteDataReader reader = tableCmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        while (reader.Read())
                        {
                            tableData.Add(
                            new CodeTime
                            {
                                Id = reader.GetInt32(0),
                                Date = DateTime.ParseExact(reader.GetString(1), "dd-MM-yy", new CultureInfo("en-US")),
                                StartTime = DateTime.ParseExact(reader.GetString(2), "HH:mm", new CultureInfo("en-US")),
                                EndTime = DateTime.ParseExact(reader.GetString(3), "HH:mm", new CultureInfo("en-US")),
                                Duration = TimeSpan.Parse(reader.GetString(4)),
                            }); ;
                        }
                    }
                    else
                    {
                        Console.WriteLine("No rows found");
                    }

                    connection.Close();

                    Console.WriteLine("------------------------------------------\n");
                    foreach (var dw in tableData)
                    {
                        Console.WriteLine($"{dw.Id} - {dw.Date.ToString("dd-MM-yyyy")} - StartTime: {dw.StartTime.ToString("HH:mm")} - EndTime: {dw.EndTime.ToString("HH:mm")} - Duration: {dw.Duration.ToString()} ");
                    }
                    Console.WriteLine("------------------------------------------\n");
                }
        
                }
                }
    }
    
