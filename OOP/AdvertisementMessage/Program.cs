/* 1. Advertisement Message

Write a program that generates random fake advertisement message to advertise a product. 
The messages must consist of 4 parts: phrase + event + author + city. Use the following predefined parts:

· Phrases – {"Excellent product.", "Such a great product.", "I always use that product.", "Best product of its category.", "Exceptional product.", "I can’t live without this product."}

· Events – {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!", "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"}

· Authors – {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"}

· Cities – {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"}

The format of the output message is the following: {phrase} {event} {author} – {city}.

You will receive the number of messages to be generated. Print each random message at a separate line.

*/

using AdvertisementMessage;
using System;


class Program
{
    public static void Main(string[] args)
    {
        string[] phrasesList = {"Excellent product.", "Such a great product.", "I always use that product.",
            "Best product of its category.", "Exceptional product.", "I can’t live without this product."};
        string[] eventsList = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!",
            "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!" };
        string[] authorsList = { "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva" };
        string[] citiesList = { "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse" };
        
        //read input and determine how many advertisement messages to generate:
        int input = int.Parse(Console.ReadLine());

        Random random = new Random();
        Queue<Message> queue = new Queue<Message>();
        for (int i = 0; i < input; i++)
        {
            Message msg = new Message(
                phrasesList[random.Next(phrasesList.Length)],
               eventsList[random.Next(eventsList.Length)],
               authorsList[random.Next(authorsList.Length)],
               citiesList[random.Next(citiesList.Length)]
                );
            queue.Enqueue(msg);
        }

        for (int i = 0; i < input; i++)
        {   var item = queue.Dequeue();
            Console.WriteLine(item);
        }

    }


}