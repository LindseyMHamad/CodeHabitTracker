using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace code_tracker
{
    public class GetNumberInput
    {
        internal static int GetNumber(string message)
        {
            Console.WriteLine(message);

            string numberInput = Console.ReadLine();

            if (numberInput == "0") UserInput.GetUserInput();

            while (!Int32.TryParse(numberInput, out _) || Convert.ToInt32(numberInput) < 0)
            {
                Console.WriteLine("\n\nInvalid number. Try again.\n\n");
                numberInput = Console.ReadLine();
            }

            int finalInput = Convert.ToInt32(numberInput);

            return finalInput;
        }
    }
}