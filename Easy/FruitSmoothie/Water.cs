using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruitSmoothie
{
    public class Water : Product
    {
        public Water(string[] ingredients) : base(ingredients, new()
        {
            new() { Name = "Devin", Price = 1.50m },
            new() { Name = "Bankya", Price = 0.50m },
            new() { Name = "Hisarya", Price = 2.50m },
            new() { Name = "Velingrad", Price = 1.00m },
        },"$")
        {

        }
    }
}
