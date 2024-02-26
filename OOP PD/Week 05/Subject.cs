using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uams
{
    
        internal class Subject
        {
            public string Subjectcode;
            public string Subjecttype;
            public int Credithours;
            public double Subjectfee;

            public Subject(string subjectcode, string subjecttype, int credithours, double subjectfee)
            {
                this.Subjectcode = subjectcode;
                this.Subjecttype = subjecttype;
                this.Credithours = credithours;
                this.Subjectfee = subjectfee;
            }
        }
    }

