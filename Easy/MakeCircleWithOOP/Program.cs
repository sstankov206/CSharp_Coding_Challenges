using MakeCircleWithOOP.Shapes;
using System;

class Program
{
    public static void Main(string[] args)
    {

        Shape[] shapesArr = new Shape[3] { new Circle(11), new Rectangle(4, 3), new Square(4) };
        Shape[] emptyShapesArr = new Shape[3];
        emptyShapesArr[0] = new Circle(11);
        emptyShapesArr[1] = new Rectangle(4, 3);
        emptyShapesArr[2] = new Square(4);
        emptyShapesArr[0] = new Square(4);

        List<Shape> shapes = new List<Shape>() { new Circle(11), new Rectangle(4, 3), new Square(4) };
        Console.WriteLine("Shapes LINQ.ForEach");
        shapes.ForEach(shape =>
        {
            Console.WriteLine("Shape Type: " + shape.GetType().Name);
            Console.WriteLine("Shape Area: " + shape.GetArea());
            Console.WriteLine("Shape Perimeter:" + shape.GetPerimeter());
            Console.WriteLine("Nested Shape Perimeter:" + shape.GetNestedShapePerimeter(2));
        });
        return;

        Console.WriteLine("Shapes For Loop");
        for (int i = 0; i < shapes.Count; i++)
        {
            Console.WriteLine(shapes[i].GetArea());
            Console.WriteLine(shapes[i].GetPerimeter());
        }

        Console.WriteLine("Shapes ForEach loop");
        foreach (Shape shape in shapes)
        {
            Console.WriteLine(shape.GetArea());
            Console.WriteLine(shape.GetPerimeter());
        }


        List<Shape> emptyShapes = new List<Shape>();
        emptyShapes.Add(new Circle(5));
        emptyShapes.Add(new Rectangle(5, 7));
        emptyShapes.Add(new Square(9));


    }
}

