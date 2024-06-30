//Exercise: Practice creaing objects 

using System;
using Bookz;

class Program
{
    static void Main(string[] args) 
    {  //creating new instance of the Book class, from user input:
        Book book1 = new Book();
        book1.title = Console.ReadLine();
        book1.author = Console.ReadLine();
        book1.pages = int.Parse(Console.ReadLine());

        //printing output:
        Console.WriteLine(String.Join(", ", book1.title, book1.author, book1.pages));


    }
}