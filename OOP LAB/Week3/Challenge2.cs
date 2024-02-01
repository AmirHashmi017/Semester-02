using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2_Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            List<Product> products = new List<Product>();
            while (true)
            {
                Console.WriteLine("\t\t\t PRODUCTS MANAGEMENT SYSTEM");
                Console.WriteLine("1. Add Products");
                Console.WriteLine("2. Show Products");
                Console.WriteLine("3. Calculate total store worth ");
                Console.WriteLine("4. Exit");
                Console.Write("Enter Option Number: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Products\n\n");
                    products.Add(addproducts());
                    count++;
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tShow Products\n\n");
                     Console.WriteLine("Product ID \t\t Name \t\t Price \t\t Category \t\t Brand \t\t Country");
            for (int i = 0; i < products.Count; i++)
            {
	products[i].showproducts();
            }
                }
                else if (option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tCalculate total store worth \n\n");
                    float total = totalstoreworth(products);
                    Console.WriteLine(" The sum of price of all the products in store is {0}", total);
                }
                else if (option == 4)
                {
                    Console.Clear();
                    break;
                }
                Console.WriteLine(" \n\n\nPress any Key to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
        static Product addproducts()
        {
            string id, name, category, brand, country;
            float price;
            Console.Write("Enter Product ID: ");
            id = Console.ReadLine();
            Console.Write("Enter Name: ");
            name = Console.ReadLine();
            Console.Write("Enter Product Price: ");
            price = float.Parse(Console.ReadLine());
            Console.Write("Enter Product category: ");
            category = Console.ReadLine();
            Console.Write("Enter Product Brand: ");
            brand = Console.ReadLine();
            Console.Write("Enter Product Country: ");
            country = Console.ReadLine();
            Product p1 = new Product(id, name, price, category, brand, country);
            return p1;
        }
        static float totalstoreworth(List<Product> products)
        {
            float result = 0F;
            for (int i = 0; i < products.Count; i++)
            {
                result += products[i].price;
            }
            return result;
        }

    }
    }
