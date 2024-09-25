using System;
using PersonalBudgetTracker.Models;

class Program
{
    static void Main(string[] args)
    {
        var budget = new Budget();

        //Adding categories
        var foodCategory = new Category("Food");
        var entertainmentCategory = new Category("Entertainment");
        var clothesCategory = new Category("Clothes");
        var travelCategory = new Category("Travel");

        budget.AddCategory(foodCategory);
        budget.AddCategory(entertainmentCategory);

        //Adding transactions
        foodCategory.AddTransaction(new Transaction("Groceries", -50));
        foodCategory.AddTransaction(new Transaction("Dinner Out", -30));

        //Displaying the budget summary
        budget.DisplaySummary();

        //User input for transactions
        var continueInput ="";
        do 
        {
            Console.Write("Enter Category (Food/Entertainment/Clothes/Travel): ");
            string categoryInput = Console.ReadLine();
            Category selectedCategory = null;

            if (categoryInput.Equals("Food", StringComparison.OrdinalIgnoreCase))
            {
                selectedCategory = foodCategory;
            }
            else if (categoryInput.Equals("Entertainment", StringComparison.OrdinalIgnoreCase))
            {
                selectedCategory = entertainmentCategory;
            }
            else if (categoryInput.Equals("Clothes", StringComparison.OrdinalIgnoreCase))
            {
                selectedCategory = clothesCategory;
            }
            else if (categoryInput.Equals("Travel", StringComparison.OrdinalIgnoreCase))
            {
                selectedCategory = travelCategory;
            }
            else
            {
                Console.WriteLine("Invalid category. Please enter Food or Entertainment.");
                continue;
            }

            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            Console.Write("Enter Amount (use negative for expenses): ");
            if (decimal.TryParse(Console.ReadLine(), out decimal amount))
            {
                selectedCategory.AddTransaction(new Transaction(description, amount));
                Console.WriteLine("Transaction added successfully!");
            }
            else
            {
                Console.WriteLine("Invalid amount. Please enter a valid number.");
                continue;
            }

            Console.Write("Would you like to add another transaction? (yes/no): ");
            continueInput = Console.ReadLine();
        } while (continueInput.Equals("yes", StringComparison.OrdinalIgnoreCase));

        // Displaying the budget summary
        Console.WriteLine("\nBudget Summary:");
        budget.DisplaySummary();
    }
}

