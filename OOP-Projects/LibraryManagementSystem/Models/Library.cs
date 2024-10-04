using System;

namespace LibraryManagementSystem.Models
{
    public class Library
    {
        private List<Book> books = new List<Book>();

        public void AddBook(Book book)
        { 
            books.Add(book);
        }

        public void RemoveBook(string isbn)
        {
            books.RemoveAll(b => b.ISBN == isbn);
        }

        public void ListBooks()
        {
            if (books.Count == 0)
            {
                Console.WriteLine("No books available in the library.");
                return;
            }

            Console.WriteLine("Books in the Library:");
            foreach (var book in books)
            {
                Console.WriteLine(book);
            }
        }
    }
}
