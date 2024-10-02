using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    //Derived class for products
    internal class Product : Item
    {
        public int Quantity{get; set;}

        public Product(string name, decimal price, int quantity) : base(name, price)
        { 
          Quantity = quantity;
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Product: {Name}, Price: {Price:C}, Quanity: {Quantity}");
        }
    }

}
