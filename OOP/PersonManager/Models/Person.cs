using System;
using System.Collections.Generic;
using System.Linq;


namespace PersonManager.Models
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }   
        public string City { get; set; }

        public Person(string name, int age, string city)
        {
            Name = name;
            Age = age;
            City = city;
        }

        public override string ToString()
        {
            return $"{Name}, Age: {Age}, City: {City}";
        }

    }
}
