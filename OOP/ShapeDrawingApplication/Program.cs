/* Requirements: 
 * 1. Create an Abstract class Shape with the follwing:
 * - A property Color (string)
 * - An Abstract method Draw()
 * 2. Create an interface IScalable with the following:
 * - A method Scale (double factor).
 * 3. Create two classes that inherit from Shape:
 * - Circle:
 *  -- constructor that takes radius and color.
 *  -- Override the Draw() method to display the circle's information.
 *  -- Impelement the IScalable interface to show scaling the circle's radius.
 *  - Rectangle:
 *  -- Constructor that takes width height and color
 *  -- Override the Draw() method to display the rectangle's information.
 *  -- Implement the IScalable interface to allow scaling the rectangle's dimensions.
 *  4. In the Main method, create instances of Circle and Rectangle, call their Draw() methods, and demonstrate scaling.
 */

using System;
using ShapeDrawingApplication.Models;

class Program
{
    static void Main(string[] args)
    {
        Shape circle = new Circle(5.0, "red");
        Shape rectangle = new Rectangle(4.0, 3.0, "blue");

        circle.Draw();
        rectangle.Draw();

        //Scale the shapes:

        if (circle is IScalable scalableCircle)
        {
            scalableCircle.Scale(2);
        }

        if (rectangle is IScalable scalableRectangle)
        {
            scalableRectangle.Scale(1.5);
        }

        //Draw again after scaling:
        circle.Draw();
        rectangle.Draw();
    }
}

