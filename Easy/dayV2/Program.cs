using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Type a number 1 - 7:");
        int input = int.Parse(Console.ReadLine());
        string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
        Console.WriteLine($"It's {days[input - 1]}");
    }
}