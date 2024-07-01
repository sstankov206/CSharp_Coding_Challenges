using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Initializers_
{
    public class Initializers
    {

        // Using object initializers

        // Example: class that defines a Pet with a name and age
        public class Pet
        {
            public string Name { get; set; } = "";
            public int Age { get; set; } = 0;

            public Pet() { }
        }

        public class Dog : Pet
        {
            public bool IsTrained { get; set; } = false;

            public Dog() { }
        }

        public class Cat : Pet
        {
            public bool IsDeclawed { get; set; } = false;

            public Cat() { }
        }

        // Define a class that implements an internal collection
        public class PetOwner
        {
            public string Name { get; set; } = "";

            public List<Pet>? Pets { get; set; }
        }
    }

}

