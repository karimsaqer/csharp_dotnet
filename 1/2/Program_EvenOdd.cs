using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment2_EvenOdd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Read the number 
            Console.WriteLine("Enter a number: ");
            string c = Console.ReadLine();
            // Check if the input is a number 
            if (int.TryParse(c, out int number))
            {
                // Check if the number is even or odd
                if (number % 2 == 0)
                {
                    Console.WriteLine("The number is even.");
                }
                else
                {
                    Console.WriteLine("The number is odd.");
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
                return;
            }

        }
    }
}
