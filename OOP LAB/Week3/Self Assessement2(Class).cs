
using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessement2
{
    internal class ATMaccount
    {
        public int balance;
        public List<string> transactionrecords = new List<string>();
        public ATMaccount(int defaultamount)
        {
            this.balance = defaultamount;
        }
        public void depositmoney(int amount)
        {
            balance = balance + amount;
            transactionrecords.Add("Deposited: " + amount);
        }
        public void withdrawmoney(int amount)
        {
            balance = balance - amount;
            transactionrecords.Add("Withdrawn: " + amount);
        }
        public void viewbalance()
        {
            Console.Write("Your current balance is: {0}\n", balance);
        }
        public void viewtransactionrecords()
        {
            for (int i = 0; i < transactionrecords.Count; i++)
            {
                Console.WriteLine(transactionrecords[i]);
            }
        }
    }
}