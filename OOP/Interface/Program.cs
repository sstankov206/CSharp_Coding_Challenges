// Exercise : Interface - practice using Interfaces in C#

using System;
using Interface_;

class Program
{
    static void Main(string[] args)
    {
        // creating instances of the objects:
        Rabbit rabbit = new Rabbit();
        rabbit.Flee();

        Hawk hawk = new Hawk();
        hawk.Hunt();

        Fish fish = new Fish();
        fish.Flee();
        fish.Hunt();

    }

    // interfaces:
    public interface IPrey
    {
        void Flee();

    }

    public interface IPredator
    {
        public void Hunt();

    }
}
