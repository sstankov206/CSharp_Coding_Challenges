/* Challenge: DIVIDES EVENLY
 * 
 * Given two integers, a and b, return true if a can be divided evenly by b. Return false otherwise.

Examples:

dividesEvenly(98, 7) ➞ true
// 98/7 = 14

dividesEvenly(85, 4) ➞ false
// 85/4 = 21.25

Notes:
a will always be greater than or equal to b.

*/

using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        //reading input:
        int inputA = int.Parse(Console.ReadLine());
        int inputB = int.Parse(Console.ReadLine());
        int inputC = 0;

        //logic check if a is greater than b :
        if (inputA < inputB)
        {
            inputC = inputA;
            inputA = inputB;
            Console.WriteLine(DivedesEvently(inputC, inputA));
        }
        else
        //printing output:
        {
            Console.WriteLine(DivedesEvently(inputA, inputB));
        }
    }

    //method for calulcation and checking for remainder:
    public static bool DivedesEvently(int inputA, int inputB)
    {
        if (inputA % inputB == 0)

            return true;
        else
        {
            return false;
        }
    }





}
