using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articles
{
    public class Article
    {
        //properties:
        public string Title { get; set; }
        public string Content{ get; set; }
        public string Author{ get; set; }

        //constructor:
        public Article(string title, string content, string author)
        {
             this.Author = author;
            this.Content = content;
            this.Title = title;
        }
        
        //method for "Edit" command - new content:
        public void Edit(string content)
        {
            this.Content = content;
        }

        //method for "ChangeAuthor" command - new author:
        public void ChangeAuthor(string author) 
        {
            this.Author = author;
        }

        //method for "Rename" command - new title:
        public void Rename(string title)
        {
            this.Title = title;
        }

        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
    }
}
