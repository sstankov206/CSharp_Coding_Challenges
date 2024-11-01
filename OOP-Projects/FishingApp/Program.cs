/* Simple fishing app with OOP, which allows
 * users to manage different types of fish and 
 * fishing trips.
 */

using System;
using FishingApp.Models;

class Program
{
    static void Main(string[] args)
    { 
        //Start a fishing trip
        FishingTrip trip = new FishingTrip();
        trip.StartTrip();

        //Display caught fish
        Console.WriteLine("\nCaught Fish:");
        foreach (var fish in trip.CaughtFish)
        {
            Console.WriteLine(fish);
        }
    }
}
