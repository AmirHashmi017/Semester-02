using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class CoffeeShop
    {
        public string ShopName;
        public List<MenuItem> Orders = new List<MenuItem>();
        public List<MenuItem> Menu = new List<MenuItem>();

        public CoffeeShop(string shopname)
        {
            this.ShopName = shopname;
        }
        public void AddMenuItem(MenuItem item)
        {
            Menu.Add(item);
        }
        public void ViewCheapestItem()
        {
        List<MenuItem> CheapItems = new List<MenuItem>();
        CheapItems=Menu.OrderBy(o=>o.Price).ToList();
        Console.WriteLine($" Cheapest Item Name: {CheapItems[0].Name}");
		Console.WriteLine($" Cheapest Item Type: {CheapItems[0].Type}");
            Console.WriteLine($" Cheapest Item Price: {CheapItems[0].Price}");
            }
    public void ViewDrinks()
    {
        Console.WriteLine(" \nItem Name \t \t Type \t \t Price");
        foreach (MenuItem m in Menu)
        {
            if (m.Type == "Drink" || m.Type == "drink")
                Console.WriteLine($"{m.Name} \t\t \t {m.Type} \t \t {m.Price}");
        }
    }
    public void ViewFood()
    {
        Console.WriteLine(" \nItem Name \t \t Type \t \t Price");
        foreach (MenuItem m in Menu)
        {
            if (m.Type == "Food" || m.Type == "food")
                Console.WriteLine($"{m.Name} \t\t \t {m.Type} \t \t {m.Price}");
        }
    }
    public string AddOrder(string itemname)
    {
        foreach (MenuItem m in Menu)
        {
            if (m.Name == itemname)
            {
                Orders.Add(m);
                return " Order Added!!";
            }
           
        }
            return " This Item is currently Unavailable!!";
        }
    public void ViewOrders()
    {
        Console.WriteLine("\n Ordered Item Name \t \t Type \t \t Price");
        foreach (MenuItem m in Orders)
        {
            Console.WriteLine($"{m.Name} \t\t\t \t {m.Type} \t \t {m.Price}");
        }
    }
    public string FulFillOrder()
    {
        if (Orders.Count > 0)
        {
                string name = Orders[0].Name;
                Orders.RemoveAt(0);
                return ($" The {name} is Ready!!");
            
        }
        else
            return (" All Orders have been Fullfilled.");
    }
    public double CalculateTotalPayableAmount()
    {
        double total = 0;
        foreach (MenuItem m in Orders)
        {
            total += m.Price;
        }
        return total;
    }
}
}
