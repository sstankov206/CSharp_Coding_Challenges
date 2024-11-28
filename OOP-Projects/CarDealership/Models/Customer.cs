using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealership.Models
{
    public class Customer
    {
        public string Name { get; set; }
        public string Email { get; set; }

        public Customer(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public void PlaceOrder(Car car)
        {
            Console.WriteLine($"Order placed for {car.Brand} {car.Model}.");
            // Here you could add logic to record the order, like adding it to a database or an order list
        }

        public void ContactSales(string message)
        {
            Console.WriteLine($"Message to Sales: {message}");
            // Simulate sending message to the sales department (e.g., via email)
        }
    }
}
