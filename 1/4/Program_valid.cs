using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number:");
            string c = Console.ReadLine();
            int number;

            // Check if the input is a valid integer
            if (int.TryParse(c, out number))
                number = Convert.ToInt32(c);
            else
            {
                Console.WriteLine("Invalid input.");
                return; // Exit the program if the input is invalid
            }

            // Check if the number is valid
            if (number <= 0 || number > 10)
            {
                Console.WriteLine("Invalid number.");
                return; // Exit the program if the number is invalid
            }
            else
                Console.WriteLine("Valid number.");
        }
    }
}
