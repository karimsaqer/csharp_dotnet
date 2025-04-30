using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assesment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Name: Karim Saqer
            // What are the possible combinations from 3 boolean x, y, z? -> 2^3 = 8
            // Let's build a truth table for the boolean variables x, y, z
            bool x = false;
            bool y = false;
            bool z = false;
            // 1. Ands
            if (x == true && y == true && z == true)
            {
                Console.WriteLine("x and y and z are true");
            }
            else
            {
                Console.WriteLine("x and y and z are false");
            }
            Console.WriteLine("All are false except x, y, z are true");

            // 2. Or
            if (x == true || y == true || z == true)
            {
                Console.WriteLine("x or y or z are true");
            }
            else
            {
                Console.WriteLine("x or y or z are false");
            }
            Console.WriteLine("All are true except x, y, z are false");


        }
    }
}
