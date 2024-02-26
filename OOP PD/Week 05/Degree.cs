using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace uams
{
    internal class Degree
    {
        
            public string DegreeTitle;
            public int Duration;
            public int Seats;
            public List<Subject> SubjectsAdd = new List<Subject>();

            public Degree(string degreetitle, int duration, int seats)
            {
                this.DegreeTitle = degreetitle;
                this.Duration = duration;
                this.Seats = seats;
            }

            public bool AddSubject(Subject sub)
            {
                int totalcredithours = CalculateCreditHours() + sub.Credithours;
                if (totalcredithours <= 20)
                {
                    SubjectsAdd.Add(sub);
                    return false;
                }
                return true;
            }
            public bool IsSubjectExist(Subject sub)
            {
                for (int i = 0; i < SubjectsAdd.Count; i++)
                {
                    if (SubjectsAdd[i].Subjectcode == sub.Subjectcode)
                        return true;
                }
                return false;
            }
            public int CalculateCreditHours()
            {
                int hours = 0;
                for (int i = 0; i < SubjectsAdd.Count; i++)
                {
                    hours = hours + SubjectsAdd[i].Credithours;
                }
                return hours;
            }
        }
    }

