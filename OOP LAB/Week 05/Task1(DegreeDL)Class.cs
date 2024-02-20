using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1_Lab_5_
{
    internal class DegreeDL
    {
        static public List<Degree> Degrees = new List<Degree>();
        
        public static void AddDegree(Degree degree)
        {
        Degrees.Add(degree);
        }
    }
}

