using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1_Lab_5_
{
    internal class StudentUI
    {
        public static Student AddStudentUI(List<Degree> degrees)
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
                    if (preference == degrees[j].Degreetitle && degrees[j].Seats > 0)
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
            Student s1 = new Student(name, age, fsc, ecat, preferencelist);
            return s1;
        }
    }
}
