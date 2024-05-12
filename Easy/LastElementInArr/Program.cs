/* Create a function that accepts an array and returns the last item in the array. The array can contain 
 * any of C#'s primitive data types.

Examples:

GetLastItem([1, 2, 3]) ➞ 3

GetLastItem(["cat", "dog", "duck"]) ➞ "duck"

GetLastItem([true, false, true]) ➞ true

*/

using System;
class Program
{
    public static void Main(string[] args)
    {
        //reading input:
        string[] input = Console.ReadLine().Split(",");

        //printing output:
        Console.WriteLine(LastElement(input));

    }
    // method for returning the last element in the array:
    public static string LastElement(string[] input)
    {
        string last = input[input.Length - 1];
        return last;


    }

}
