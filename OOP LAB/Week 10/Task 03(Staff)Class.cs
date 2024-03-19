using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Staff:Person
    {
        private string School;
        private double Pay;

        public Staff(string name, string adress, string school, double pay) : base(name, adress)
        {
            School = school;
            Pay = pay;
        }
        public double GetPay()
        { return Pay; }
        public void SetPay(double pay)
        { this.Pay = pay; }
        public string GetSchool()
        { return School; }
        public void SetProgram(string school)
        { this.School = school; }
    }
}
