using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeCircleWithOOP.Shapes
{
    public class Circle : Shape
    {
        private double Radius { get; set; }
        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            var area = Math.PI * Radius * Radius;
            return area;
        }
        public override double GetPerimeter()
        {
            var perimeter = 2 * Math.PI * Radius;
            return perimeter;
        }

        public override double GetNestedShapePerimeter(double sideDiff)
        {
            var perimeter = 2 * Math.PI * (Radius - sideDiff);
            return perimeter;
        }
    }
}
