using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> booklist = new List<Book>();
            int option, number;
            string title, author;
            float price;
            int year, quantity;
            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t\t\t BOOK MANAGEMENT SYSTEM\n\n");
        
    Console.WriteLine(" 1.Add Book");
                Console.WriteLine(" 2.View all books information");
                Console.WriteLine(" 3.Get Title of a book");
                Console.WriteLine(" 4.Get Author Details of a book");
                Console.WriteLine(" 5.Get Publication Year of a book");
                Console.WriteLine(" 6.Get Price of a book");
                Console.WriteLine(" 7.Sell Copies of a book");
                Console.WriteLine(" 8.Restock Book");
                Console.WriteLine(" 9.View Count of Books");
                Console.WriteLine(" 10.Exit");
                Console.Write(" Enter Option Number: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    Console.Write(" Enter Author Name: ");
                    author = Console.ReadLine();
                    Console.Write(" Enter Year of Publication: ");
                    year = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Price of Book: ");
                    price = float.Parse(Console.ReadLine());
                    Console.Write(" Enter Quantity of Book: ");
                    quantity = int.Parse(Console.ReadLine());
                    Book book1=new Book(title, author, year, price, quantity);
                    booklist.Add(book1);
                }
                else if (option == 2)
                {
                    Console.WriteLine("Title \t Author \t Publication Year \t Price \t Quantity");
            
        for (int i = 0; i < booklist.Count; i++)
                    {
                        Console.WriteLine(booklist[i].bookDetails());

        }
                }
                else if (option == 3)
                {
                    Console.Write(" Enter Author Name of Book: ");
                    author = Console.ReadLine();
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].author == author)
                            Console.WriteLine(booklist[i].gettitle());
                    }
                }
                else if (option == 4)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                            Console.WriteLine(booklist[i].getauthor());
                    }
                }
                else if (option == 5)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                            Console.WriteLine(booklist[i].getpublicationyear());
                    }
                }
                else if (option == 6)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                            Console.WriteLine(booklist[i].getprice());
                    }
                }
                else if (option == 7)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    Console.Write(" Enter Number of copies to sell: ");
                    number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                        {
                            if (booklist[i].sellcopies(number)) 
                            Console.WriteLine(" The Copies are successfully sell out.");

        else
                                Console.WriteLine(" Not Enough Copies");
                        }
                    }
                }
                else if (option == 8)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    Console.Write(" Enter Number of copies to restock: ");
                    number = int.Parse(Console.ReadLine());
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                        {
                            if (booklist[i].restock(number))
                            Console.WriteLine(" The Copies are successfully restocked.");
                        }
                    }
                }
                else if (option == 9)
                {
                    Console.WriteLine(" Total Number of Books is: {0}", booklist.Count);
            
    }
                else if (option == 10)
                {
                    break;
                }
                Console.WriteLine("\n\n\n Press any key to continue...");
                Console.ReadKey();
            }
        }

    }
}
