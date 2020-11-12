using System;

namespace SOLID_Principles
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
        public override double Area()
        {
            return Width*Height;
        }

        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
    }
}