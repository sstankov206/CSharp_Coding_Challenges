using System;

namespace LibrarySystem.Models
{
    public class Library
    {
        private List<Book> books = new List<Book>();
        private List<Member> members = new List<Member>();

        public void AddBook(Book book)
        {
            books.Add(book);
        }

        public void AddMember(Member member) 
        {
            members.Add(member);
        }

        public void DisplayBooks()
        {
            foreach (var book in books)
            {
                System.Console.WriteLine(book);
            }
        }

        public void DisplayMembers()
        {
            foreach (var member in members)
            {
                System.Console.WriteLine(member);
            }
        }
    }
}
