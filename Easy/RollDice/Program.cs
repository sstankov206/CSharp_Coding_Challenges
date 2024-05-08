using System;

class Program { 
public static void Main(string[] args) {
        Random dice = new Random();

        int roll1 = dice.Next(1, 7);
        int roll2 = dice.Next(1, 7);
        int roll3 = dice.Next(1, 7);

        //sum of rolling the dice 3 times
        int total = roll1 + roll2 + roll3;

        //condition that checks for a double roll (2 of the same):
        if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
        {
            Console.WriteLine("You rolled doubles! +2 bonus to total!");
            total += 2;
        }

        //condition that checks for a triple roll (3 of the same):
        if ((roll1 == roll2) && (roll2 == roll3))
        {
            Console.WriteLine("You rolled triples! +6 bonus to total!");
            total += 6;
        }

        //printing the sum total:
        Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}"); 

        //condition that checks for winner or loser, printing output:
        if (total >= 15)
        {
            Console.WriteLine("You win!");
        }

        if (total < 15)
        {
            Console.WriteLine("Sorry, you lose.");
        }
    }

}
