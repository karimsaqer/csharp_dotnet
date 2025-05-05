using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct
{
    internal class Program
    {
        public struct Point
        {
            public int x;
            public int y;
            public Point(int x, int y)
            {
                this.x = x;
                this.y = y;
            }
            public double Distance(Point point2)
            {
                return Math.Sqrt(Math.Pow(point2.x - this.x, 2) + Math.Pow(point2.y - this.y, 2));
            }
        }
        static void Main(string[] args)
        {
            Point p1 = new Point(3, 4);
            Point p2 = new Point(0, 0);
            Console.WriteLine($"Distance between p1 and p2: {p1.Distance(p2)}");
        }
    }
}
