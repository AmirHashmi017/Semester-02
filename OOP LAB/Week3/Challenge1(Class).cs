using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2Lab_Task1
{
    internal class Student
    {
        public string name;
        public float matric_marks;
        public float fsc_marks;
        public float ecat_marks;
        public double aggregate;
        public Student(string name, float matric, float fsc, float ecat, double agg)
        {
            this.name = name;
            this.matric_marks = matric;
            this.fsc_marks = fsc;
            this.ecat_marks = ecat;
            this.aggregate = agg;
        }
        public void showstudents()
        {
            Console.WriteLine("{0} \t\t \t  {1} \t\t\t {2} \t\t\t {3}", name, matric_marks, fsc_marks, ecat_marks);
        }
        public double calculateaggregate()
        {
            aggregate = (((matric_marks * 100) / 1100) * 0.1) + (((fsc_marks * 100) / 1100) * 0.4) + (((ecat_marks * 100) / 400) * 0.5);
            return aggregate;
        }
    }
}
