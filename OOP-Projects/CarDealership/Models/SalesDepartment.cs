using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CarDealership.Models
{
    public class SalesDepartment
    {
        public void RespondToInquiry(string customerName, string message)
        {
            Console.WriteLine($"Sales Department responding to {customerName}: {message}");
            // Logic to respond to a customer's inquiry
        }
    }
}
