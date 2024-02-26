using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class CoffeeShopUI
    {
        public static CoffeeShop AddShop()
        {
            Console.Write(" Enter Coffee Shop Name: ");
            string name = Console.ReadLine();
            CoffeeShop s = new CoffeeShop(name);
            return s;
        }
    }
}
