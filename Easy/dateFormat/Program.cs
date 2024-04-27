/* Create a function that converts a date formatted as MM/DD/YYYY to YYYYDDMM.

Examples:

FormatDate("11/12/2019") ➞ "20191211"

FormatDate("12/31/2019") ➞ "20193112"

FormatDate("01/15/2019") ➞ "20191501"

*/

using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {

        //prompting user input:
        Console.WriteLine("Please enter a date in MM/DD/YYYY format, including dashes (/) :");
        //reading input, storing in an array of integers:
        int[] dateEntered = Console.ReadLine()
            .Split("/")
            .Select(int.Parse)
            .ToArray();

        //check for valid format:
        if (dateEntered.Length != 3)
        {
            Console.WriteLine("Invalid date format entered.");
        }

        int month = dateEntered[0]; //month
        int day = dateEntered[1]; //day
        int year = dateEntered[2]; //year

        //printing output:
        Console.WriteLine("The entered date in YYYYDDMM format is: ");
     
        Console.Write(String.Format("{0:D4}", year));
        Console.Write(String.Format("{0:D2}", day));
        Console.Write(String.Format("{0:D2}", month));

    }

}

