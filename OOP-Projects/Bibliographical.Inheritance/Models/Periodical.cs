using System;

namespace Bibliographical.Inheritance.Models
{
    public class Periodical: Resource
    {
        public string Period { get; set; }

        public Periodical(string title, string category, string period)
            : base(title, category)
        {
            Period = period;
        }

        public override void UpdateStatus()
        {
            Status = Status == "In-use" ? "Available" : "In-use";
        }

        public override void GetInfo()
        {
            base.GetInfo();
            Console.WriteLine($"Period: {Period}");
        }
    }
}
