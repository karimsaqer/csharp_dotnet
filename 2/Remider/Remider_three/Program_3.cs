using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Remider_three
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Karim Saqer
            int count = 0;
            for (int i = 0; i <= 100; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write(i + " ");
                    count++;
                }
            }
            Console.WriteLine();
            Console.WriteLine("The number of multiples of 3 between 0 and 100 is: " + count);
        }
    }
}
