using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexers
{
    internal class Program
    {
        class Grades
        {
            private int[] marks = new int[5];

            public int this[int index]
            {
                get { return marks[index]; }
                set { marks[index] = value; }
            }
        }
        static void Main(string[] args)
        {
            Grades grades = new Grades();
            grades[0] = 95;
            grades[1] = 88;

            Console.WriteLine(grades[0]); // Output: 95
            Console.WriteLine(grades[1]); // Output: 88
        }
    }
}
