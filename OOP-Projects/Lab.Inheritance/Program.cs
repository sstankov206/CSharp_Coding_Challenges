// Lab: Inheritace
//Requirements: https://judge.softuni.org/Contests/1499/Inheritance-Lab

using Lab.Inheritance.Models;
class Program
{
    static void Main(string[] args)
    {
        //instances of the created classes:

        Dog dog = new Dog();
        dog.Bark();
        dog.Eat();

        Puppy puppy = new Puppy();
        puppy.Eat();
        puppy.Bark();
        puppy.Weep();

        Cat cat = new Cat();
        cat.Eat();
        cat.Meow();

    }
}
