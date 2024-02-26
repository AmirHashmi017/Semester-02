using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_03_Coffee_Shop_
{
    internal class CoffeeShopDL
    {
        public static List<CoffeeShop> Shops = new List<CoffeeShop>();

        public static void AddCoffeeShop(CoffeeShop s)
        {
            Shops.Add(s);
        }
        public static void SaveShopDataIntoFile()
        {
            string path = "G:\\CoffeeShop.txt";
            StreamWriter Shopfile = new StreamWriter(path, false);
            foreach (CoffeeShop s in Shops)
            {
                Shopfile.Write($"{s.ShopName},");
                for (int i = 0; i < s.Menu.Count; i++)
                {
                    Shopfile.Write(s.Menu[i].Name);
                    if (i == s.Menu.Count - 1)
                        Shopfile.Write("\n");
                    else
                        Shopfile.Write(";");
                }
                Shopfile.Flush();
            }
            Shopfile.Close();
        }
        public static void LoadShopDataFromFile()
        {
            string shopname;
            string itemname;
            string record = "";
            string path = "G:\\CoffeeShop.txt";
            if (File.Exists(path))
            {
                StreamReader Shopfile = new StreamReader(path);
                while ((record = Shopfile.ReadLine()) != null)
                {
                    string[] splittedrecord = record.Split(',');
                    shopname = splittedrecord[0];
                    CoffeeShop s1 = new CoffeeShop(shopname);
                    Shops.Add(s1);
                    string[] splitteditems = splittedrecord[1].Split(';');
                    for (int i = 0; i < splitteditems.Length; i++)
                    {
                        itemname = splitteditems[i];
                        for (int x = 0; x < MenuItemDL.Items.Count; x++)
                        {
                            if (itemname == MenuItemDL.Items[x].Name)
                            {
                                MenuItem item = MenuItemDL.Items[x];
                                s1.AddMenuItem(item);
                            }
                        }
                    }
                }
                Shopfile.Close();
            }
            else
            {
                Console.Write("File Not Found");
            }
        }
    }
}
