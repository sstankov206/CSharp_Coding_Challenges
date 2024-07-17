// Exercise: Practice using Polymorphism within OOP.

using System;
using Polymorphism;
class Program
{
    static void Main(string[] args)
    {
        Animal myAnimal = new Animal();  // Create a Animal object
        Animal myPig = new Pig();  // Create a Pig object
        Animal myDog = new Dog();  // Create a Dog object

        //printing the output of each animal's sound:
        myAnimal.animalSound();
        myPig.animalSound();
        myDog.animalSound();
    }
}