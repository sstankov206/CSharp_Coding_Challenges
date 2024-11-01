using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

namespace FishingApp.Models
{
    public class FishingTrip
    {
      public List<Fish> AvailableFish { get; }
      public List<Fish> CaughtFish { get; }

        public FishingTrip()
        {
            AvailableFish = new List<Fish>
            {
            new FreshwaterFish("Bass", 5, "Lake"),
            new FreshwaterFish("Trout", 2, "River"),
            new SaltwaterFish("Salmon", 10, "Pacific"),
            new SaltwaterFish("Tuna", 20, "Atlantic")
            };

            CaughtFish = new List<Fish>();
        }

        public void StartTrip()
        {
            Console.WriteLine("Starting Fishing Trip...");
            Random rnd = new Random();
            Fish caughtFish = AvailableFish[rnd.Next(AvailableFish.Count)];
            CaughtFish.Add(caughtFish);
            Console.WriteLine($"You caught a {caughtFish}!");
        }
    }
}
