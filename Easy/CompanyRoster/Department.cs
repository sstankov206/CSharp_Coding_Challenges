using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    public class Department
    {
        public string Title { get; set; }
        public Department(string title)
        {
            this.Title = title;
            Employees = new List<Employee>();
        }
        public List<Employee> Employees { get; private set; }

        public decimal GetAverageSalary()
        {
            return Employees.Average(e => e.Salary);
        }

        public override string ToString()
        {
            return string.Join( "\r\n",Employees.OrderByDescending(s=>s.Salary).Select(x => x.ToString()));
        }

        public void AddEmployee(string employeeName,string salary)
        {
            Employees.Add(new Employee(employeeName,salary));

        
        }
    }


}
