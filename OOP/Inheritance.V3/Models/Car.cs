using System;

namespace Inheritance.V3.Models
{
    //Derived Class
    public class Car : Vehicle // Car inherits from Vehicle
    {
        public int NumberOfDoors { get; set; }

        public void Honk()
        {
            Console.WriteLine("Car honking!");
        }
    }
}
