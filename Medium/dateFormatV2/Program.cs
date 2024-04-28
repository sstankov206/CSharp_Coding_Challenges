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
        //reading input:
        string dateEntered = Console.ReadLine();
        string dateFormatted = DateTime
            .ParseExact(dateEntered, "MM/dd/yyyy", null)
            .ToString("yyyyddMM");
        

        //printing output:
        Console.WriteLine($"The entered date in YYYYDDMM format is: {dateFormatted}");

      

    }

}
