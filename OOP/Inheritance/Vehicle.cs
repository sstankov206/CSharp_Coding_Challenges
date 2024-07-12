using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Inheritance
{
    public class Vehicle
    {
        public int wheels;
        public int topspeed;
        public int horsepower;
        public string make;
        public string model;

        public Vehicle()
        {
            this.wheels = wheels;
            this.topspeed = topspeed;
            this.horsepower = horsepower;
            this.make = make;
            this.model = model;
        }

        public virtual string Travel()
        { return $"You are traveling in the {make} {model}."; }
    }

   
}
