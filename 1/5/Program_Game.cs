using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("I have chosen a number between 1 and 100.");
            Console.WriteLine("You have 5 attempts to guess it.");
            Random rnd = new Random();
            int number = rnd.Next(1, 101);
            //Console.WriteLine(number);

            for (int i = 0; i < 5; i++)
            {
                Console.Write("Attempt " + (i + 1) + "/5 : Enter your guess: ");
                int guess = int.Parse(Console.ReadLine());
                if (guess < 1 || guess > 100)
                    Console.WriteLine("Please enter a number between 1 and 100.");
                else if (guess < number)
                    Console.WriteLine("Too low! Try again.");
                else if (guess > number)
                    Console.WriteLine("Too high! Try again.");
                else
                {
                    Console.WriteLine("Congratulations! You guessed the number!");
                    break;
                }
            }
        }
    }
}
