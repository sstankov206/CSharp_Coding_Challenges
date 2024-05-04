

namespace FruitSmoothie
{
    public class FruitSmoothie: Product
    {
        public FruitSmoothie(string[] ingredients): base(ingredients, new()
        {
            new() { Name = "Strawberries", Price = 1.50m },
            new() { Name = "Banana", Price = 0.50m },
            new() { Name = "Mango", Price = 2.50m },
            new() { Name = "Blueberries", Price = 1.00m },
            new() { Name = "Raspberries", Price = 1.00m },
            new() { Name = "Apple", Price = 1.75m },
            new() { Name = "Pineapple", Price = 3.50m },
        }, "BGN")
        { }

        public override string GetName()
        {
            return base.GetName().Replace("berries", "berry") + (Ingredients.Length == 1 ? " Fusion" : " Smoothie");
        }
    }
}
