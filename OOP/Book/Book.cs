using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookz
{
    public class Book
    {
        public string title;
        public string author;
        public int pages;

        //constructors:
        public Book(string Title, string Author, int Pages)
        {
            this.title = Title;
            this.author = Author;
            this.pages = Pages;
        }
        public Book()
        {
                
        }


    }
}
