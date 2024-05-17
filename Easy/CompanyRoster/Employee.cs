using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    public class Employee
    {

        //properties:
        public string Name{ get; set; }
        public decimal Salary{ get; set; }

        //constructor:
        public Employee(string name, string salary)
        {
            this.Name = name;
            this.Salary = decimal.Parse(salary);
        }

        //override toString() method, printing output:
        public override string ToString() 
        {
            return $"{this.Name} {this.Salary}"; 
        }
    }
}
