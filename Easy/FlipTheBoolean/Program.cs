/* Create a function that reverses a boolean value.

Examples:

Reverse(true) ➞ false

Reverse(false) ➞ true

*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter true or false :");
        string word = Console.ReadLine();
        bool myBool = bool.Parse(word); // converting the string to Boolean
        
        //printing output:
        Console.WriteLine(Reverse(myBool));
    }

    //Method to Reverse the Boolean:
    public static bool Reverse(bool myBool)
    {
        if (true)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}

