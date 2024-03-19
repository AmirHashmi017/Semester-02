using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inherited
{
    internal class MountainBike:Bicycle
    {
        private int seatheight;

        public MountainBike(int cadence,int gear,int speed,int seatheight):base(cadence,gear,speed)
        {
            this.seatheight = seatheight;
        }
        public void SetSeatHeight(int height)
        {
            this.seatheight = height;
        }
    }
}
