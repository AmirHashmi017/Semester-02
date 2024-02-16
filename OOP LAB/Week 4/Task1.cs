using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> booklist = new List<Book>();
            int option;
            string author,title, ISBN, publisher;
            float price;
            int year, quantity, count;
            int authorsnumber;
            int numberstock=0;
            while (true)
            {
                List<string> authors = new List<string>();
                Console.Clear();
                Console.WriteLine("\t\t\t BOOK MANAGEMENT SYSTEM\n\n");
                Console.WriteLine(" 1. Add Book");
                Console.WriteLine(" 2. Search Book by title");
                Console.WriteLine(" 3. Search Book by ISBN");
                Console.WriteLine(" 4. Update Stock");
                Console.WriteLine(" 5.Exit");
                Console.Write(" Enter Option Number: ");
                option = int.Parse(Console.ReadLine());
                Console.Clear();
                if (option == 1)
                {
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    while (true)
                    {
                        Console.Write(" Enter  Number of Authors: ");
                        authorsnumber = int.Parse(Console.ReadLine());
                        if (authorsnumber <= 4)
                        {
                            for (int i = 1; i <= authorsnumber; i++)
                            {
                                Console.Write("Enter Name of Author {0}: ", i);
                                author = Console.ReadLine();
                                authors.Add(author);
                            }
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Sorry Maximum four authors are allowed.");
                    
    }
                    }
                    Console.Write(" Enter Year of Publication: ");
                    year = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Price of Book: ");
                    price = float.Parse(Console.ReadLine());
                    Console.Write(" Enter Quantity of Book: ");
                    quantity = int.Parse(Console.ReadLine());
                    Console.Write(" Enter Name of Publisher: ");
                    publisher = Console.ReadLine();
                    Console.Write(" Enter ISBN of Book: ");
                    ISBN = Console.ReadLine();
                    Book book1 = new Book(title, authors, year, price, quantity, publisher, ISBN);
                    booklist.Add(book1);
                }
                else if (option == 2)
                {
                    count = 0;
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
          

                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                        {
                            Console.WriteLine("\n\nTitle \t ISBN \t  Publisher \t Publication Year \t Price \t Quantity");
                            Console.WriteLine(booklist[i].bookDetails());
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Book Exist.");
                }
                else if (option == 3)
                {
                    count = 0;
                    Console.Write(" Enter ISBN of Book: ");
                    ISBN = Console.ReadLine();
                   

                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].ISBN == ISBN)
                        {
                            Console.WriteLine("\n\nTitle \t ISBN \t  Publisher \t Publication Year \t Price \t Quantity");
                            Console.WriteLine(booklist[i].bookDetails());
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Book Exist.");
                }
                else if (option == 4)
                {
                    string op;
                    count = 0;
                    Console.WriteLine(" 1. Increase Stock");
                    Console.WriteLine(" 2. Decrease Stock");
                    Console.Write(" Enter Option Number: ");
                    op = Console.ReadLine();
                    Console.Write(" Enter Title of Book: ");
                    title = Console.ReadLine();
                    if (op == "1")
                    {
                        Console.Write(" Enter Number of copies to increase: ");
                        numberstock = int.Parse(Console.ReadLine());
                    }
                    else if (op == "2")
                    {
                        Console.Write(" Enter Number of copies to decrease: ");
                        numberstock = int.Parse(Console.ReadLine());
                    }
                    for (int i = 0; i < booklist.Count; i++)
                    {
                        if (booklist[i].title == title)
                        {
                            if (op == "1")
                            {
                                if (booklist[i].increasestock(numberstock))
                                    Console.WriteLine(" The Stock is sucessfully increased.");
                            }
                            if (op == "2")
                            {
                                if (booklist[i].decreasestock(numberstock))
                                    Console.WriteLine(" The Stock is sucessfully decreased.");
                                else
                                    Console.WriteLine(" Not Enough Copies");
                            }
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Book Exist.");
                }
                else if (option == 5)
                {
                    break;
                }
                Console.WriteLine("\n\n\n Press any key to continue...");
                Console.ReadKey();
            }
        }

    }
}
