using System;

namespace Bibliographical.Inheritance.Models
{
    public class Resource
    {
        public string Title { get; private set; }
        public string Category { get; private set; }
        protected string Status { get; set; }

        public Resource(string title, string category)
        {
            Title = title;
            Category = category;
            Status = "Available";
        }

        public virtual void UpdateStatus()
        {
            Status = Status == "Out" ? "Available" : "Out";
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}
