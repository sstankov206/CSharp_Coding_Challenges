/* You are counting points for a basketball game, given the amount of 3-pointers scored
 * and 2-pointers scored, find the final points for the team and return that value
 * ([2 -pointers scored, 3-pointers scored]).
 * 
 * Examples:
 * 
 * points(1, 1) ➞ 5
 * points(7, 5) ➞ 29
 * points(38, 8) ➞ 100
 * 
 * Solution by me, sstankov.
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter points in the following format:\n# of two pointers:\n# of three pointers:");
        int twoPointers = int.Parse(Console.ReadLine());
        int threePointers = int.Parse(Console.ReadLine());
        Console.WriteLine(Points(twoPointers, threePointers)); //printing output
     
    }

    //creating a method to calculate the points:
    public static int Points(int twoPointers, int threePointers)
    {
        return (twoPointers * 2) + (threePointers * 3);
    }
}
