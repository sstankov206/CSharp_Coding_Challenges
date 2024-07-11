// Exercise: Practice using Constructors within OOP.

using Constructor_;
using System;
class Program
{
    static void Main(string[] args)
    {
        //creating a new instance of the Car class with constructor:
        Car fordmustang = new Car("Ford", "Mustang", 2018, "black", 160, 450);

        fordmustang.Drive();

        Console.WriteLine($"Car specs: \n top mph: {fordmustang.topspeed} \n hp: {fordmustang.horsepower}");
    }
}
