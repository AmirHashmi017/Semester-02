using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uams
{
    internal class Student
    {
       
            public string Name;
            public int Age;
            public double FscMarks;
            public double EcatMarks;
            public double Merit;
            public List<Degree> Preferences = new List<Degree>();
            public Degree DegreeRegistered;
            public List<Subject> SubjectsRegistered = new List<Subject>();

            public Student(string name, int age, double fscmarks, double ecatmarks, List<Degree> preferencelist)
            {
                this.Name = name;
                this.Age = age;
                this.FscMarks = fscmarks;
                this.EcatMarks = ecatmarks;
                this.Merit = 0F;
                for (int i = 0; i < preferencelist.Count; i++)
                    Preferences.Add(preferencelist[i]);
            }

            public void CalculateMerit()
            {
                Merit = (((FscMarks / 1100) * 0.5F) + ((EcatMarks / 1100) * 0.5F)) * 100;
            }
            public void ViewStudent()
            {
                Console.WriteLine("{0} \t\t \t  {1} \t\t\t {2} \t\t\t {3}", Name, Age, FscMarks, EcatMarks);
            }
            public void CalculateFee()
            {
                double totalfee = 0;
                for (int x = 0; x < SubjectsRegistered.Count; x++)
                {
                    totalfee += SubjectsRegistered[x].Subjectfee;
                }
                Console.WriteLine($" {Name} has {totalfee} fees.");
            }
            public int GetCreditHours()
            {
                int hours = 0;
                for (int i = 0; i < SubjectsRegistered.Count; i++)
                {
                    hours = hours + SubjectsRegistered[i].Credithours;
                }
                return hours;
            }
            public bool AddStudentSubject(Subject sub)
            {
                int cred = GetCreditHours() + sub.Credithours;
                if (DegreeRegistered != null && cred <= 9 && DegreeRegistered.IsSubjectExist(sub))
                {
                    SubjectsRegistered.Add(sub);
                    return true;
                }
                return false;
            }
        }
    }

