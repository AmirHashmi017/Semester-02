using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams
{
    internal class StudentUI
    {
       public  static Student Addstudent(List<Degree> degrees)
        {
            string name;
            double fsc, ecat;
            int age, pref;
            int count = 0;
            string preference;
            List<Degree> preferencelist = new List<Degree>();
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Age: ");
            age = int.Parse(Console.ReadLine());
            Console.Write("Enter Inter Marks: ");
            fsc = double.Parse(Console.ReadLine());
            Console.Write("Enter ECAT Marks: ");
            ecat = double.Parse(Console.ReadLine());
            Console.Write(" Enter number of Preferences: ");
            pref = int.Parse(Console.ReadLine());
            for (int i = 0; i < pref; i++)
            {
                Console.Write(" Enter Preference {0}: ", i + 1);
                preference = Console.ReadLine();
                for (int j = 0; j < degrees.Count; j++)
                {
                    if (preference == degrees[j].DegreeTitle && degrees[j].Seats > 0)
                    {
                        preferencelist.Add(degrees[j]);
                        count++;
                    }
                }
                if (count == 0)
                {
                    Console.WriteLine(" The requested degree program is not available.");
                    i--;
                    count = 0;
                }
            }
            Student S1 = new Student(name, age, fsc, ecat, preferencelist);
            return S1;
        }
        public static  void ViewStudents()
        {
            int count = 0;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\t\t\t View Registered students\n\n");
            Console.WriteLine("Student Name \t\t Student Age \t\t FSC Marks \t\t ECAT Marks");
            Console.ForegroundColor = ConsoleColor.White;
            for (int i = 0; i < StudentDL.Students.Count; i++)
            {
                if (StudentDL.Students[i]. DegreeRegistered != null)
                {
                    StudentDL.Students[i].ViewStudent();
                    count++;
                }
            }
            if (count == 0)
                Console.WriteLine(" \n\nNo Registered Student Exist.");

        }
    }
}
