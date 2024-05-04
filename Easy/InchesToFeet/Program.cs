/* Create a function that accepts a measurement value in inches and returns the equivalent of 
 * the measurement value in feet.

Examples:

inchesToFeet(324) ➞ 27

inchesToFeet(12) ➞ 1

inchesToFeet(36) ➞ 3

Notes:
If inches are under 12, return 0.
12 inches = 1 foot.

*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        //reading input:
        int input = int.Parse(Console.ReadLine());

        //printing output:
        Console.WriteLine(inchesToFeet(input));
    }

    //creating method that converts inches to feet:
    public static int inchesToFeet(int input)
    {
        if (input < 12)
        {
            return 0;
        }
        return input / 12;
    }
}