/*Write a function that takes the base and height of a triangle and return its area.
 * The area of a triangle is: (base * height) / 2
 * Don't forget to return the result.
 */

using System;

class Program
{
	static void Main(string[] args)
	{
        Console.WriteLine("Please enter integer for the triangle's BASE:"); 
		int b = int.Parse(Console.ReadLine());
		Console.WriteLine("Please enter integer for the triangle's HEIGHT:");
		int h = int.Parse(Console.ReadLine());
        //printing the Triangle's area:
        Console.WriteLine(triArea(b, h));

	}
	//method for calculating the Triangle's Area:
	public static int triArea(int b, int h)
	{
		return (b * h) / 2;
	}
}