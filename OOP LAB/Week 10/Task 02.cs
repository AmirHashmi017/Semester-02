using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cylinder c1 = new Cylinder(10,20,"Red");
            Cylinder c2 = new Cylinder(25, 39, "Blue");
            Console.WriteLine(c1.To_String());
            Console.WriteLine("Volume is: {0}", c1.GetVolume());
            Console.WriteLine(c2.To_String());
            Console.ReadKey();
        }
    }
}
