using System;
using System.Collections.Generic;

namespace FishingApp.Models
{
    //Another Derived Class:
    public class SaltwaterFish : Fish
    {
        public string OceanType { get; } // e.g., "Atlanatic", "Pacific"
        public SaltwaterFish(string name, int weight, string oceanType)
            : base(name, weight)
        {
            OceanType = oceanType;
        }

        public override string ToString()
        {
            return $"{base.ToString()} - Habitat: Saltwater ({OceanType})";
        }

    }
}
