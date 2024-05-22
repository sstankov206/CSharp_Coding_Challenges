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
    public static string ReverseArr(int[] theArray)
    {
        int tempHolder = 0;

        if (theArray.Length > 0)
        {
            for (int i = 0; i < (theArray.Length / 2); i++)
            {
                tempHolder = theArray[i];
                theArray[i] = theArray[theArray.Length - i - 1];
                theArray[theArray.Length - i - 1] = tempHolder;
            }
        }
        else
        {
            Console.WriteLine("Nothing to reverse");
        }
        return string.Join(" ", theArray);
    }
}
