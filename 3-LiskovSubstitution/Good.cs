using System;

namespace SolidPrinciples.LiskovSubstitution.Good
{
    abstract class ShapeBase
    {
        protected double Width = 0;
        protected double Height = 0;

        public abstract double GetArea();
    }
    
    class Rectangle: ShapeBase
    {
        public void SetWidth(double width)
        {
            Width = width;
        }

        public void SetHeight(double height)
        {
            Height = height;
        }

        public override double GetArea()
        {
            return Width * Height;
        }
    }

    class Square : ShapeBase
    {
        public void SetLength(double length)
        {
            Width = Height = length;
        }

        public override double GetArea()
        {
            return Math.Pow(Width, 2);
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
            square.SetLength(4); // (Good) Only set length for square
            Console.WriteLine("Area of square is {0}", square.GetArea());
        }
    }

}