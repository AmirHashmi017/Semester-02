using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StudentAccount stu = new StudentAccount("Amir", "909", 50000);
            SalaryAccount sal = new SalaryAccount("Ali", "109", 200000);
            SavingAccount sav = new SavingAccount("Butt", "108", 700000);
            Console.WriteLine(stu.To_String());
            if(stu.DepositAmount(5000))
            {
                Console.WriteLine("Successfully Deposited.");
            }
            else
            {
                Console.WriteLine("Out of Limit.");
            }
            Console.WriteLine(sal.To_String());
            Console.WriteLine("Tax is:{0}", sal.CalculateTax());
            Console.WriteLine(sav.To_String());
            Console.WriteLine("Profit is:{0}",sav.CalculateProfit());
            Console.ReadKey();
        }
    }
}
