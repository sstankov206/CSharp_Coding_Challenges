namespace MakeCircleWithOOP.Shapes
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract double GetPerimeter();
        public abstract double GetNestedShapePerimeter(double sideDiff);
    }
}
