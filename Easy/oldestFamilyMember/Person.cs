using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace oldestFamilyMember
{
    public class Person
    {
        //properties:
        public string Name { get; set; }
        public int Age { get; set; }

        //constructor:
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.Name} {this.Age}";
        }
    }

}
