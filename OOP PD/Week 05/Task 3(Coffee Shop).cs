using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string shopname;
            int count = 0;
            MenuItemDL.LoadItemDataFromFile();
            CoffeeShopDL.LoadShopDataFromFile();


            while (true)
            {
                Console.WriteLine("\t\t\t COFFEE");
                Console.WriteLine("1. Add Menu Item");
                Console.WriteLine("2. Add Coffee Shop");
                Console.WriteLine("3. View Cheapest Item");
                Console.WriteLine("4. View Drink's Menu");
                Console.WriteLine("5. View Food's Menu");
                Console.WriteLine("6. Add Order ");
                Console.WriteLine("7. Fulfill the Order ");
                Console.WriteLine("8. View the Order's List");
                Console.WriteLine("9. View Total Payable Amount ");
                Console.WriteLine("10. Exit");
                Console.Write("Enter Option Number: ");
                int option = int.Parse(Console.ReadLine());
                if (option == 1)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\t Add Menu Item\n\n");
                    if (CoffeeShopDL.Shops.Count > 0)
                    {
                        Console.Write(" Enter Coffee Shop Name: ");
                        shopname = Console.ReadLine();
                        foreach (CoffeeShop s in CoffeeShopDL.Shops)
                        {
                            if (s.ShopName == shopname)
                                s.AddMenuItem(MenuItemUI.AddItem());
                        }
                    }
                    else
                    {
                        Console.WriteLine(" No Coffee Shops Available");

                    }
                }
                else if (option == 2)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Coffee Shop\n\n");
                    CoffeeShopDL.AddCoffeeShop(CoffeeShopUI.AddShop());
                }
                else if (option == 3)
                {
                    Console.Clear();
                    Console.WriteLine("\t\t\tView Cheapest Item\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            s.ViewCheapestItem();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 4)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tView Drink's Menu\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            s.ViewDrinks();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 5)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tView Food's Menu\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            s.ViewFood();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 6)
                {
                    string order = "";
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tAdd Order\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    Console.Write(" Enter Item Name to Order: ");
                    order = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            Console.WriteLine(s.AddOrder(order));
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 7)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tFulfill Orders\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            Console.WriteLine(s.FulFillOrder());
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.Write(" No such Coffee Shop Available.");
                }
                else if (option == 8)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tView Order List\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            s.ViewOrders();
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 9)
                {
                    count = 0;
                    Console.Clear();
                    Console.WriteLine("\t\t\tCalculate Due Amount of Orders\n\n");
                    Console.Write(" Enter Coffee Shop Name: ");
                    shopname = Console.ReadLine();
                    foreach (CoffeeShop s in CoffeeShopDL.Shops)
                    {
                        if (s.ShopName == shopname)
                        {
                            Console.WriteLine($" The Total Amount Due is: {s.CalculateTotalPayableAmount()}");
                            count++;
                        }
                    }
                    if (count == 0)
                        Console.WriteLine(" No such Coffee Shop Available.");
                }
                else if (option == 10)
                {
                    
                    MenuItemDL.SaveItemDataIntoFile();
                    CoffeeShopDL.SaveShopDataIntoFile();
                    Console.Clear();
                    break;
                }
                Console.WriteLine("\n\nPress any Key to Continue...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}

