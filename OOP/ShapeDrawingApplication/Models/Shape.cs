using System;
namespace ShapeDrawingApplication.Models
{
    public abstract class Shape
    {
        public string Color { get; set; }

        protected Shape(string color)
        {
            Color = color;
        }

        public abstract void Draw();

    }
}
