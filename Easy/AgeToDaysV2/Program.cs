/* Create a function that takes the age in years and returns the age in days.

Examples:

CalcAge(65) ➞ 23725

CalcAge(0) ➞ 0

CalcAge(20) ➞ 7300

*/

using System;

class Program
{

    public static void Main(string[] args)
    {
        //reading input:
        int age = int.Parse(Console.ReadLine());

        //printing output:
        Console.WriteLine(AgeToDays(age));

    }

    //method for calculating the age:
    public static int AgeToDays(int age)
    {
        return age * 365;
    }
}