using System;
using System.Collections.Generic;


namespace Setters_Getters.Models
{
    public class NoSetterExample
    {
        public string Name { get; }

        public NoSetterExample(string name)
        {
            Name = name;
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name (No Setter): {Name}");
        }
    }
}
