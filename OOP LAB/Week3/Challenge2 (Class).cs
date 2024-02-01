using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab2_Task2
{
    internal class Product
    {
        public string ProductID;
        public string name;
        public float price;
        public string category;
        public string brand;
        public string country;
        public Product(string id, string name, float price, string category, string brand, string country)
        {
            this.ProductID = id;
            this.name = name;
            this.price = price;
            this.category = category;
            this.brand = brand;
            this.country = country;
        }
public void showproducts()
        {
Console.WriteLine("{0} \t\t\t {1} \t\t  {2} \t\t {3}\t\t\t{4}\t\t{5}",ProductID, name, price,category, brand, country);
	}
    }
}

