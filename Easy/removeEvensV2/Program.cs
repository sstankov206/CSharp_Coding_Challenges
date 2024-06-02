// Practice: Remove even numbers from a list of numbers, using LINQ arguments.

using System;
class Program
{
    static void Main(string[] args)
    {
        //list of numbers:
        List<int> numbers = Console.ReadLine().Split(" ")
            .Select(int.Parse)
            .ToList();

        //new list that stores odd numbers:
        List<int> oddNumbers = numbers.Where(number => number % 2 == 1).ToList();

        //printing output:
        Console.WriteLine(string.Join(" ", oddNumbers));

    }
}
