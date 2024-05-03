

namespace FruitSmoothie
{
    public class FruitSmoothie
    {
        private List<Ingredient> _Ingredients { get; set; } = new()
        {
            new() { Name = "Strawberries", Currency = "£", Price = 1.50m },
            new() { Name = "Banana", Currency = "£", Price = 0.50m },
            new() { Name = "Mango", Currency = "£", Price = 2.50m },
            new() { Name = "Blueberries", Currency = "£", Price = 1.00m },
            new() { Name = "Raspberries", Currency = "£", Price = 1.00m },
            new() { Name = "Apple", Currency = "£", Price = 1.75m },
            new() { Name = "Pineapple", Currency = "£", Price = 3.50m },
        };

        private List<Ingredient> clientIngredients { get; set; }

        public string[] Ingredients { get ; set; }

        public FruitSmoothie()
        {

        }


        public FruitSmoothie(string[] ingredients)
        {
            Ingredients = ingredients;
            var order = string.Join(", ", ingredients);
            clientIngredients = _Ingredients.Where(x => order.Contains(x.Name)).ToList();
        }

        public string GetCost()
           => clientIngredients.Sum(x => x.Price)+"";

        public string GetPrice()
        {
          //  var totalCost = clientIngredients.Select(x => x.Price).Sum();
            return "£"+string.Format("{0:0.00}", clientIngredients.Sum(x => x.Price) + (clientIngredients.Sum(x => x.Price) * 1.5m));
        }

        public string GetName()
        {
          var list = Ingredients.OrderBy(x => x).ToArray();
            return string.Join(" ", list).Replace("berries", "berry") + (list.Length == 1 ? " Fusion" : " Smoothie");
        }
    }
}
