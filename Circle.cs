using System;

namespace SOLID_Principles
{
class Circle : Shape
    {
        public double Radius { get; set; }
        public override double Area()
        {
            return Radius*Radius*Math.PI;
        }

        public Circle(double radius)
        {
            this.Radius = radius;
        }

    }
}