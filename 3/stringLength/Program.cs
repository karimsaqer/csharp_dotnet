using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Reading length of input
            Console.WriteLine("Write length of the string");
            int len = Convert.ToInt32(Console.ReadLine());

            // Reading the String
            Console.WriteLine("Write the string");
            string str = Console.ReadLine();

            // if the string exceeds the length
            if (str.Length > len)
            {
                // check the last word before the length exceeds
                int lastSpace = str.LastIndexOf(' ', len);
                if (lastSpace == -1)
                {
                    str = str.Substring(0, len);
                    // str = str.Substring(0, 0);

                }
                else
                {
                    str = str.Substring(0, lastSpace);
                }
                str += "...";
            }
            Console.WriteLine("The string is: " + str);
        }
    }
}
