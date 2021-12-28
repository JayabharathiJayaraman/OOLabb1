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
            throw new NotImplementedException();
        }


        public override double GetPerimeter()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"This is a square with side length {SideLength}.";
        }

        
    }
}
