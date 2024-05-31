// Practice: Remove odd numbers from a list of numbers, using LINQ arguments.

using System;
class Program
{
    static void Main(string[] args)
    {
        //list of numbers:
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 3, 9 };

        //new list that stores even numbers:
        List<int> evenNumbers = numbers.Where(number => number % 2 == 0).ToList();

        //printing output:
        Console.WriteLine(string.Join(" ", evenNumbers));

    }
}