using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Assessment 1
            Console.WriteLine("Enter the first number:");
            string c = Console.ReadLine();
            int first;

            // Check if the input is a valid integer
            if (int.TryParse(c, out first))
                first = Convert.ToInt32(c);
            else {
                Console.WriteLine("Invalid input.");
                return; // Exit the program if the input is invalid
            }


            Console.WriteLine("Enter the second number:");
            c = Console.ReadLine();
            int second;

            // Check if the input is a valid integer
            if (int.TryParse(c, out second))
                second = Convert.ToInt32(c);
            else {
                Console.WriteLine("Invalid input.");
                return; // Exit the program if the input is invalid
            }
               

            Console.WriteLine("Enter the mathematical operation");
            char arthmetic = Convert.ToChar(Console.ReadLine());
            int Result = 0;
            switch (arthmetic)
            {
                case '+':
                    Result = first + second;
                    Console.WriteLine("The result of the addition is: " + Result);
                    break;
                case '-':
                    Result = first - second;
                    Console.WriteLine("The result of the subtraction is: " + Result);
                    break;
                case '*':
                    Result = first * second;
                    Console.WriteLine("The result of the multiplication is: " + Result);
                    break;
                case '/':
                    if (second == 0)
                    {
                        Console.WriteLine("Division by zero is not allowed.");
                    }
                    else
                    {
                        Result = first / second;
                        Console.WriteLine("The result of the division is: " + Result);
                    }
                    break;
                default:
                    Console.WriteLine("Invalid operation. Please enter +, -, *, or /.");
                    break;
            }

        }
    }
}
