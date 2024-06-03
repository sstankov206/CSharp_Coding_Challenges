// Practice: Remove odd numbers from a list of numbers, using LINQ arguments.

using System;
class Program
{
    static void Main(string[] args)
    {
        //list of numbers:
        List<int> numbers = Console.ReadLine().Split(" ")
            .Select(int.Parse)
            .ToList();

        //new list that stores even numbers:
        List<int> evenNumbers = numbers.Where(number => number % 2 == 0).ToList();

        //printing output:
        Console.WriteLine(string.Join(" ", evenNumbers));

    }
}