using System;
using System.Collections.Generic;
using System.Linq;


namespace CarDealership.Models
{
    public class Car
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string TransmissionType { get; set; } //e.g. manual, automatic
        public double EngineSize { get; set; } // In liters
        public string FuelType { get; set; } //e.g., Gas, Diesel, Electric
        public string DriveType { get; set; } // FWD, RWD, AWD
        public string Size { get; set; } // e.g., Seda, SUV, Pickup
        public double FuelEfficiency { get; set; } //e.g., MPG or L/100km
        public double Odometer { get; set; } // In miles or km
        public double Price { get; set; } // In USD $
        public Car(string brand, string model, string transmissionType, double engineSize, string fuelType,
        string driveType, string size, double fuelEfficiency, double odometer, double price)
        {
            Brand = brand;
            Model = model;
            TransmissionType = transmissionType;
            EngineSize = engineSize;
            FuelType = fuelType;
            DriveType = driveType;
            Size = size;
            FuelEfficiency = fuelEfficiency;
            Odometer = odometer;
            Price = price;
        }

        public override string ToString()
        {
            return $"{Brand} {Model} - {Size} - {TransmissionType} - {FuelType} - {DriveType} - ${Price}";
        }
    }
}
