using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherited
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MountainBike bike1 = new MountainBike(32, 1, 250, 23);
            bike1.ShowAllInfo();
            bike1.SpeedUp(450);
            bike1.ApplyBrake(70);
            bike1.SetGear(4);
            bike1.SetCadence(70);
            bike1.ShowAllInfo();
            Console.ReadKey();
        }
    }
}
