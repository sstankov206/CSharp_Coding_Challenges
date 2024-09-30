using System;

namespace ShapeDrawingApplication.Models
{
    public class Rectangle : Shape, IScalable
    {
        public double Width { get; private set; }
        public double Height { get; private set; }

        public Rectangle(double width, double height, string color) : base(color)
        {
            Width = width;
            Height = height;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} rectangle with width {Width} and height {Height}");

        }

        public void Scale(double factor)
        {
            Width *= factor;
            Height *= factor;
        }
    }
}
