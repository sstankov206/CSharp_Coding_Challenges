using System;
class Program
{
    public static void Main(string[] args)
    {
        //read input, based on input, determine how many messages to generate:
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            //printing output:
            Console.WriteLine(AdvertisementMessage.GenerateMessage());
        }
    }

    //class that holds properties for advertisement messages:
    public class AdvertisementMessage
    {
        public static string[] Phrases = new string[] { "Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
        public static string[] Events = new string[] { "Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};
        public static string[] Authors = new string[] { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        public static string[] Cities = new string[] { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };

        //method that generates advertisement messages:
        public static string GenerateMessage()
        { Random randomizer = new Random();
            string currentPhrase = Phrases[randomizer.Next(0, Phrases.Length)];
            string currentEvent = Events[randomizer.Next(0, Events.Length)];
            string currentAuthor = Authors[randomizer.Next(0, Events.Length)];
            string currentCity = Cities[randomizer.Next(0, Cities.Length)];

            return $"{currentPhrase} {currentEvent} {currentAuthor} - {currentCity}";

        }
       }
}  


