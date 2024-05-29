// Practice: Sort user provided text, using Dictionary, print how many times each word occurs.


using System;

class Program
{
    static void Main()
    {
        //given text:
        string text = Console.ReadLine();

        //input:
        string[] words = text.Split();

        //creating the dictionary:
        var sortedDictionary = new SortedDictionary<string, int>();

        //iterate through all numbers in the input:
        foreach (string word in words)
        {
            //check if dictionary contains this word (key)
            if (sortedDictionary.ContainsKey(word))
            {
                sortedDictionary[word]++; //increase this word (key's) value
            }
            else //if the dictionary doesn't (already) contain this word (key):
            {
                sortedDictionary.Add(word, 1); //add this word (as a key), and increase the key's value
            }
        }

        //for each key/value pair in the sorted dictionary:
        foreach (var pair in sortedDictionary)
        {
            //print the output in the following format:

            Console.WriteLine(pair.Key + " -> " + pair.Value);
        }
    }
}