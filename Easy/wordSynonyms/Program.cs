/* Problem: Word Synonyms
 * 
 * Read 2 * N lines of pairs - word and synonym
 * Each word can have multiple synonyms.
 * 
 * Example:
 * 
 * cute - adorable, charming
 * smart - clever
 * 
 */

using System;
class Program
{
    static void Main(string[] args)
    {
        //reading input, determines how many pairs of words will be generated:
        int n = int.Parse(Console.ReadLine());

        //Dictionary to store the pairs (word + synonym):
        Dictionary<string, List<string>> wordSynonyms = new Dictionary<string, List<string>>();

        //for each number of pair of words:
        for (int i = 0; i < n; i++)
        {
            string word = Console.ReadLine(); //sets the word, via user input
            string synonym = Console.ReadLine(); //sets the word's synonym via user input

            //if the word is found -> add the synonym
            //if the word is not found -> add the word
            if (wordSynonyms.ContainsKey(word))
            {
                wordSynonyms[word].Add(synonym);
            }
            else
            {
                wordSynonyms.Add(word, new List<string>());
                wordSynonyms[word].Add(synonym);
            }

            //printing output:
            foreach (var pair in wordSynonyms)
            {
                Console.WriteLine(pair.Key + " - " + string.Join(", ", pair.Value));
            }
        }

    }

}
