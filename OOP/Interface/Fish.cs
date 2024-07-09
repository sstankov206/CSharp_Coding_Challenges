using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    public class Fish : Program.IPredator, Program.IPrey
    {
        public void Flee()
        {
            Console.WriteLine("The fish swims away!");
        }

        public void Hunt()
        {
            Console.WriteLine("The fish is searching for smaller fish.");
        }
    }
}
