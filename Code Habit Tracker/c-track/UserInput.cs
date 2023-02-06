using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_tracker

{
    public class UserInput
    {
        public static void GetUserInput()
        {
            Console.Clear();
            bool closeApp = false;
            while (closeApp == false)
            {
                Console.WriteLine("\n\nMAIN MENU");
                Console.WriteLine("\nWhat would you like to do?");
                Console.WriteLine("\nType 0 to Close Application.");
                Console.WriteLine("Type 1 to View All Records.");
                Console.WriteLine("Type 2 to Insert Record.");
                Console.WriteLine("Type 3 to Delete Record.");
                Console.WriteLine("------------------------------------------\n");

                string command = Console.ReadLine();

                switch (command)
                {
                    case "0": 
                        Console.WriteLine("\nGoodbye!\n");
                        closeApp = true;
                        Environment.Exit(0);
                        break;
                    case "1":
                        Records.GetRecords();
                        break;
                    case "2":
                       InsertRecord.Insert();
                        break;
                    case "3":
                       Remove.Delete();
                        break;
                    
                    default:
                        Console.WriteLine("\nInvalid Command. Please type a number from 0 to 4.\n");
                        break;
                }
            }

        }
    }
}