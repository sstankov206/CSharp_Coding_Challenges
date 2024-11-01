using System;
using System.Collections.Generic;


namespace FishingApp.Models
{
    //Base clas:
    public abstract class Fish
    {
        public string Name { get; }
        public int Weight { get; } //in pounds (lbs.)

        public Fish(string name, int weight)
        {
            Name = name;
            Weight = weight;

        }

        public override string ToString()
        {
            return $"{Name} ({Weight} lbs)";
        }
    }
}
