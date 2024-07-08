using System;
using Yearbook;
class Program 
{
    static void Main(string[] args) 
    {
        
        Freshman freshman1 = new Freshman("Bobby", "Smalls", 9, "class photo");
        Senior senior1 = new Senior("Ferris", "Bueller", 12, "senior picture", "Life moves pretty fast. If you don't stop and look around once in a while, you could miss it.");

        Console.WriteLine("YEARBOOK for Year 2024 :  ");
        Console.WriteLine();
        Console.WriteLine(freshman1.ToString());
        Console.WriteLine();
        Console.WriteLine(senior1.ToString());

    }
}