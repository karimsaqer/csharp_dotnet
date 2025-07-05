using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }

    public class Enrollment
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
    }
}
