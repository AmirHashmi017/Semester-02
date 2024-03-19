using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    internal class Circle
    {
        protected double Radius;
        protected string Color;

        public Circle()
        {

        }
        public Circle(double radius)
        {
            this.Radius = radius;
        }
        public Circle(double radius, string color)
        {
            this.Radius = radius;
            this.Color = color;
        }   
        public double GetRadius()
        {
            return this.Radius;
        }
        public void SetRadius(double radius)
        { this.Radius = radius; }
        public string GetColor()
        {
            return this.Color;
        }
        public void SetColor(string color)
        { this.Color = color; }
        public double GetArea()
        {
            double area = 3.14*(Radius*Radius);
            return area;
        }
        public string To_String()
        {
            return($" Circle \tRadius: {Radius} \t Color: {Color}");
        }
    }
}
