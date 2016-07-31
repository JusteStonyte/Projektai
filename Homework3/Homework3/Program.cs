using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            for (;;)
            {
                Console.WriteLine("Please enter the year:");
                string yearInput = Console.ReadLine();
                int year;

                if (!int.TryParse(yearInput, out year))
                {
                    Console.WriteLine("Invalid input. Please enter number.");
                }

                Console.WriteLine("Please enter month number (1-12):");
                string monthInput = Console.ReadLine();
                int month;
                if (!int.TryParse(monthInput, out month))
                {
                    Console.WriteLine("Invalid input. Please enter number.");
                }
                if (month >= 13)
                {
                    Console.WriteLine("There is only 12 months in a year. Please provide correct input.");
                }

                int daysInMonth = System.DateTime.DaysInMonth(year, month);
                Console.WriteLine("{0}-{1} has {2} days", year, month, daysInMonth);

                Console.WriteLine("Do you want to continue?");
                string input = Console.ReadLine();

                if (input == "y")
                {
                    continue;
                }

                break;
            }
        }
    }
}
