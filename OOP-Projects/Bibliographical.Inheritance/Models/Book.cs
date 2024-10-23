using System;

namespace Bibliographical.Inheritance.Models
{
    public class Book : Resource
    {
        public string[] Author { get; set; }
        public int PageCount { get; set; }

        public Book(string title, string category, string[] author, int pageCount)
            : base(title, category)
        {
            Author = author;
            PageCount = pageCount;
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Authors: {string.Join(", ", Author)}");
            Console.WriteLine($"Page Count: {PageCount}");
        }
    }
}
