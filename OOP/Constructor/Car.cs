using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_
{
    public class Car
    {
        public string make;
        public string model;
        public int year;
        public string color;
        public int topspeed;
        public int horsepower;

        // this is what a constructor looks like:
        public Car(string make, string model, int year, string color, int topseed, int horsepower)
        {
            this.make = make;
            this.model = model;
            this.year = year;
            this.color = color;
            this.topspeed = topseed;
            this.horsepower = horsepower;
        }

        public void Drive()
        {
            Console.WriteLine($"You drive the {color} {year} {make} {model}.");
        }
    }
}
