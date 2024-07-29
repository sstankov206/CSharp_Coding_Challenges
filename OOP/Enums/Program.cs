// Exercise: Practice using Enums within OOP.

// Enums = special "class" that contains a set of named integer constants.
//        Use enums when you have values that you know will NOT change.
//        To get the integer value from an item, you must explicitly convert to an int.

// name = integer

using System;
class Program 
{
    static void Main(string[] args) 
    {
        Console.WriteLine(Planets.Pluto + " is a planet.");
        Console.WriteLine(Planets.Mercury + " is planet #" + (int)Planets.Mercury);

        String name = PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;

        Console.WriteLine("planet: " + name);
        Console.WriteLine("radius: " + radius + "km");
    }
}

enum Planets 
{
    Mercury = 1,
    Venus = 2,
    Earth = 3,
    Mars = 4,
    Jupiter = 5,
    Saturn = 6,
    Uranus = 7,
    Neptune = 8,
    Pluto = 9
}

enum PlanetRadius
{
    Mercury = 2439,
    Venus = 6051,
    Earth = 6371,
    Mars = 3389,
    Jupiter = 69911,
    Saturn = 58232,
    Uranus = 25362,
    Neptune = 24622,
    Pluto = 1188
}
