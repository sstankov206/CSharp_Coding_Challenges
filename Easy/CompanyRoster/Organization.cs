using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyRoster
{
    public class Organization
    {
        public List<Department> Departments { get; set; }

        public Organization()
        {
            Departments = new List<Department>();
        }

        public void CreateDepartments(string[] arg)
        {
            Department? department1 = Departments.FirstOrDefault(x => x.Title == arg[2]);
            if (department1 != null)
            {

                department1.AddEmployee(arg[0], arg[1]);
            }
            else
            {
                var department = new Department(arg[2]);
                department.AddEmployee(arg[0], arg[1]);
                Departments.Add(department);
            }

        }

        public Department GetDeptHighAvgSalary()
        {
            return Departments
                 .OrderByDescending(x => x.GetAverageSalary())
                 .First();
        }
    }
}