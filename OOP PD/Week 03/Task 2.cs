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
            float a = 10;
            float b = 10;
            int option;
            while (true)
            {
	Console.Clear();
	Console.WriteLine("\t\t\t CALCULATOR\n");
                Calculator c1 = new Calculator(10, 10);
                Console.WriteLine("1. Add");
                Console.WriteLine("2. Subtract");
                Console.WriteLine("3. Multiply");
                Console.WriteLine("4. Divide");
                Console.WriteLine("5. Modulus");
                Console.WriteLine("6. Squareroot");
                Console.WriteLine("7. Exponent");
                Console.WriteLine("8. Logarithm");
                Console.WriteLine("9. sin");
                Console.WriteLine("10. cos");
                Console.WriteLine("11. tan");
                Console.WriteLine("12. Exit");
                Console.Write("Enter option number: ");
                option = int.Parse(Console.ReadLine());
                if (option == 1 || option == 2 || option == 3 || option == 4||option ==5 )
                {
                    Console.Write("Enter first number: ");
                    a = float.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    b = float.Parse(Console.ReadLine());
                    c1.num1 = a;
                    c1.num2 = b;
                }
                else if (option == 6 || option == 7 || option == 8 || option == 9 || option == 10||option==11)
                {
                    Console.Write("Enter  number: ");
                    a = float.Parse(Console.ReadLine());
                    c1.num1 = a;
                }
                if (option == 1)
                {
                    Console.WriteLine("{0} +{1} ={2}", a, b, c1.sum());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 2)
                {
                    Console.WriteLine(" {0} - {1} = {2}", a, b, c1.diff());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 3)
                {
                    Console.WriteLine("{0} * {1} = {2}", a, b, c1.product());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 4)
                {
                    if (b != 0)
                        Console.WriteLine(" {0} / {1} ={2}", a, b, c1.div());
                    else
                        Console.WriteLine("Invalid Input");
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 5)
                {
                    Console.WriteLine(" {0} / {1} ={2}", a, b, c1.mod());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                if (option == 6)
                {
                    Console.WriteLine("Square Root of {0}={1}", a,c1.squareroot());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 7)
                {
                    Console.WriteLine("Exp of {0}={1}", a, c1.exponent());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 8)
                {
                    Console.WriteLine("Log of {0}={1}", a, c1.log());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 9)
                {
                    Console.WriteLine("sin({0})={1}", a, c1.sin());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 10)
                {
                    Console.WriteLine("cos({0})={1}", a, c1.cos());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 11)
                {
                    Console.WriteLine("tan({0})={1}", a, c1.tan());
                    Console.WriteLine("Press any key to continue.");
                    Console.ReadKey();
                }
                else if (option == 12)
                {
                    break;
                }
            }
        }
    }
}