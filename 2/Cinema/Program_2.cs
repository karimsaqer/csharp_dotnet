using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Karim Saqer

            bool[,] arr = new bool[4, 4] { { false, false, false, false},
                                             { false, false, false, false},
                                             { false, false, false, false},
                                             { false, false, false, false} };
            int counter = 0;
            int max = arr.Length;
            while (counter < max)
            {
                Console.WriteLine("Enter the row of the array between 0 and 3:");
                int row = Convert.ToInt32(Console.ReadLine());
                if (row < 0 || row > 3)
                {
                    Console.WriteLine("Invalid row index. Please enter 0 or 3.");
                    continue;
                }
                Console.WriteLine("Enter the column of the array between 0 and 3:");
                int column = Convert.ToInt32(Console.ReadLine());
                if (column < 0 || column > 3)
                {
                    Console.WriteLine("Invalid column index. Please enter 0 or 3.");
                    continue;                }
                if (arr[row, column] == false)
                {
                    arr[row, column] = true;
                    Console.WriteLine("The value at the specified index has been set to true.");
                    counter++;
                }
                else
                {
                    Console.WriteLine("The value at the specified index is already true.");
                }
                if (counter == max)
                {
                    Console.WriteLine("All values have been set to true. Thank You!");
                }

            }


        }
    }
}
