/* Find the Perimeter of a Rectangle:
 * 
Create a function that takes length and width and finds the perimeter of a rectangle.

Examples:

FindPerimeter(6, 7) ➞ 26

FindPerimeter(20, 10) ➞ 60

FindPerimeter(2, 9) ➞ 22

*/

using System;

class Program
{


    public static void Main(string[] args)
    {

        //prompting user to enter width:
        Console.WriteLine("Enter width: ");
        int width = int.Parse(Console.ReadLine());
        //prommpting user to enter length:
        Console.WriteLine("Enter length: ");
        int length = int.Parse(Console.ReadLine());

        //printing output:
        Console.Write("Perimeter of rectangle is: ");
        Console.WriteLine(PerimeterFind(width, length));

    }

    //method for finding perimeter of rectangle:
    public static int PerimeterFind(int width, int length)
    {

        return (2 * (width + length));
    }
}
