/* Car Dealership App
 * 
 * The app will:
 * 
 * Show all available cars in stock.
 * Allow the user to filter cars based on criteria
 * like price, model, etc.
 * Let the user place an order.
 * Let the user contact the sales department 
 * for more information.
 */

using System;
using CarDealership.Models;

class Program
{
    static void Main(string[] args)

    {
        var dealership = new Dealership();
        var salesDepartment = new SalesDepartment();

        // Adding cars to the inventory
        dealership.AddCar(new Car("Toyota", "Camry", "Automatic", 2.5, "Gas", "FWD", "Sedan", 30, 50000, 22000));
        dealership.AddCar(new Car("Honda", "Civic", "Manual", 1.8, "Gas", "FWD", "Sedan", 35, 25000, 18000));
        dealership.AddCar(new Car("Tesla", "Model 3", "Automatic", 0, "Electric", "AWD", "Sedan", 4.0, 10000, 35000));
        dealership.AddCar(new Car("Ford", "F-150", "Automatic", 3.5, "Gas", "AWD", "Pickup", 20, 75000, 32000));

        // Create a customer
        var customer = new Customer("John Doe", "john.doe@example.com");

        // Display available cars
        Console.WriteLine("Available Cars:");
        dealership.ShowCars(dealership.Inventory);

        // Allow user to filter cars
        Console.WriteLine("\nFilter by price (max $25,000):");
        var filteredCars = dealership.FilterCars(price: 25000);
        dealership.ShowCars(filteredCars);

        // Place an order
        Console.WriteLine("\nPlacing order for the Honda Civic...");
        customer.PlaceOrder(filteredCars.First());

        // Customer inquiries
        Console.WriteLine("\nContacting sales department...");
        customer.ContactSales("Can you tell me more about the Toyota Camry?");
        salesDepartment.RespondToInquiry(customer.Name, "Sure, we will get back to you with more details.");

    }
}
