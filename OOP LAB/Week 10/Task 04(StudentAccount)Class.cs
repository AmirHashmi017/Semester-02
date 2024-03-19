using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class StudentAccount:Account
    {
        private double Limit=500000;

        public StudentAccount(string name,string number,double balance):base(name,number,balance)
        {
        }
        public bool DepositAmount(double amount)
        {
            if(Balance+amount<=Limit)
            {
                Balance += amount;
                return true;
            }
            return false;
        }
    }
}
