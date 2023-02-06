using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Globalization;
using Microsoft.Data.Sqlite;

namespace code_tracker
{
    public class GetDate
    {
        internal static string GetDateInput()
        {
            Console.WriteLine("\n\nPlease insert the date: (Format: dd-mm-yy). Type 0 to return to main manu.\n\n");

            string dateInput = Console.ReadLine();

            if (dateInput == "0") UserInput.GetUserInput();

            while (!DateTime.TryParseExact(dateInput, "dd-MM-yy", new CultureInfo("en-US"), DateTimeStyles.None, out _))
            {
                Console.WriteLine("\n\nInvalid date. (Format: dd-mm-yy). Type 0 to return to main manu or try again:\n\n");
                dateInput = Console.ReadLine();
            }

            return dateInput;
        }

    }
}