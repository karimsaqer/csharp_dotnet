using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal class Program
    {
        // This is an AI Generated code for Drawing lines in a Tic Tac Toe game not me
        static void DrawLines(int[][] XOs)
        {
            Console.WriteLine("  0 1 2");
            for (int i = 0; i < XOs.Length; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < XOs[i].Length; j++)
                {
                    if (XOs[i][j] == 0)
                        Console.Write(" ");
                    else if (XOs[i][j] == 1)
                        Console.Write("X");
                    else
                        Console.Write("O");
                    if (j < XOs[i].Length - 1)
                        Console.Write("|");
                }
                Console.WriteLine();
                if (i < XOs.Length - 1)
                    Console.WriteLine("  -----");
            }
        }
        static void reInit(ref int[][] XOs,out int turn,out int moves)
        {
            Console.Clear();
            turn = 1;
            moves = 0;
            XOs = new int[3][];
            for (int i = 0; i < XOs.Length; i++)
            {
                XOs[i] = new int[3];
            }
        }

        static bool WinCase(int[][] XOs, int turn, int row, int col)
        {
            if ((XOs[row][0] == turn && XOs[row][1] == turn && XOs[row][2] == turn) ||
                    (XOs[0][col] == turn && XOs[1][col] == turn && XOs[2][col] == turn) ||
                    (XOs[0][0] == turn && XOs[1][1] == turn && XOs[2][2] == turn) ||
                    (XOs[0][2] == turn && XOs[1][1] == turn && XOs[2][0] == turn))
                return true;
            return false;
        }
        static void Main(string[] args)
        {
            int[][] XOs = new int[3][];
            int turn;
            int moves;
            reInit(ref XOs,out turn,out moves);
            while (true)
            {
                DrawLines(XOs);
                Console.WriteLine($"Player {turn}'s turn. Enter row and column (0-2): ");
                //string input = Console.ReadLine();
                int row = Convert.ToInt32(Console.ReadLine().ToString());
                int col = Convert.ToInt32(Console.ReadLine().ToString());
                // check if the input is valid
                if (row < 0 || row > 2 || col < 0 || col > 2)
                {
                    Console.WriteLine("Invalid input. Please enter two numbers between 0 and 2.");
                    continue;
                }
                if (XOs[row][col] != 0)
                    continue; 

                XOs[row][col] = turn;
                moves++;

                // win cases
                if (WinCase(XOs,turn,row,col))
                {
                    DrawLines(XOs);     
                    Console.WriteLine($"Player {turn} wins!");
                    Console.WriteLine("if you want to play again, press R and if you want to exit press any button");
                    string again = Console.ReadLine();
                    if (again.ToUpper() == "R")
                    {
                        reInit(ref XOs, out turn, out moves);
                        continue;
                    }
                    else
                        break;

                }

                // draw case
                if (moves >= 9)
                {
                    Console.Clear();
                    DrawLines(XOs);
                    Console.WriteLine("It's a draw!");
                    Console.WriteLine("if you want to play again, press R and if you want to exit press any button");
                    string again = Console.ReadLine();
                    if (again.ToUpper() == "R")
                    {
                        reInit(ref XOs, out turn, out moves);
                        continue;
                    }
                    else
                        break;  
                }

                // Switch players
                turn = 3 - turn;
            }
        }
    }
}
