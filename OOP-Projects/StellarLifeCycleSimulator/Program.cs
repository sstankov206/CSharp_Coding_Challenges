using System;
using StellarLifeCycleSimulator.Models;


class Program
{
    static void Main(string[] args)
    {
        // Star Simulations
        Star sun = new Star("Sun", "G-type");
        sun.Shine();

        for (int i = 0; i < 10; i++) // Simulate 10 billion years
        {
            sun.GrowOlder();
            sun.Shine();
        }

        sun.Supernova();

        Star unknownStar = new Star("Mystery Star");
        unknownStar.Shine();
    }
}
