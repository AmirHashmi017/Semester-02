using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherited
{
    internal class Bicycle
    {
        protected int cadence;
        protected int gear;
        protected int speed;

        public Bicycle(int cadence, int gear, int speed)
        {
            this.cadence = cadence;
            this.gear = gear;
            this.speed = speed;
        } 
        public void SetCadence(int cadence)
            { this.cadence = cadence; }
        public void SetGear(int gear)
        {
            this.gear = gear;
        }
        public void ApplyBrake(int decrement)
        {
            speed -= decrement;
        }
        public void SpeedUp(int increment)
        {
            speed += increment;
        }
        public void ShowAllInfo()
        {
            Console.WriteLine("Cadence:"+cadence);
            Console.WriteLine("Gear: "+gear);
            Console.WriteLine("Speed: "+ speed);
        }
    }
}
