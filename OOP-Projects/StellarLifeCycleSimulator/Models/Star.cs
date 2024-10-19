using System;


namespace StellarLifeCycleSimulator.Models
{
    public class Star
    {
        // Public fields
        public string name;
        public string type;
        public int age; // in billion years
        public double brightness; // in luminosity units

        // Constructor that takes name and type
        public Star(string name, string type)
        {
            this.name = name;
            this.type = type;
            this.age = 0; // Initialize age to 0
            this.brightness = 1.0; // Initialize brightness to 1.0
        }

        // Constructor that takes only name
        public Star(string name)
        {
            this.name = name;
            this.type = "Unknown"; // Set type to Unknown
            Console.WriteLine("Star type set to default: Unknown.");
            this.age = 0; // Initialize age to 0
            this.brightness = 1.0; // Initialize brightness to 1.0
        }

        // Method to simulate shining
        public void Shine()
        {
            Console.WriteLine($"Star {name} is shining with brightness {brightness}.");
        }

        // Method to grow older
        public void GrowOlder()
        {
            age += 1; // Increase age by 1 billion years
            brightness *= 0.9; // Decrease brightness by 10%
        }

        // Method to simulate a supernova
        public void Supernova()
        {
            brightness = 0; // Set brightness to 0
            Console.WriteLine($"Star {name} has exploded in a supernova.");
        }
    }
}
