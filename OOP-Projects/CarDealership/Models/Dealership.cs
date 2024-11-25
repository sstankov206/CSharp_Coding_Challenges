using System;
using System.Collections.Generic;
using System.Linq;

namespace CarDealership.Models
{
    public class Dealership
    {
        public List<Car> Inventory { get; set; }

        public Dealership()
        {
            Inventory = new List<Car>();
        }

        public void AddCar(Car car)
        {
            Inventory.Add(car);
        }

        public List<Car> FilterCars(string brand = null, string model = null, string transmissionType = null,
    double? engineSize = null, string fuelType = null, string driveType = null,
    string size = null, double? fuelEfficiency = null, double? odometer = null, double? price = null)
        {
            var query = Inventory.AsQueryable();

            if (!string.IsNullOrEmpty(brand)) query = query.Where(c => c.Brand.Equals(brand, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(model)) query = query.Where(c => c.Model.Equals(model, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(transmissionType)) query = query.Where(c => c.TransmissionType.Equals(transmissionType, StringComparison.OrdinalIgnoreCase));
            if (engineSize.HasValue) query = query.Where(c => c.EngineSize == engineSize.Value);
            if (!string.IsNullOrEmpty(fuelType)) query = query.Where(c => c.FuelType.Equals(fuelType, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(driveType)) query = query.Where(c => c.DriveType.Equals(driveType, StringComparison.OrdinalIgnoreCase));
            if (!string.IsNullOrEmpty(size)) query = query.Where(c => c.Size.Equals(size, StringComparison.OrdinalIgnoreCase));
            if (fuelEfficiency.HasValue) query = query.Where(c => c.FuelEfficiency == fuelEfficiency.Value);
            if (odometer.HasValue) query = query.Where(c => c.Odometer == odometer.Value);
            if (price.HasValue) query = query.Where(c => c.Price <= price.Value);

            return query.ToList();
        }
    }
}
