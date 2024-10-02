using System;
using System.Collections.Generic;

namespace InventorySystem.Models
{
    //Class to manage the inventory
    public class Inventory
    {
        private List<Item> items = new List<Item>();

        public void AddItem(Item item)
        {
            items.Add(item);
            Console.WriteLine($"{item.Name} added to inventory.");
        }

        public void DisplayInventory()
        {
            Console.WriteLine("\nInventory:");
            foreach (var item in items)
            {
                item.DisplayInfo();
            }
        }
    }
}
