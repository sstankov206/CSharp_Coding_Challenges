// Practice: Create a turn-based battle game between user (hero) and cpu (monster) using a do-while loop:

using System;
class Program 
{
    public static void Main(string[] args)
    {
        int hero = 10;
        int monster = 10;

        Random dice = new Random();

        do
        {
            int roll = dice.Next(1, 11);
            monster -= roll;
            Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

            if (monster <= 0) continue;

            roll = dice.Next(1, 11);
            hero -= roll;
            Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

        } while (hero > 0 && monster > 0);

        Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");
    }
}