using System;
namespace OOLabb1
{
    public class Circle : Shape
    {

        public double Radius { get; set; }
        

        public Circle(double radius)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Radius * Radius;
        }

        public override double GetPerimeter()
        {
            return 2 * Math.PI * Radius;
        }

        public override string ToString()
        {
            return $"This is a circle with radius {Radius}. The area is {GetArea()} and the perimeter is {GetPerimeter()}";
        }
    }
}
