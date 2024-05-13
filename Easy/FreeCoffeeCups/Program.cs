/* For each of the 6 coffee cups I buy, I get a 7th cup free. In total, I get 7 cups.
 Create a function that takes n cups bought and return as an integer the total number of cups I would get.

Examples:

totalCups(6) ➞ 7

totalCups(12) ➞ 14

totalCups(213) ➞ 248

Notes:

Number of cups I bought + number of cups I got for free.
Only valid inputs will be given.
*/

using System;
using System.Linq;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter # of purchased cups of coffee: ");
        //reading input:
        int input = int.Parse(Console.ReadLine());
        
        //printing output:
        Console.WriteLine($"You receive a total of {GetTotalCups(input)} cups of coffee.");
    }

    //method for calculating the total number of cups the user will receive:
    public static double GetTotalCups(int input)
    {
        var totalCups = Math.Floor(input / 6d);
        totalCups += input;

        return totalCups;
    }
}
