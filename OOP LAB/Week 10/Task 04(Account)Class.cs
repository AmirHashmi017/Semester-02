using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Account
    {
        protected string AccountName;
        protected string AccountNumber;
        protected double Balance;

        public Account(string name,string number,double balance)
        {
            AccountName = name;
            AccountNumber = number;
            Balance = balance;
        }
        public string To_String()
        {
            return ($" Account Name: {AccountName}\t Account Number: {AccountNumber}\t Balance: {Balance}");
        }
    }
   
}
