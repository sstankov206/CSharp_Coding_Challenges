using System;
using System.ComponentModel.Design;
class Program
{
    static void Main(string[] args)
    {
        //getting input from user:
        string input = Console.ReadLine().ToLower(); //ex: rock

        Random randomizer = new Random();
        //generating cpu's pick:
        int cpu = randomizer.Next(0, 4);
        string cpuPick = string.Empty; //stores the cpu pick

        switch (cpu)
        {
            case 1:
                cpuPick = "rock";
                break;
            case 2:
                cpuPick = "paper";
                break;
            case 3:
                cpuPick = "scissors";
                break;
        }

        //conditions & output:
        if (input == cpuPick)
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("It's a tie!");
        }
        else if (input == "rock" && cpuPick == "scissors")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You WIN!");
        }
        else if (input == "rock" && cpuPick == "paper")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You Lose.");
        }
        else if (input == "paper" && cpuPick == "scissors")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You Lose.");
        }
        else if (input == "paper" && cpuPick == "rock")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You WIN!");
        }
        else if (input == "scissors" && cpuPick == "rock")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You Lose.");
        }
        else if (input == "scissors" && cpuPick == "paper")
        {
            Console.WriteLine($"I pick: {cpuPick}!");
            Console.WriteLine("You WIN!");
        }
    }
}
