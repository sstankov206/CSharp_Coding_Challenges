using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals.Models
{
    // Cat class inherits from Animal (demonstrates inheritance)
    class Cat : Animal
    {
        // Implementing the abstract method (polymorphism)
        public override void Speak()
        {
            Console.WriteLine($"{Name} says: Meow!");
        }
    }
}
