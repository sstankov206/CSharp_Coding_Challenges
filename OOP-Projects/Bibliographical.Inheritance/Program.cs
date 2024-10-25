using System;
using Bibliographical.Inheritance.Models;
class Program
{
    static void Main(string[] args)
    {
        // Testing Resource
        Resource test = new Resource("Example Title", "General");
        test.GetInfo();
        test.UpdateStatus();
        Console.WriteLine($"Updated Status: {test.UpdateStatus}\n");

        // Testing Book
        string[] authors = { "Charles Petzold" };
        Book book = new Book("Code: The Hidden Language of Computer Hardware and Software", "Non-Fiction", authors, 396);
        book.GetInfo();
        Console.WriteLine();

        // Testing Periodical
        Periodical periodical = new Periodical("Wired", "Technology", "Monthly");
        periodical.GetInfo();
        periodical.UpdateStatus();
        Console.WriteLine($"Updated Status: {periodical.UpdateStatus}\n");

        // Testing Video
        Video video = new Video("Ex Machina", "Sci-Fi", "Alex Garland", 108, "On-Demand");
        video.GetInfo();
    }
}