using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace factorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Karim Saqer
            Console.WriteLine("Write a number to calculate its factorial: ");
            int input_number = Convert.ToInt32(Console.ReadLine());
            ulong factorial = 1;
            for (int i = 1; i <= input_number; i++)
            {
                factorial *= (ulong)i;
            }
            Console.WriteLine(input_number + "! = " + factorial);
        }
    }
}
