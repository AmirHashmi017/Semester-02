using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Cylinder:Circle
    {
        private double Height;

        public Cylinder():base()
        {

        }
        public Cylinder(double radius, double height) : base(radius)
        {
            this.Height = height;
        }
        public Cylinder(double radius,double height, string color):base(radius, color)
        {
           this.Height = height;
        }
        public double GetHeight()
        {
            return this.Height;
        }
        public void SetHeight(double Height)
        { this.Height = Height; }
        public double GetVolume()
        {
            double volume = 3*3.14 * (Radius * Radius);
            return volume;
        }
    }
}
