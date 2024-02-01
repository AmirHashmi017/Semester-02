using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfAssesement1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float a, b;
            Console.Write("Enter first number: ");
            a = float.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            b = float.Parse(Console.ReadLine());
            Console.Write("Enter the operation(+,-,*,/): ");
            char op= char.Parse(Console.ReadLine());
            Calculator c1 = new Calculator(a, b);
            if (op== '+')
            {
                Console.WriteLine("{0} +{1} ={2}", a, b, c1.sum());
            }
            else if (op == '-')
            {
                Console.WriteLine(" {0} - {1} = {2}", a, b, c1.diff());
            }
            else if (op == '*')
            {
                Console.WriteLine("{0} * {1} = {2}", a, b, c1.product());
            }
            else if (op== '/')
            {
                Console.WriteLine(" {0} / {1} ={2}", a, b, c1.div());
            }
            Console.ReadKey();
        }
    }
}
