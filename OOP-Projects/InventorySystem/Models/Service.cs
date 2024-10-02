using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    public class Service : Item
    {
        public int DurationInHours { get; set; }

        public Service(string name, decimal price, int duration) : base(name, price)
        {
            DurationInHours = duration;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Service: {Name}, Price: {Price:C}, Duration: {DurationInHours}");
        }
    }
}
