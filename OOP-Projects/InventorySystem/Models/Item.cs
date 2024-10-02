using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    //Base class representing an item
    public abstract class Item
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        public Item(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        // Abstract method to be implemented by derived classes
        public abstract void DisplayInfo();

    }
}
