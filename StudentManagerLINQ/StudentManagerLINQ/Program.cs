using StudentManagerLINQ.Classes;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManagerLINQ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Alpha", 51),
                new Student("Bob", 93),
                new Student("Charlie",92)
            };

            // Example LINQ queries
            var highAchievers = from student in students
                                where student.Grade > 90
                                select student;

            var namedStudent = students.FirstOrDefault(s => s.Name == "Alice");

            var orderedStudents = students.OrderBy(s => s.Grade);

            // Display results
            Console.WriteLine("High Achievers:");
            foreach (var student in highAchievers)
            {
                Console.WriteLine($"Name: {student.Name}, Grade: {student.Grade}");
            }

        }
    }
}
