using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task1_Lab_5_
{
    internal class Degree
    {
        public string Degreetitle;
        public int Duration;
        public int Seats;
        List<Subject> Subjectsadd = new List<Subject>();

        public Degree(string degreetitle, int duration, int seats)
        {
            this.Degreetitle = degreetitle;
            this.Duration = duration;
            this.Seats = seats;
        }

        public bool addsubject(Subject sub)
        {
            int totalcredithours = calculatecredithours() + sub.Credithours;
            if (totalcredithours <= 20)
            {
                Subjectsadd.Add(sub);
                return false;
            }
            return true;
        }
        public bool issubjectexist(Subject sub)
        {
            for (int i = 0; i < Subjectsadd.Count; i++)
            {
                if (Subjectsadd[i].Subjectcode == sub.Subjectcode)
                    return true;
            }
            return false;
        }
        public int calculatecredithours()
        {
            int hours = 0;
            for (int i = 0; i < Subjectsadd.Count; i++)
            {
                hours = hours + Subjectsadd[i].Credithours;
            }
            return hours;
        }
    }
}
