/* Create a function that takes the age in years and returns the age in days.

Examples:

CalcAge(65) ➞ 23725

CalcAge(0) ➞ 0

CalcAge(20) ➞ 7300

*/

using System;

class Program {

    public static void Main(string[] args) {

        int year = 365;
        //reading input:
        int age = int.Parse(Console.ReadLine());
        int ageConverted = age * year;
        //printing output:
        Console.WriteLine(ageConverted);


    }


}