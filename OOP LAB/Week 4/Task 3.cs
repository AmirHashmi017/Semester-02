using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Book> booklist = new List<Book>();
            List<Member> members = new List<Member>();
            int option;
            string author, title, ISBN, publisher;
            float price;
            int year, quantity, count;
            int authorsnumber;
            int numberstock = 0;
            string membername = " ";
               string memberID, name;
            float balance;
            string ID = "0";
            while (true)
            {
                List<string> authors = new List<string>();
                Console.Clear();
                Console.WriteLine("\t\t\t BOOK MANAGEMENT SYSTEM\n\n");
                Console.WriteLine(" 1. Add Book");
                Console.WriteLine(" 2. Search Book by title");
                Console.WriteLine(" 3. Search Book by ISBN");
                Console.WriteLine(" 4. Update Stock");
                Console.WriteLine(" 5. Add Member");
                Console.WriteLine(" 6. Search Member or Non-Member");
                Console.WriteLine(" 7. Update Member or Non-Member");
                Console.WriteLine(" 8. Purchase Books");
                Console.WriteLine(" 9. Display Total Sales and Membership Stats");
                Console.WriteLine(" 10.Exit");
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
                    Console.Write(" Enter Name of member: ");
                    membername = Console.ReadLine();
                    Console.Write(" Enter Member ID: ");
                    memberID = Console.ReadLine();
                    Console.Write(" Enter Money in Bank: ");
                    balance = float.Parse(Console.ReadLine());
                    balance -= 1000;
                    Console.WriteLine(" {0} is sucessfully added as member by submitting membership fee: Rs.1000.Now the balance of 	member is {1} ", membername, balance);
                    Member member1 = new Member(membername, memberID, 0, balance, 1000);
                    members.Add(member1);
                }
                else if (option == 6)
                {
                    count = 0;
                    Console.Write(" Enter Member Name: ");
                    membername = Console.ReadLine();
                    for (int i = 0; i < members.Count; i++)
                    {
                        
                        if (members[i].membername == membername)
                        {
                            Console.WriteLine("\n\n Name \t Member ID  \t No. of books bought \t Balance \t Amount Spent");
                            Console.WriteLine(members[i].memberDetails());
                            if (members[i].memberID != "0")
                                Console.WriteLine("Status: Member");
                            else
                                Console.WriteLine("Status: Not a Member");
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Person Exist.");
                }
                else if (option == 7)
                {
                    count = 0;
                    Console.Write(" Enter Member Name: ");
                    membername = Console.ReadLine();
                    for (int i = 0; i < members.Count; i++)
                    {
                        if (members[i].membername == membername && members[i].memberID != "0")
                        {
                            Console.Write(" Enter new Member Name: ");
                            name = Console.ReadLine();
                            Console.Write(" Enter new Member ID: ");
                            ID = Console.ReadLine();
                            if (members[i].editmember(name, ID))
                                Console.WriteLine(" The Member Information is edited sucessfully.");
                            count++;
                        }
                        else if (members[i].membername == membername && members[i].memberID == "0")
                        {
                            Console.Write(" Enter new  Name: ");
                            name = Console.ReadLine();
                            if (members[i].editmember(name, ID))
                                Console.WriteLine(" The Ocassional Buyer(Non-Member) Information is edited sucessfully.");
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Person Exist.");
                }
                else if (option == 8)
                {
                    int nonmember = 0;
                    count = 0;
                    int bookexist = 0;
                    int bookno = -1;
                    string ismember, bookn;
                    int qty;
                    Console.Write(" Are you a member or not (Enter 'Y' for Yes and 'N' for No): ");

                    ismember = Console.ReadLine();
                    if (ismember == "Y" || ismember == "y")
                    {
                        Console.Write(" Enter Your Name: ");
                        name = Console.ReadLine();
                        Console.Write(" Enter Your Member ID: ");
                        ID = Console.ReadLine();
                        Console.Write(" Enter the Book Name you want to purchase: ");
                        bookn = Console.ReadLine();
                        Console.Write(" How many copies you want to purchase: ");
                        qty = int.Parse(Console.ReadLine());
                        for (int i = 0; i < booklist.Count; i++)
                        {
                            if (booklist[i].title == bookn)
                            {
                                bookno = i;
                                bookexist++;
                            }
                        }
                            if (bookexist == 0)
                                Console.WriteLine(" No Such Book Available.");
                            else
                            {
                                for (int x = 0; x < members.Count; x++)
                                {
                                    if (members[x].membername == name && members[x].memberID == ID)
                                    {
                                        count++;
                                        if (members[x].purchasebooks(booklist[bookno], qty))
                                            Console.WriteLine(" Sucessfully Purchased");
                                        else
                                            Console.WriteLine(" Purchase Failed.Not enough copies Available or Your Balance is insufficient.");
                                    }
                                }
                                if (count == 0)
                                    Console.WriteLine(" No such Member Exist.");
                            }
                        }
                    

                    else if (ismember == "N" || ismember == "n")
                    {
                        Console.Write(" Enter Your Name: ");
                        name = Console.ReadLine();
                        for(int p = 0; p < members.Count; p++)
                        {
                            if (name == members[p].membername)
                            {
                                nonmember++;
                            }
                        }
                        if (nonmember == 0)
                        {
                            Console.Write(" Enter Your Money in Bank: ");
                            balance = int.Parse(Console.ReadLine());
                            Member member2 = new Member(name, "0", 0, balance, 0);
                            members.Add(member2);
                        }
                        Console.Write(" Enter the Book Name you want to purchase: ");
                        bookn = Console.ReadLine();
                        Console.Write(" How many copies you want to purchase: ");
                        qty =int.Parse(Console.ReadLine());
                        for (int i = 0; i < booklist.Count; i++)
                        {
                            if (booklist[i].title == bookn)
                            {
                                bookno = i;
                                bookexist++;
                            }
                        }
                            if (bookexist == 0)
                                Console.WriteLine(" No Such Book Available."); 
                            else
                            {
                                for (int n = 0; n < members.Count; n++)
                                {
                                    if (members[n].membername == name)
                                    {
                                        if (members[n].purchasebooks(booklist[bookno], qty))
                                            Console.WriteLine(" Sucessfully Purchased");
                                        else
                                            Console.WriteLine(" Purchase Failed.Not enough copies Available or Your Balance is insufficient.");
                                    }
                                }
                            }
                        }
                    }
                    else if (option == 9)
                    {
                        int totalsales = 0;
                        int totalmembers = 0;
                        int totalmemberfee = 0;
                        for (int i = 0; i < members.Count; i++)
                        {
                            totalsales = totalsales + members[i].numberofboughtbooks;
                            if (members[i].memberID != "0")
                                totalmembers++;
                        }
                        totalmemberfee = totalmembers * 1000;
                        Console.WriteLine(" Total Sales made by Bookstore are: {0} ", totalsales);
                        Console.WriteLine(" Total Number of Members are: {0} ", totalmembers);
                        Console.WriteLine(" Total Membership fee collected is: {0} ", totalmemberfee);
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

