using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface_
{
    public class Rabbit : Program.IPrey
    {
        public void Flee() 
        {
            Console.WriteLine("The rabbit runs away!");
        }
    }
}
