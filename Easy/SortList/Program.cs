// Practice: Sorting a List in C#

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers, separated by space:");

        //reading input from user:             Ex: 5 3 8 10
        var input = Console.ReadLine().
            Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        //sorting the list:                   Ex: 3 5 8 10
        input.Sort();

        //printing output:
        Console.WriteLine(String.Join(" ", input));

    }
}