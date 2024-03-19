using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class SalaryAccount:Account
    {
        public SalaryAccount(string name, string number, double balance) : base(name, number, balance)
        {
        }
        public double CalculateTax()
        {
            Balance -= (Balance * 0.2);
            return (Balance * 0.2);
        }
    }
}
