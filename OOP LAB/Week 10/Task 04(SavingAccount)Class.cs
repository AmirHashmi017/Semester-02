using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class SavingAccount:Account
    {
        public SavingAccount(string name, string number, double balance) : base(name, number, balance)
        {
        }
        public double CalculateProfit()
        {
            Balance -= (Balance * 0.2);
            return (Balance * 0.2);
        }
    }
}
