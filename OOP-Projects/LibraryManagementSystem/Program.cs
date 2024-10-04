//Ssimple C# console application that demonstrates Object-Oriented Programming (OOP) principles.

using System;
using LibraryManagementSystem.Models;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        while (true)
        {
            Console.WriteLine("Library Management System");
            Console.WriteLine("1. Add Book");
            Console.WriteLine("2. Remove Book");
            Console.WriteLine("3. List Books");
            Console.WriteLine("4. Exit");
            Console.WriteLine("Choose an option: ");

            string option = Console.ReadLine();

            switch (option)
            {
                case "1":
                    Console.WriteLine("Enter Title: ");
                    string title = Console.ReadLine();
                    Console.WriteLine("Enter Author: ");
                    string author = Console.ReadLine();
                    Console.WriteLine("Enter ISBN: ");
                    string isbn = Console.ReadLine();
                    library.AddBook(new Book(title, author, isbn));
                    break;

                case "2":
                    Console.WriteLine("Enter ISBN of the book to remove: ");
                    string removeIsbn = Console.ReadLine();
                    library.RemoveBook(removeIsbn);
                    break;

                case "3":
                    library.ListBooks();
                    break;

                case "4":
                    return;

                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;

            }

        }
    }
}
