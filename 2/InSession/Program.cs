using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InSession
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> ints = new List<int>();
            Console.WriteLine("Enter 5 unique numbers:");
            for (int i = 0; i < 5; i++)
            {
                int x = Convert.ToInt32(Console.ReadLine());
                if (ints.Contains(x))
                {
                    Console.WriteLine("The Function already contains this number. Please Write the number again.");
                    i--;
                }
                else
                {
                    ints.Add(x);
                }
            }
            ints.Sort();
            Console.WriteLine("The List of sorted numbers is: ");
            foreach (int i in ints)
            {
                Console.Write(i + " ");
            }
        }
    }
}
