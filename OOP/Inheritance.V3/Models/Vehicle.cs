using System;

namespace Inheritance.V3.Models
{
    public class Vehicle //Base class
    {
        public string Make { get; set; }
        public string Model { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle starting...");
        }

        public void Stop()
        {
            Console.WriteLine("Vehicle stopping...");
        }
    }
}
