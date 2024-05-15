using System;
class Program
{
    public static void Main(string[] args)
    {//reading input:
        string input = Console.ReadLine();

        //printing output:
        Console.WriteLine(Reverse(input));
    }

    //method to reverse the string:
    public static string Reverse(string input)
    {
        char[] charArray = input.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}
