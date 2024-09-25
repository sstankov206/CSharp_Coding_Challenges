namespace PersonalBudgetTracker.Models
{
    public class Budget
    {
        public List<Category> Categories { get; set; }

        public Budget()
        {
            Categories = new List<Category>();
        }

        public void AddCategory(Category category)
        {
            Categories.Add(category);
        }

        public decimal GetTotalSpent()
        {
            return Categories.Sum(c => c.GetTotal());
        }

        public void DisplaySummary()
        {
            foreach (var category in Categories)
            {
                Console.WriteLine($"{category.Name}: {category.GetTotal():C}");
            }
            Console.WriteLine($"Total Spent: {GetTotalSpent():C}");
        }

    }
}
