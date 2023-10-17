/* Usually when you sign up for an account to buy something, your credit card number, phone number or answer to a secret question is partially obscured in some way. Since someone could look
 * over your shoulder, you don't want that shown on your screen. Hence, the website masks these strings.

Your task is to create a function that takes a string, transforms all but the last four characters into "#" and returns the new masked string.

Examples:

Maskify("4556364607935616") ➞ "############5616"

Maskify("64607935616") ➞ "#######5616"

Maskify("1") ➞ "1"

Maskify("") ➞ ""

*/

using System;
using System.Linq;
using System.Text;

class Program {
    public static void Main(string[] args) {

    string str = Console.ReadLine(); //reading input
        Console.Write(Maskify(str)); //invoking the Masking method and passing the input through it
    }

    //creating a method that masks the individual characters of the input:
    public static string Maskify(string str)
    {
        char[] chars = str.ToCharArray(); //converts the input to an array of characters

        for (int i = 0; i < chars.Length - 4; i++)
        {
            chars[i] = '#'; // masks each character of the input as a "#" until the last 4 characters of the char array are reached
        }

        return new string(chars); //prints output as a new string
    }



}







