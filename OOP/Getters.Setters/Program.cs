// Exercise: Practice using Getters & Setters acccessors within properties.

using System;
using Getters.Setters;
class Program 
{
    static void Main(string[] args) 
    {
        //creating new instance of the Car class:
        Car car = new Car(200);

        //getting the car's speed via the Properties accessors (getters & setters):
        Console.WriteLine(car.Speed);
    }
}