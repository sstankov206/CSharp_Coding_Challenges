using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters.Setters
{
    public class Car
    {
        private int speed;

        public Car(int speed)
        {
            Speed = speed;
        }

        //Properties (getters & setters):
        public int Speed
        {
            get { return speed; } //read
            set //write
            {
                if (speed > value)
                {
                    speed = 500;
                }
                else
                {
                    speed = value;
                }
            }

        }
    }
}
