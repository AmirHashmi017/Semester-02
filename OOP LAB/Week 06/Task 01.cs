using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_01__Lab_06_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book b = new Book("Special", 1700, "amir", "amirhash191@gmail.com");
            Console.WriteLine($" The Name of Book is: {b.GetBookName()}");
            Console.WriteLine($" The Price of Book is: {b.GetPrice()}");
            Console.WriteLine($" The Author Name is: {b.GetAuthor().GetName()}");
            Console.WriteLine($" The Author Name is: {b.GetAuthor().GetEmail()}");
            b.SetBookName("Titanic");
            b.SetPrice(900);
            b.SetAuthor("Ali", "aliemail");
            Console.WriteLine($" The Name of Book is: {b.GetBookName()}");
            Console.WriteLine($" The Price of Book is: {b.GetPrice()}");
            Console.WriteLine($" The Author Name is: {b.GetAuthor().GetName()}");
            Console.WriteLine($" The Author Name is: {b.GetAuthor().GetEmail()}");
            Console.ReadKey();
        }
    }
}

