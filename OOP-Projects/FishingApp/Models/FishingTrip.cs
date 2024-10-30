using System;

namespace FishingApp.Models
{
    public class FishingTrip
    {
        public string Location { get; set; }
        public DateTime Date { get; set; }
        public List<Fish> CaughtFish { get; set; }

        public FishingTrip(string location, DateTime date)
        {
            Location = location;
            Date = date;
            CaughtFish = new List<Fish>();
        }

        public void AddFish(Fish fish)
        {
            CaughtFish.Add(fish);
        }

        public void DisplayTripDetails()
        {
            Console.WriteLine($"Fishing Trip Location: {Location}, Date: {Date.ToShortDateString}");
            Console.WriteLine($"Caught Fish:");
            foreach (var fish in CaughtFish)
            {
                fish.DisplayInfo();
                Console.WriteLine();
            }
        }
    }
}
