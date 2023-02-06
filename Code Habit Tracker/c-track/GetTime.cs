using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    public class GetTime
    {
       internal static string GetTimeInput(string message1)
        {
            //Console.WriteLine("\n\nPlease insert the time: (Format: HH:mm). Type 0 to return to main manu.\n\n");
            Console.WriteLine(message1);
            string timeInput = Console.ReadLine();

            if (timeInput == "0") UserInput.GetUserInput();

            while (!DateTime.TryParseExact(timeInput, "HH:mm", new CultureInfo("en-US"), DateTimeStyles.None, out _))
                {
                    Console.WriteLine("\n\nInvalid time. (Format: HH:mm). Type 0 to return to main manu or try again:\n\n");
                    timeInput = Console.ReadLine();
                 }

            return timeInput;

            
        }
 
    }
}