// Practice: Remove even numbers from a list of numbers, using LINQ arguments.

using System;
class Program 
{
    static void Main(string[] args)
    {
        //list of numbers:
        List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 3, 9, 0 };

       //new list that stores odd numbers:
        List<int> oddNumbers =  numbers.Where(number => number % 2 == 1).ToList();

        //printing output:
        Console.WriteLine(string.Join(" ", oddNumbers));

    }
}