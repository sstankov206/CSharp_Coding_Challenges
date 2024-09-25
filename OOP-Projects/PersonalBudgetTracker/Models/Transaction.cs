namespace PersonalBudgetTracker.Models
{
    public class Transaction
    {
        public string Description { get; set; }
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }

        public Transaction(string description, decimal amount)
        { 
            Description = description;
            Amount = amount;
            Date = DateTime.Now;
        }
    }
}
