using System;
using System.Collections.Generic;
using System.Linq;

namespace Animals.Models
{
    //Abstract class that implements abstraction
    abstract class Animal
    {
        // Encapsulation: Private fields for animal name and age
        private string name;
        private int age;

        // Property for getting and setting animal name (encapsulation)
        public string Name
        {
            get { return name; }
            set { name = value; }
        }


        // Property for getting and setting animal age (encapsulation)
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        //Abstract method: Each subclass must implement this (abstraction)
        public abstract void Speak();

        // A non-abstract method (inherits common behavior)
        public void Sleep()
        {
            Console.WriteLine($"{name} is sleeping");
        }
    }
}
