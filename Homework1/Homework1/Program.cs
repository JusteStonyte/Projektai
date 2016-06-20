using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            double choice;

            Console.WriteLine("What experience does he/she have?");
            Console.WriteLine("Enter choice: ");
            choice = Convert.ToDouble(Console.ReadLine());

            if (choice == 0)
            {
                Console.WriteLine("Entry");

            }
            else if (choice > 0 && choice < 2)
            {
                Console.WriteLine("Junior");

            }
            else if (choice >= 2 && choice < 4)
            {
                Console.WriteLine("Mid-level");

            }
            else if (choice >= 4 && choice < 6.5)
            {
                Console.WriteLine("Professional");

            }
            else if (choice >= 6.5)
            {
                Console.WriteLine("Senior");

            }

            Console.ReadLine();
        }
    }

}
    

