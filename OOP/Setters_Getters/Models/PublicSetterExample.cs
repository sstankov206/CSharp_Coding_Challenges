using System;
using System.Collections.Generic;
using System.Linq;

namespace Setters_Getters.Models
{
    public class PublicSetterExample
    {
        public string Name { get; set; }

        public void DisplayInfo()
        {
            Console.WriteLine($"Name (Public Setter): {Name}");
        }

    }
}
