using System;
using System.Runtime.ExceptionServices;
using System.Threading.Channels;

namespace Lab.Encapsulation.Ex1.SortPeopleByNameAge
{
    public class Person
    {
        //properties (public) with private setters:

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        //constructor:

        public Person(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        //override ToString() :

        public override string ToString()
        {
            return ($"{this.FirstName} {this.LastName} is {this.Age} years old.");
        }
    }
}
