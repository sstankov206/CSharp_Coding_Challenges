/* Create a function that takes a name and returns a greeting in the form of a string.

Examples
HelloName("Gerald") ➞ "Hello Gerald!"

HelloName("Tiffany") ➞ "Hello Tiffany!"

HelloName("Ed") ➞ "Hello Ed!"

*/

using System;

class Program
{

    public static void Main(string[] args)
    {
       //reading input:
       string name = Console.ReadLine();

        //printing output:
        Console.WriteLine(NameGreeting(name));
    }

    //creating method that creates the greeting:
    public static string NameGreeting(string name) {
        return ($"Hello " + name + "!");
    
    }
}


