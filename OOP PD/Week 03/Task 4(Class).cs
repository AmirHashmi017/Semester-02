using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Book
    {
        public string title;
	public string author;
	public int publicationyear;
	public float price;
	public int quantity;
	public Book(string title, string author, int year, float price, int quantity)
        {
            this.title = title;
            this.author = author;
            this.publicationyear = year;
            this.price = price;
            this.quantity = quantity;
        }
        public string bookDetails()
        {
            return $" {title} \t {author} \t\t {publicationyear} \t\t\t {price} \t  {quantity} ";
        }
        public string gettitle()
        {
            return $" Title: {title}";
        }
        public string getauthor()
        {
            return $" Author: {author}";
        }
        public string getpublicationyear()
        {
            return $" Publication Year: {publicationyear}";
        }
        public string getprice()
        {
            return $" Price: {price}";
        }
        public bool sellcopies(int number)
        {
            if (number <= quantity)
            {
                quantity = quantity - number;
                return true;
            }
            return false;
        }
        public bool restock(int number)
        { 
            quantity = quantity + number;
            return true;
        }
    }
}
