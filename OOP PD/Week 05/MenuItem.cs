using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class MenuItem
    {
            public string Name;
            public string Type;
            public double Price;

            public MenuItem(string name, string type, double price)
            {
                this.Name = name;
                this.Type = type;
                this.Price = price;
            }
        }
    }
