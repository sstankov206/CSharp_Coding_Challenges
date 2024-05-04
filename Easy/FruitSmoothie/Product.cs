using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSmoothie
{
    public abstract class Product
    {
        protected string Currency { get; set; }
        protected List<Ingredient> _Ingredients { get; set; } = new();

        protected List<Ingredient> clientIngredients { get; set; }

        public string[] Ingredients { get; set; }


        protected Product(string[] ingredients, List<Ingredient> _ingredients, string currency)
        {
            Currency = currency; _Ingredients = _ingredients;

            Ingredients = ingredients;
            var order = string.Join(", ", ingredients);
            clientIngredients = _Ingredients.Where(x => order.Contains(x.Name)).ToList();
        }

        public string GetCost()
           => Currency + clientIngredients.Sum(x => x.Price);

        public string GetPrice()
        {
            //  var totalCost = clientIngredients.Select(x => x.Price).Sum();
            return Currency + string.Format("{0:0.00}", clientIngredients.Sum(x => x.Price) + (clientIngredients.Sum(x => x.Price) * 1.5m));
        }

        public virtual string GetName()
        {
            var list = Ingredients.OrderBy(x => x).ToArray();
            return string.Join(" ", list);
        }
    }
}
