using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace task3
{
    internal class Book
    {
        public string title;
        public List<string> author = new List<string>();
        public int publicationyear;
        public float price;
        public int stock;
        public string publisher;
        public string ISBN;
        public Book(string title, List<string> authors, int year, float price, int quantity, string publisher, string ISBN)
        {
            this.title = title;
            for (int i = 0; i < authors.Count; i++)
            {
                author.Add(authors[i]);
            }
            this.publicationyear = year;
            this.price = price;
            this.stock = quantity;
            this.publisher = publisher;
            this.ISBN = ISBN;
        }
        public string bookDetails()
        {
            return $" {title} \t {ISBN} \t   {publisher} \t\t {publicationyear} \t\t {price} \t  {stock} ";
        }
        public bool increasestock(int number)
        {
            stock = stock + number;
            return true;
        }
        public bool decreasestock(int number)
        {
            if (stock >= number)
            {
                stock = stock - number;
                return true;
            }
            return false;
        }
    }
}
