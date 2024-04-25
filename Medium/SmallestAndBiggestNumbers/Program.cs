/* Create a function that takes an array of numbers and return both the minimum
 * and maximum numbers, in that order.
 * 
 * Examples:
 * 
 * FindMinMax([7, 2, 3, 4, 5]) ➞ [1, 5]

FindMinMax([2334454, 5]) ➞ [5, 2334454]

FindMinMax([5]) ➞ [1, 1]

*/

using System;
using System.Linq;

class Program
{
    public static void Main(string[] args)
    {
        int[][] matrix = new int[][] {

           new int [] { 8, 2, 3, 4, 5 },
           new int [] { 2334454, 5 },
           new int [] { 5 },

        };

        foreach (var arr in matrix)
        {
            //Console.WriteLine("Min & Max of Array");
            FindMinAndMaxNums(arr);
            //Console.WriteLine("Result from recursion");
            //Recursion(0, arr);
            //int index = 0;
            //while (index < arr.Length)
            //{
            //    Console.WriteLine($"Element of arr {arr[index]}");

            //    index++;
            //}
            Console.WriteLine();
        }
    }

    private static void FindMinAndMaxNums(int[] input)
    {

        int[] result = new int[2];
        result[0] = input.Min();
        result[1] = input.Max();
        //prints output:

        int min = int.MaxValue;
        int max = int.MinValue;

        foreach (var currentNum in input)
        {
            if (currentNum < min)
            {
                min = currentNum;
            }
            if (currentNum > max)
            {
                max = currentNum;
            }
        }

        int[] orderdResult = result.OrderBy(x => x).ToArray();

        string arrContent = string.Join(", ", orderdResult);
        Console.WriteLine($"[{arrContent}]");
        Console.Write("[");
        Console.Write(min);
        Console.Write(", ");
        Console.Write(max);
        Console.WriteLine("]");
    }

    //creates the method called "GetMinMax" which returns the smallest and biggest numbers from the input:
    public static void Recursion(int index, int[] value)
    {
        if (index >= value.Length) { return; }
        Console.WriteLine("Iteration Number: " + (index + 1));
        Console.WriteLine($"Element of arr {value[index]}");

        index++;
        Recursion(index, value);
    }
}
