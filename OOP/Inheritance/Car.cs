using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //this is what inheritance looks like:
    public class Car : Vehicle
    {
        public int wheels;
        public int topspeed;
        public int horsepower;
        public string make;
        public string model;
        public int year;
        public string color;

        public Car(int wheels, int topspeed, int horsepower, string make, string model, int year, string color)
        {
            this.wheels = wheels;
            this.topspeed = topspeed;
            this.horsepower = horsepower;
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
        }

        public override string Travel()
        {
            return $"You are traveling in the {color} {year} {make} {model}.";
        }

    }
}
