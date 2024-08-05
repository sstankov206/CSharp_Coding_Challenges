using System;
using System.Collections.Generic;
using System.Linq;

namespace Farm
{
    public class Startup
    {

    }

    public class Animal
    {
        public void Eat()
        {
            Console.WriteLine("Eating...");
        }
    }

    public class Dog : Animal //Dog inherits from Animal
    {
        public void Bark()
        {
            Console.WriteLine("Barking...");
        }
    }

    public class Puppy : Dog //Puppy inherits from Dog
    {
        public void Weep()
        {
            Console.WriteLine("Weeping...");
        }
    }

    public class Cat : Animal  //Cat inherits from Animal
    {
        public void Meow()
        {
            Console.WriteLine("Meowing...");
        }
    }
}
