//Project description: Simple Inventory System

using System;
using System.Collections.Generic;
using InventorySystem.Models;

public class Program
{
    public static void Main(string[] args)
    {
        Inventory inventory = new Inventory();

        // Creating some products and services
        Product product1 = new Product("Laptop", 999.99m, 10);
        Product product2 = new Product("Mouse", 29.99m, 100);
        Service service1 = new Service("Repair", 50.00m, 2);
        Service service2 = new Service("Setup", 75.00m, 1);

        // Adding items to inventory
        inventory.AddItem(product1);
        inventory.AddItem(product2);
        inventory.AddItem(service1);
        inventory.AddItem(service2);

        // Displaying the inventory
        inventory.DisplayInventory();
    }
}
