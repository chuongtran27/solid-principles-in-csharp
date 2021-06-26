using System;

namespace SolidPrinciples.LiskovSubstitution.Bad
{
    class Rectangle
    {
        protected double Width = 0;
        protected double Height = 0;

        public void SetWidth(double width)
        {
            Width = width;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public double GetArea()
        {
            return Width * Height;
        }
    }

    class Square : Rectangle
    {
        public void SetWidth(double width)
        {
            Width = Height = width;
        }

        public void SetHeight(double height)
        {
            Width = Height = height;
        }
    }

    internal class Program
    {
        public static void Execute()
        {
            var rectangle = new Rectangle();
            rectangle.SetWidth(4);
            rectangle.SetHeight(5); 
            Console.WriteLine("Area of rectangle is {0}", rectangle.GetArea());
            
            var square = new Square();
            square.SetWidth(4);
            square.SetHeight(5); // (Bad) Change height also change width. Not consistent.
            Console.WriteLine("Area of square is {0}", square.GetArea());
        }
    }
}