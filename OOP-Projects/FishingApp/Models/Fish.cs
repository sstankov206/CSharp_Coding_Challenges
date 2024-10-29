using System;
using System.Collections.Generic;


namespace FishingApp.Models
{
    //Base clas:
    public class Fish
    {
        public string Name { get; set; }
        public double Weight { get; set; }
        public string Habitat { get; set; }

        public Fish(string name, double weight, string habitat)
        {
            Name = name;
            Weight = weight;
            Habitat = habitat;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Fish: {Name}, Weight: {Weight} lbs, Habitat: {Habitat}");
        }
    }
}
