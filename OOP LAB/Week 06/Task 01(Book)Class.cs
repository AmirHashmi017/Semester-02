using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_01__Lab_06_
{
    internal class Book
    {
        private string BookName;
        private Author BookAuthor;
        private double Price;

        public Book(string bookname, double price, string authorname, string email)
        {
            this.BookName = bookname;
            BookAuthor = new Author(authorname, email);
            this.Price = price;
        }
        public void SetBookName(string name)
        {
            BookName = name;
        }
        public void SetPrice(double price)
        {
            Price = price;
        }
        public string GetBookName()
        {
            return BookName;
        }
        public double GetPrice()
        {
            return Price;
        }
        public Author GetAuthor()
        {
            return BookAuthor;
        }
        public void SetAuthor(string name, string email)
        {
            BookAuthor.SetName(name);
            BookAuthor.SetEmail(email);
        }

    }
}
