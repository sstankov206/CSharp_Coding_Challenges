/* Simple console app that implements C# Abstraction,
 * Polyphormism, Encapsulation, Inheritance.
 * 
 */

using System;
using Animals.Models;


class Program
{
    static void Main(string[] args)
    {
        // Using encapsulation to set values
        Dog dog = new Dog();
        dog.Name = "Buddy";
        dog.Age = 5;

        // Using polymorphism: Dog objects can all Speak(), which is overriden in Dog
        dog.Speak();
        dog.Sleep();

        // Using encapsulation to set values
        Cat cat = new Cat();
        cat.Name = "Whiskers";
        cat.Age = 3;

        //Using polymorphism: Cat objects can all Speak(), which is overriden in Cat
        cat.Speak();
        cat.Sleep();

    }
}
