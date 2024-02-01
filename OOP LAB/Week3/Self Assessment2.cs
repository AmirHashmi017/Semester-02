
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssessement2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ATMaccount account = new ATMaccount(500);
            account.viewbalance();
            account.depositmoney(1200);
            account.depositmoney(7000);
            account.viewbalance();
            account.withdrawmoney(2000);
            account.withdrawmoney(4500);
            account.viewbalance();
            account.viewtransactionrecords();
            Console.ReadKey();
        }
    }
}
