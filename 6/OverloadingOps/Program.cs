using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OverloadingOps
{

    class Grid
    {
        public int PointX;
        public int PointY;
        public Grid(int x, int y)
        {
            PointX = x;
            PointY = y;
        }

        // A + B 
        public static Grid operator +(Grid a, Grid b)
        {
            return new Grid(a.PointX + b.PointX, a.PointY + b.PointY);
        }

        // A - B
        public static Grid operator -(Grid a, Grid b)
        {
            return new Grid(a.PointX - b.PointX, a.PointY - b.PointY);
        }

        // A > B 
        public static bool operator >(Grid a, Grid b)
        {
            return (a.PointX > b.PointX) && (a.PointY > b.PointY);
        }

        // A < B operator 
        public static bool operator <(Grid a, Grid b)
        {
            return (a.PointX < b.PointX) && (a.PointY < b.PointY);
        }

        // A <= B operator
        public static bool operator <=(Grid a, Grid b)
        {
            return (a.PointX <= b.PointX) && (a.PointY <= b.PointY);
        }

        // A >= B operator
        public static bool operator >=(Grid a, Grid b)
        {
            return (a.PointX >= b.PointX) && (a.PointY >= b.PointY);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Grid a = new Grid(10, 20);
            Grid b = new Grid(5, 15);
            Grid c = a + b;
            Console.WriteLine($"c: ({c.PointX}, {c.PointY})");
            c = a - b;
            Console.WriteLine($"c_new: ({c.PointX}, {c.PointY})");
            Console.WriteLine($"a > b: {a > b}");
            Console.WriteLine($"a < b: {a < b}");
            Console.WriteLine($"a <= b: {a <= b}");
            Console.WriteLine($"a >= b: {a >= b}");
        }
    }
}
