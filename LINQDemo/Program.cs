using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace LINQDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
               new Student { Id = 1, Name = "Ahmed",Age=27 },
               new Student { Id = 2, Name = "Omar",Age=30 },
               new Student { Id = 3, Name = "Ali",Age=27 },
               new Student { Id = 4, Name = "Mona", Age = 23 },
               new Student { Id = 5, Name = "Sara", Age = 23 },
               new Student { Id = 6, Name = "Ahmed",Age=25 },

            };

            List<Course> courses = new List<Course>
            {
               new Course { Id = 1, Title = "BackEnd" },
               new Course { Id = 2, Title = "FrondEnd" },
               new Course { Id = 3, Title = "Math" },
            };

            List<Enrollment> enrollments = new List<Enrollment>
            {
              new Enrollment { StudentId = 1, CourseId = 1 },
              new Enrollment { StudentId = 2, CourseId = 3 },
              new Enrollment { StudentId = 1, CourseId = 2 },
              new Enrollment { StudentId = 4, CourseId = 1 },
              new Enrollment { StudentId = 5, CourseId = 3 }
            };

            // filtering using method
            var filtered = students.Where(s => s.Id > 2);
            foreach (var student in filtered)
                Console.WriteLine($"Id: {student.Id}, Name: {student.Name}, Age: {student.Age}");

            Console.WriteLine("-----------------------------------------------");
            

            // filtering using query syntax
            var query_filtered = from s in students where s.Id > 2 select s;
            foreach (var student in query_filtered)
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");

            Console.WriteLine("-----------------------------------------------");

            // Sorting 
            var sorted = students.OrderBy(s => s.Name);
            foreach (var student in sorted)
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");

            Console.WriteLine("-----------------------------------------------");
            var sorted_query = from s in students orderby s.Age select s;
            foreach (var student in sorted_query)
                Console.WriteLine($"ID: {student.Id}, Name: {student.Name}, Age: {student.Age}");

            Console.WriteLine("-----------------------------------------------");

            // projection
            var projected = students.Select(s => new { StudentId = s.Id, StudentName = s.Name });
            foreach (var student in projected)
                Console.WriteLine($"ID :{student.StudentId}, Name: {student.StudentName}");

            Console.WriteLine("-----------------------------------------------");
            var DistinctNames = students.Select(s => s.Name).Distinct();
            foreach (var name in DistinctNames)
                Console.WriteLine($"Name :{name}");

            Console.WriteLine("-----------------------------------------------");

            // Grouping
            var grouped = students.GroupBy(s => s.Age);
            foreach (var group in grouped)
            {
                Console.WriteLine($"Age: {group.Key}, Count {group.Count()}");
            }

            Console.WriteLine("-----------------------------------------------");

            // Joining
            var query = from e in enrollments
                        join s in students on e.StudentId equals s.Id
                        join c in courses on e.CourseId equals c.Id
                        select new
                        {
                            StudentName = s.Name,
                            CourseTitle = c.Title
                        };

            foreach (var item in query)
                Console.WriteLine($"Student: {item.StudentName}, Course: {item.CourseTitle}");


            Console.WriteLine("-----------------------------------------------");


            // Assesment 1 
            var studentsNames_CourseId = students.Join(enrollments,
                s => s.Id, 
                e => e.StudentId, 
                (s, e) => new { s.Name, e.CourseId }) 
                .Select(x => new { StudentName = x.Name, CourseId = x.CourseId });

            foreach (var item in studentsNames_CourseId)
                Console.WriteLine($"Student Name: {item.StudentName}, Course ID: {item.CourseId}");

            Console.WriteLine("-----------------------------------------------");

            // 2 
            var DistinctCourses = enrollments.Select(e => e.CourseId).Distinct();
            foreach (var courseID in DistinctCourses)
                Console.WriteLine($"course Id: {courseID}");

            Console.WriteLine("-----------------------------------------------");

            // 3 
            var StudentsNames_Courses = from e in enrollments
                                        join s in students on e.StudentId equals s.Id
                                        join c in courses on e.CourseId equals c.Id
                                        select new
                                        {
                                            StudentName = s.Name,
                                            CourseTitle = c.Title
                                        };
            var MathStudentsNames = StudentsNames_Courses.Where(e => e.CourseTitle == "Math").OrderBy(s => s.StudentName);

            Console.WriteLine("Math Students Names:");
            foreach (var msn in MathStudentsNames)
                Console.WriteLine($"{msn.StudentName}");


            Console.WriteLine("-----------------------------------------------");
            // 4 
            var AllStudentsEnrolled = enrollments.Select(e => e.StudentId).Distinct();

            var allIds = students.Select(s => s.Id);
            var NotEnrolledIds = allIds.Except(AllStudentsEnrolled);
            var NameAndAges = students
                .Where(s => NotEnrolledIds.Contains(s.Id))
                .Select(s => new { s.Name, s.Age });

            Console.WriteLine("Students not enrolled in any course:");
            foreach (var item in NameAndAges)
                Console.WriteLine($"Name: {item.Name}, Age: {item.Age}");

            Console.WriteLine("-----------------------------------------------");


            // 5
            var OldestStudents = students.OrderByDescending(s => s.Age).Take(3);
            Console.WriteLine("Oldest 3");
            foreach (var item in OldestStudents)
                Console.WriteLine(item.Name);

        }
    }
}
