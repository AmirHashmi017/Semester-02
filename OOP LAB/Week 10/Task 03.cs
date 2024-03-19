using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student("Amir", "Model Town", "CS", 2023, 50000);
            Console.WriteLine(s1.To_String());
            Console.WriteLine($" Degree: {s1.GetDegreeProgram()}\t Year:{s1.GetYear()}\t Fee: {s1.GetFee()}");
            s1.SetFee(9000);
            s1.SetAdress("Behria Town");
            Console.WriteLine(s1.To_String());
            Console.WriteLine($" Degree: {s1.GetDegreeProgram()}\t Year:{s1.GetYear()}\t Fee: {s1.GetFee()}");
            Staff staff = new Staff("Ali", "Model Town", "UET", 50000);
            Console.WriteLine(staff.To_String());
            Console.WriteLine($" School: {staff.GetSchool()}\t Pay:{staff.GetPay()}");
            Console.ReadKey();
        }
    }
}
