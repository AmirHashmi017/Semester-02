using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lab_5_
{
    internal class SubjectDL
    {
        public static List<Subject> Subjects = new List<Subject>();

        public static Subject AddInSubjectList(string subcode, string subtype, int credithours, double fee)
        {
            Subject Sub1 = new Subject(subcode, subtype, credithours, fee);
            Subjects.Add(Sub1);
            return Sub1;
        }
    }
}
