using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManagerLINQ.Classes
{
    public class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string Name, int Grade)
        {
            this.Name = Name;
            this.Grade = Grade;
        }
    }
}
