// Exercise: Practice using Inheritance within OOP.

using System;
using Inheritance;

class Program
{
    static void Main(string[] args)
    {
        Car fordmustang = new Car( 4, 160, 450, "Ford", "Mustang", 2016, "blue");

        Console.WriteLine(fordmustang.Travel());
    }

}
