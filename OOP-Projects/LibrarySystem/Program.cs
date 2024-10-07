//Simple Library program that implements OOP principles.

using System;
using LibrarySystem.Models;

class Program
{
    static void Main(string[] args)
    {
        Library library = new Library();

        // Create some books
        Book book1 = new Book("The Great Gatsby", "F. Scott Fitzgerald", "9780743273565");
        Book book2 = new EBook("C# Programming", "Author Name", "1234567890", 2.5);

        // Add books to the library
        library.AddBook(book1);
        library.AddBook(book2);

        // Create members
        Member member1 = new Member("Alice", 1);
        Member member2 = new Member("Bob", 2);

        //Add members to the library
        library.AddMember(member1);
        library.AddMember(member2);


        //Display books
        System.Console.WriteLine("Books in the library:");
        library.DisplayBooks();

        //Display members
        System.Console.WriteLine("\nMembers of the library:");
        library.DisplayMembers();
    }
}