// Practice: Clearing a List in C#


using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter numbers, separated by space:");
        
        //reading input from user:             Ex: 5 3 8 10
        var input = Console.ReadLine().
            Split(new char[] { ' ', ',' },
            StringSplitOptions.RemoveEmptyEntries)
            .Select(int.Parse)
            .ToList();

        Console.WriteLine("Type CLEAR to erase the list. Type EXIT to close.");
        string command = Console.ReadLine().ToLower();

        //conditions for clearing the list:                  

        if (command == "clear")
        {
            input.Clear();
            Console.WriteLine("The list has been cleared.");
        }
        else if (command == "exit")
        {
            Console.WriteLine("Exiting the program, here is the output of your list: ");
        }

        //printing output:
        Console.WriteLine(String.Join(" ", input));
        Console.WriteLine("Have a nice day!");

    }
}