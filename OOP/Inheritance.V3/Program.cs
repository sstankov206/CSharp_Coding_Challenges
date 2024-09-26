using System;
using Inheritance.V3.Models;

class Program
{
    static void Main(string[] args)
    { 
        Car myCar = new Car();
        myCar.Make = "Toyota";
        myCar.Model = "Camry";
        myCar.NumberOfDoors = 4;

        // Accessing base class methods:
        myCar.Start(); //Output = Vehicle starting...
        myCar.Stop(); //Output = Vehicle stopping...

        //Accessing derived classe methods:
        myCar.Honk(); //Output = Car honking!

        //Displaying properties:
        Console.WriteLine($"Car Make: {myCar.Make}, Model: {myCar.Model}, doors: {myCar.NumberOfDoors}");
    }
}
