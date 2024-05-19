using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        //reading input:
        string[] input = Console.ReadLine().Split(",");

        //printing output:
        Console.WriteLine(GetFirstElement(input));
    }

    //method for returning the first element from the array:
    public static string GetFirstElement(string[] input)
    {
        return input[0];
    }
}