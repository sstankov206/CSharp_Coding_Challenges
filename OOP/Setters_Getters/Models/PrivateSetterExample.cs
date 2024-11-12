using System;
using System.Collections.Generic;
using System.Linq;

namespace Setters_Getters.Models
{
    public class PrivateSetterExample
    {
        public string Name { get; private set; }

        public PrivateSetterExample(string name)
        {
            Name = name;
        }

        public void ChangeName(string newName)
        {
            Name = newName; // Allowed because the setter is private within the class.
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name (Private Setter): {Name}");
        }
    }
}
