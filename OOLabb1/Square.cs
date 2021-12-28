using System;
namespace OOLabb1
{
    public class Square : Shape
    {
       
        public int SideLength { get; set; }

        public Square(int sideLength)
        {
            SideLength = sideLength;
        }

        public override double GetArea()
        {
            return SideLength * SideLength;
        }


        public override double GetPerimeter()
        {
            return 4 * SideLength;
        }

        public override string ToString()
        {
            return $"This is a square with side length {SideLength}, area {GetArea()} and perimeter length {GetPerimeter()}.";
        }

        
    }
}
