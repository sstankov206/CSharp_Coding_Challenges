/* Create a function that determines whether or not it's possible to split a pie fairly given
 * these three parameters:

Total number of slices.
Number of recipients.
How many slices each person gets

The function will be in this form:

EqualSlices(total slices, no. recipients, slices each)

Examples:

EqualSlices(11, 5, 3) ➞ false
// 5 people x 3 slices each = 15 slices > 11 slices

EqualSlices(8, 3, 2) ➞ true

EqualSlices(8, 3, 3) ➞ false

EqualSlices(24, 12, 2) ➞ true

*/

using System;

class Program
{
    static void Main(string[] args)
    {

        //reading # of total slices from input:
        int slices = int.Parse(Console.ReadLine());

        //reading # of recipients from input:
        int recipients = int.Parse(Console.ReadLine());

        //reading # of slices per recipient from input:
        int perPerson = int.Parse(Console.ReadLine());

        //printing output:
        Console.WriteLine(EqualSlices(slices, recipients, perPerson));

    }

    //creating method that calculates if a pie can be split fairly:
    public static bool EqualSlices(int slices, int recipients, int perPerson)
    {
        return (recipients * perPerson) <= slices;
    }
}
