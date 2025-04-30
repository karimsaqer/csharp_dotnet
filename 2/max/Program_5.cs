using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace max
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Karim Saqer
            Console.WriteLine("Write series of numbers separated by comma:");
            string input = Console.ReadLine();
            string[] numbers = input.Split(',');
            int[] intNumbers = new int[numbers.Length];
            for (int i = 0; i < numbers.Length; i++)
            {
                intNumbers[i] = int.Parse(numbers[i]);
            }
            int max = intNumbers[0];
            for (int i = 1; i < intNumbers.Length; i++)
            {
                if (intNumbers[i] > max)
                {
                    max = intNumbers[i];
                }
            }
            Console.WriteLine("The maximum number is: " + max);
        }
    }
}
