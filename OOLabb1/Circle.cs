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
            throw new NotImplementedException();
        }

        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"This is a circle with radius {Radius}.";
        }
    }
}
