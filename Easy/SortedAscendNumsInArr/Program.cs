/* Create a function that takes an array of numbers and returns a new array, 
 * sorted in ascending order (smallest to biggest).

Sort the numbers array in ascending order.
If the function's argument is null, an empty array, or undefined; return an empty array.
Return a new array of sorted numbers.

Examples: 

SortNumsAscending([1, 2, 10, 50, 5]) ➞ [1, 2, 5, 10, 50]

SortNumsAscending([80, 29, 4, -95, -24, 85]) ➞ [-95, -24, 4, 29, 80, 85]

SortNumsAscending(null) ➞ []

SortNumsAscending([]) ➞ []

*/

using System;
using System.Linq;

class Program
{
    public static void Main(string[] arg)
    {
        //reading input & storing in array;
        int[] input = Console.ReadLine().Split(",").Select(int.Parse).ToArray();

        //printing output:
        foreach (int index in input)
        {
            Console.WriteLine(SortedNumsAscending(input));
        }
    }

    //method for sorting the array of numbers in ascending order, and returning the output:
    public static int[] SortedNumsAscending(int[] input)
    { 
        //logic check for empty or null input array:
        if (input == null || input.Length == 0)
        {
            int[] emptyArray = new int[] { };
            return emptyArray;
        }
        else
        //sort by ascending order:
        {
            Array.Sort<int>(input);
            int[] sortedArray = input;
            return sortedArray;
        }
    }
}
