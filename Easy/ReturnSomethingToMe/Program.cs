/* Write a function that returns the string "something" joined with a space " " and the given argument "a".

Examples:

GiveMeSomething("is better than nothing") ➞ "something is better than nothing"

GiveMeSomething("Bob Jane") ➞ "something Bob Jane"

GiveMeSomething("something") ➞ "something something"

*/

using System;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Please enter some text here:");
        string a = Console.ReadLine();

        //printing output:
        Console.WriteLine(A(a));
    }

    //Method for the returning of the argument 'a' :
    public static string A(string a)
    { return ("something" +  " " + a);
    }
}
 
