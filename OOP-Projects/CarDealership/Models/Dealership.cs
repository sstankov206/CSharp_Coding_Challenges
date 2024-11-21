using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDealership.Models
{
    public class Dealership
    {
        public List<Car> Inventory { get; set; }

        public Dealership()
        {
            Inventory = new List<Car>();
        }
    }
}
