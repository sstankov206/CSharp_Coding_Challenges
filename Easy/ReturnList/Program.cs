// Practice: Returning a List in C#

using System;
using System.Reflection.Metadata.Ecma335;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter text, seprated by space:");

        //reading input from user:
        var input = Console.ReadLine().
            Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .ToList();

        //printing output:
        Console.WriteLine(ReturnList(input));


    }

    //method that returns a list:
    public static string ReturnList(List<string> input)
    {
        List<string> list = new List<string>();
        return String.Join(" ", input);
    }


 

}
