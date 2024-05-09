namespace MakeCircleWithOOP.Shapes
{
    public class Square : Shape
    {
        private double Side { get; set; }
        public Square(double side)
        {
            this.Side = side;
        }

        public override double GetArea()
      => this.Side * this.Side;

        public override double GetPerimeter()
       => 4 * this.Side;

        public override double GetNestedShapePerimeter(double sideDiff)
        => 4 * (this.Side - sideDiff);
    }
}
