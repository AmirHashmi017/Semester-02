using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_03_Coffee_Shop_
{
    internal class MenuItemDL
    {
        public static List<MenuItem>Items=new List<MenuItem>();
	
	public static void AddItemtoItemsList(MenuItem item)
        {
            Items.Add(item);
        }
        public static void SaveItemDataIntoFile()
        {
            string path = "G:\\ItemsFile.txt";
            StreamWriter Itemfile = new StreamWriter(path, false);
            foreach (MenuItem it in MenuItemDL.Items)
            {
                Itemfile.WriteLine($"{it.Name},{it.Type},{it.Price}");
                Itemfile.Flush();
            }
            Itemfile.Close();
        }
        public static void LoadItemDataFromFile()
        {
            string record;
            string path = "G:\\ItemsFile.txt";
            if (File.Exists(path))
            {
                StreamReader Itemfile = new StreamReader(path);
                while ((record = Itemfile.ReadLine()) != null)
                {
                    string[] data = record.Split(',');
                    string name = data[0];
                    string type = data[1];
                    double price = double.Parse(data[2]);
                    MenuItem i = new MenuItem(name, type, price);
                    Items.Add(i);
                }
                Itemfile.Close();
            }
            else { Console.WriteLine("File Not Found"); }
        }
    }
}
