/* You're helping to develop a massive multiplayer role-playing game. Each player has
 * a luck stat that can affect their odds of finding rare treasure. Each day, 
 * a player can speak to an in-game fortune teller that reveals 
 * whether their luck stat is high, low, or neutral.
 */

using System;
class Program 
{
static void Main(string[] args) 
    {
        Random random = new Random();
        int luck = random.Next(100);

        string[] text = { "You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to" };
        string[] good = { "look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!" };
        string[] bad = { "fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life." };
        string[] neutral = { "appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature." };

        //printing output:
        TellFortune();

        //method for generating the fortune:
        void TellFortune()
        {
            Console.WriteLine("A fortune teller whispers the following words:");
            string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"{text[i]} {fortune[i]} ");
            }
        }

    }
}
