using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class MenuItemUI
    {
        public static MenuItem AddItem()
        {
            Console.Write(" Enter Item Name: ");
            string itemname = Console.ReadLine();
            Console.Write(" Enter Item Type (Drink,Food): ");
            string type = Console.ReadLine();
            Console.Write(" Enter Item Price: ");
            double price= double.Parse(Console.ReadLine());
            MenuItem it = new MenuItem(itemname, type, price);
            MenuItemDL.AddItemtoItemsList(it);
            return it;
        }
    }
}
