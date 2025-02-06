using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Animals.Models
{
   // Dog class inherits from Animal (demonstrates inheritance)
    class Dog : Animal
    {
        // Implementing the abstract method (polymorphism)
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Woof!");
        }
    }
}
