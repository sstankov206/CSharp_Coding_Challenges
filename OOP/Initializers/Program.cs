using System;
using Initializers_;
using static Initializers_.Initializers;
class Program
{
    static void Main(string[] args)
    {
        // Using object and collection initializers

        // Use the initializer syntax to create new objects
        Dog dog = new Dog { Name = "Michael", Age = 10, IsTrained = true };
        Cat cat = new Cat { Name = "Mima", Age = 12, IsDeclawed = false };

        Console.WriteLine($"Dog: {dog.Name}, {dog.Age}");
        Console.WriteLine($"Cat: {cat.Name}, {cat.Age}");

        // Initializers can be used on anonymous types
        var pet = new { Name = "Eeyore", Age = 9 };
        Console.WriteLine($"{pet.Name}, {pet.Age}");

        // Initialize a collection with a set of objects
        PetOwner owner = new PetOwner
        {
            Name = "Stanimir S.",
            Pets = new List<Pet> {
        new Dog {Name = "Michael", Age = 10},
        new Cat {Name = "Mima", Age = 12 },
        new Dog {Name = "Eeyore", Age = 9}
    }
        };

        Console.WriteLine($"{owner.Name}'s Pets:");
        foreach (Pet p in owner.Pets)
        {
            Console.WriteLine($"{p.Name}");
        }

    }
}

