using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    public class Hawk : Program.IPredator
    {
        public void Hunt()
        {
            Console.WriteLine("The hawk is searching for food.");
        }
    }
}
