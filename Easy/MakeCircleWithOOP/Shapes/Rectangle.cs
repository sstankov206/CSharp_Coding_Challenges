namespace MakeCircleWithOOP.Shapes
{
    public class Rectangle : Shape
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        public Rectangle(double sideA, double sideB)
        {
            this.SideA = sideA;
            this.SideB = sideB;
        }

        public override double GetArea()
        => this.SideA * this.SideB;

        public override double GetPerimeter()
         => 2 * (this.SideA + this.SideB);

        public override double GetNestedShapePerimeter(double sideDiff)
         => 2 * (this.SideA - sideDiff + this.SideB - sideDiff);
    }
}
