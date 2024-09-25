namespace PersonalBudgetTracker.Models
{
    public  class Category
    {
        public string Name { get; set; }
        public List<Transaction> Transactions { get; set; }

        public Category(string name)
        {
            Name = name;
            Transactions = new List<Transaction>();
        }

        public void AddTransaction(Transaction transaction)
        {
            Transactions.Add(transaction);
        }

        public decimal GetTotal()
        { 
            return Transactions.Sum(t => t.Amount);
        }
    }
}
