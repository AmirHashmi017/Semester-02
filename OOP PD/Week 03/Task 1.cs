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
            float a=10;
            float b=10;
            Calculator c1 = new Calculator(10, 10);
            int option;
            while (true)
            {
	Console.Clear();
	 Console.WriteLine("\t\t\t Calculator\n");
                Console.WriteLine("1. Change Values of Atributes ");
                Console.WriteLine("2. Add");
                Console.WriteLine("3. Subtract");
                Console.WriteLine("4. Multiply");
                Console.WriteLine("5. Divide");
                Console.WriteLine("6. Modulus");
                Console.WriteLine("7. Exit");
                Console.Write("Enter option number: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Write("Enter first number: ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = float.Parse(Console.ReadLine());
                    c1.num1 = a;
                    c1.num2 = b;
                }
                else if (option == 2)
                {
                    Console.WriteLine("{0} +{1} ={2}", a, b, c1.sum());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine(" {0} - {1} = {2}", a, b, c1.diff());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, c1.product());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    if (b != 0)
                        Console.WriteLine(" {0} / {1} ={2}", a, b, c1.div());
                    else
                        Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 6)
                {
                    Console.WriteLine(" {0} / {1} ={2}", a, b, c1.mod());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    break;
                }
            }
        }
    }
}