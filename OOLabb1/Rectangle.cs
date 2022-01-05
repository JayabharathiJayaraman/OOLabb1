using System;
namespace OOLabb1
{
    public class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }
  

        public Rectangle(double height, double width)
        {
            Width = height;
            Height = width;
        }

        public Rectangle(int rectangleWithEqualSides)
        {
            Height = rectangleWithEqualSides;
            Width = rectangleWithEqualSides;

        }

        public override double GetArea()
        {
            return Width * Height;
        }

        public override double GetPerimeter()
        {
            return 2 * (Width + Height );
        }

        public override string ToString()
        {
            return $"This is a rectangle with height {Height} and width {Width}. Area is {GetArea()} and Perimeter is {GetPerimeter()}";
        }
    }
}