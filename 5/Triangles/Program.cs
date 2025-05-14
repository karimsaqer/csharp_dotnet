using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangles
{
    internal class Program
    {
        static void Swap(ref int x, ref int y)
        {
            int temp = x;
            x = y;
            y = temp;
        }

        static void Draw_Upper_Triangle()
        {
            int n = 11;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            // with while loop as session
            //for (int i = 0; i < n; i++)
            //{
            //    int counter = 0;
            //    while (counter <= i)
            //    {
            //        Console.Write("*");
            //        counter++;
            //    }
            //    Console.WriteLine();
            //}
        }
        static void Draw_Lower_Triangle()
        {
            int n = 11;
            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void Draw_Euclidean_Triangle()
        {
            int n = 11;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n - i; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
        static void Main(string[] args)
        {
            Draw_Lower_Triangle();
            Draw_Upper_Triangle();
            int x = 10, y = 20;
            Swap(ref x, ref y);
            Console.WriteLine($"After Swap: x = {x}, y = {y}");
            Draw_Euclidean_Triangle();

        }
    }
}
