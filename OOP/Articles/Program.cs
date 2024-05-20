/* Create a class Article with the following properties:

· Title – a string

· Content – a string

· Author – a string

The class should have a constructor and the following methods:

· Edit (new content) – change the old content with the new one

· ChangeAuthor (new author) – change the author

· Rename (new title) – change the title of the article

· Override the ToString method – print the article in the following format:

"{title} - {content}: {autor}"

Write a program that reads an article in the following format "{title}, {content}, {author}". On the next line,
you will receive a number n, representing the number of commands, which will follow after it. On the next n lines, 
you will be receiving the following commands: "Edit: {new content}"; "ChangeAuthor: {new author}"; "Rename: {new title}". 
At the end, print the final state of the article.

*/

using Articles;
using System;
class Program
{
    public static void Main(string[] args)
    { //reading input:
        var input = Console.ReadLine()
            .Split(", ", StringSplitOptions.RemoveEmptyEntries)
            .ToArray();

        Article article = new Article(input[0], input[1], input[2]); //author, content, title

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            //reading command from input:
            var command = Console.ReadLine().Split(": ",
                StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            switch (command[0])
            {
                case "Edit":
                    article.Edit((command[1]));
                    break;
                case "ChangeAuthor":
                    article.Edit((command[1]));
                    break;
                case "Rename":
                    article.Edit((command[1]));
                    break;
            }
        }

        //printing output:
        Console.WriteLine(article.ToString);
    }
}
