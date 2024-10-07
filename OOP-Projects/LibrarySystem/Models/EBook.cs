using System;


namespace LibrarySystem.Models
{
   public class EBook : Book
    {
        public double FileSize { get; set; } // Size in MB

        public EBook(string title, string author, string isbn, double filesize)
            : base(title, author, isbn)
        { 
            FileSize = filesize;
        }

        public override string ToString()
        {
            return $"{base.ToString()} (Size: {FileSize} MB)";

        }
    }
}
