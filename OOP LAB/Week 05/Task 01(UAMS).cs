using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1_Lab_5_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            while (true)
            {
                Console.WriteLine("\t\t\t University Admission MANAGEMENT SYSTEM (UAMS)");
                Console.WriteLine("1. Add Student");
                Console.WriteLine("2. Add Degree Program");
                Console.WriteLine("3. Add Subjects in a specific Degree");
                Console.WriteLine("4. Generate Merit");
                Console.WriteLine("5. View Registered Students");
                Console.WriteLine("6. View Students of a specific Program");
                Console.WriteLine("7. Register Subjects for a specific Student");
                Console.WriteLine("8. Calculate Fee for all registered Students");
                Console.WriteLine("9. Exit");
                Console.Write("Enter Option Number: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Student\n\n");
                    if (DegreeDL.Degrees.Count > 0)
                        StudentDL.addstudent(StudentUI.AddStudentUI(DegreeDL.Degrees));
                    else
                        Console.WriteLine(" No Degree Program Available");
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Degree Program\n\n");
                    DegreeDL.AddDegree(DegreeUI.AddDegreeUI(SubjectDL.Subjects));
                }
                else if (option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Subjects in a specific Degree\n\n");
                    adddegreesubjects(SubjectDL.Subjects, DegreeDL.Degrees);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t Calculate Merit\n\n");
                    List<Student> sortedstudents = new List<Student>();
                    foreach (Student s in StudentDL.Students)
                    {
                        s.CalculateMerit();
                    }
                    sortedstudents = StudentDL.Students.OrderByDescending(o => o.Merit).ToList();
                    giveadmission(sortedstudents);
                }
                else if (option == 5)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t View Registered students\n\n");
                    Console.WriteLine("Student Name \t\t Student Age \t\t FSC Marks \t\t ECAT Marks");
                    for (int i = 0; i < StudentDL.Students.Count; i++)
                    {
                        if (StudentDL.Students[i].DegreeRegistered != null)
                        {
                            StudentDL.Students[i].ViewStudent();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" \n\nNo Registered Student Exist.");
                }
                else if (option == 6)
                {
                    count = 0;
                    string deg = "";
                    Console.Clear();
                    Console.WriteLine("\t\t\t View Student of a specific degree\n\n");
                    Console.Write(" Enter Degree Name: ");
                    deg = Console.ReadLine();
                    Console.WriteLine("\n\nStudent Name \t\t Student Age \t\t FSC Marks \t\t ECAT Marks");
                    for (int i = 0; i < StudentDL.Students.Count; i++)
                    {
                        if (StudentDL.Students[i].DegreeRegistered != null && StudentDL.Students[i].DegreeRegistered.Degreetitle == deg)
                        {
                            StudentDL.Students[i].ViewStudent();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" \n\n No Such Student Exist.");
                }
                else if (option == 7)
                {
                    string na = " ";
                    string co = " ";
                    Subject sub = new Subject("0", "0", 0, 0);
                    Console.Clear();
                    Console.WriteLine("\t\t\t Register Subjects for a specific Student\n\n");
                    Console.Write(" Enter Student Name: ");
                    na = Console.ReadLine();
                    Console.Write(" Enter Subject Code you want to register: ");
                    co = Console.ReadLine();
                    for (int i = 0; i < SubjectDL.Subjects.Count; i++)
                    {
                        if (SubjectDL.Subjects[i].Subjectcode == co)
                        {
                            sub = SubjectDL.Subjects[i];
                        }
                    }
                    for (int n = 0; n < StudentDL.Students.Count; n++)
                    {
                        if (StudentDL.Students[n].Name == na)
                        {
                            if (StudentDL.Students[n].AddStudentSubject(sub))
                                Console.WriteLine(" Subject is successfully added.");

                            else
                                Console.WriteLine(" A problem occurs while adding subject.");
                        }
                    }
                }
                else if (option == 8)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\t Calculate Fee for all registered Students\n\n");
                    for (int i = 0; i < StudentDL.Students.Count; i++)
                    {
                        if (StudentDL.Students[i].DegreeRegistered != null)
                        {
                            StudentDL.Students[i].CalculateFee();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" \n\nNo Registered Student Exist.");
                }
                else if (option == 9)
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine("\n\nPress any Key to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static void adddegreesubjects(List<Subject> subjects, List<Degree> degrees)
        {
            int count = 0;
            string degrtitle, subjcode, subjtype;
            int credhours;
            double fees;
            Console.Write(" Enter Degree Name: ");
            degrtitle = Console.ReadLine();
            Console.Write("Enter subject code: ");
            subjcode = Console.ReadLine();
            Console.Write("Enter subject type: ");
            subjtype = Console.ReadLine();
            Console.Write("Enter subject Credit Hours: ");
            credhours = int.Parse(Console.ReadLine());
            Console.Write("Enter subject Fees: ");
            fees = double.Parse(Console.ReadLine());
            Subject sub = SubjectDL.AddInSubjectList(subjcode, subjtype, credhours, fees);
            subjects.Add(sub);
            for (int i = 0; i < degrees.Count; i++)
            {
                if (degrees[i].Degreetitle == degrtitle)
                {
                    count++;
                    if (degrees[i].addsubject(sub))
                    {
                        Console.WriteLine(" Subject cannot be added as Limit of credit hours is exceeded.");

                    }
                }
            }
            if (count == 0)
                Console.WriteLine(" No such degree Exist.");
        }
        static void giveadmission(List<Student> sortedstudents)
        {
            int counter = 0;
            foreach (Student s in sortedstudents)
            {
                counter = 0;
                foreach (Degree d in s.Preferences)
                {
                    if (s.DegreeRegistered == null && d.Seats > 0)
                    {
                        s.DegreeRegistered = d;
                        d.Seats--;
                        Console.WriteLine($" {s.Name} got admission in {d.Degreetitle}");
                        counter++;
                    }
                    if (counter == 0)
                        Console.WriteLine($" {s.Name} did not get admission.");

                }
            }
        }
    }
}

