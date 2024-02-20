using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lab_5_
{
    internal class StudentDL
    {
        public static List<Student> Students = new List<Student>();

        public static void addstudent(Student s1)
        {
            Students.Add(s1);
        }
    }
}
