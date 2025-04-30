using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_Assesment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number:");
            string c = Console.ReadLine();
            int first;

            // Check if the input is a valid integer
            if (int.TryParse(c, out first))
                first = Convert.ToInt32(c);
            else
            {
                Console.WriteLine("Invalid input.");
                return; // Exit the program if the input is invalid
            }


            Console.WriteLine("Enter the second number:");
            c = Console.ReadLine();
            int second;

            // Check if the input is a valid integer
            if (int.TryParse(c, out second))
                second = Convert.ToInt32(c);
            else
            {
                Console.WriteLine("Invalid input.");
                return; // Exit the program if the input is invalid
            }

            if (first >= second)
                Console.WriteLine("The max number is " + first);
            
            else if (first < second)
                Console.WriteLine("The max number is " + second);
            
        }
    }
}
