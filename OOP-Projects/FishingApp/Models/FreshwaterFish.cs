using System;
using System.Collections.Generic;

namespace FishingApp.Models
{
    //Derived class:

    public class FreshwaterFish : Fish
    {
        public string FreshwaterType {  get; set; }
        public FreshwaterFish(string name, double weight, string habitat, string freshwaterType)
        :base(name, weight, habitat)
        {
            FreshwaterType = freshwaterType;
        }

        public override void DisplayInfo()
        { 
            base.DisplayInfo();
            Console.WriteLine($"Freshwater Type: {FreshwaterType}");
        }
    }
}
