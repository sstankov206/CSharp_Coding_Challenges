using System;
using System.Collections.Generic;

namespace FishingApp.Models
{
    //Another Derived Class:
    public class SaltwaterFish : Fish
    {
        public string SaltwaterType { get; set; }
        public SaltwaterFish(string name, double weight, string habitat, string saltwaterType)
            : base(name, weight, habitat)
        {
            SaltwaterType = saltwaterType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Saltwater Type: {SaltwaterType}");
        }

    }
}
