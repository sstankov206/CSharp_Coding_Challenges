// Problem: Reverse the Array

using System;
class Program
{
    public static void Main(string[] args)
    {
        //reading input of integers, storing them in original array called "input" :
        int[] input = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();

        //printing output:
        Console.WriteLine(ReverseArr(input));
    }
    //method to reverse the array:
    public static string ReverseArr(int[] input)
    {
        Array.Reverse(input);
        return string.Join(" ", input);
    }
}
