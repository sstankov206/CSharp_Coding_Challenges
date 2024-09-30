using System;

namespace ShapeDrawingApplication.Models
{
    public class Circle : Shape, IScalable
    {
        public double Radius { get; private set; }

        public Circle(double radius, string color) : base(color)
        {
            Radius = radius;
        }

        public override void Draw()
        {
            Console.WriteLine($"Drawing a {Color} circle with radius {Radius}");
        }

        public void Scale(double factor)
        {
            Radius *= factor;
        }

    }
}
