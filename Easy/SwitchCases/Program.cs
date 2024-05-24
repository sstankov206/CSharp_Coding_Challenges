// Exercise: Switch Cases in C#

using System;
using System.Linq.Expressions;
class Program 
{
    public static void Main(string[] args)
    {
        string input = String.Empty;

        Console.WriteLine("What would you like to drink : vodka, whiskey, tequila ?");
        
        //reading input:
        input = Console.ReadLine();
        switch (input)
        {
            case "whiskey" :
                Console.WriteLine("Here's a shot of whiskey. Cheers!");
                break;
            case "vodka":
                Console.WriteLine("He's a shot of vodka. Cheers!");
                break;
            case "tequila":
                Console.WriteLine("Here's a shot of tequila. Cheers!");
                break;
            default:
                Console.WriteLine("Perhaps something non-alcoholic?");
                break;
        }
    }
}