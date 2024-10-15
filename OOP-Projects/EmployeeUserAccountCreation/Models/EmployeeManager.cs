using System;
using System.Collections.Generic;

namespace EmployeeUserAccountCreation.Models
{
   //This class will managet the list of employees and handle account creation.
    public class EmployeeManager
    {
        private List<Employee> employees;

        public EmployeeManager()
        { 
            employees = new List<Employee>();
        }

        public void CreateEmployee(string name, string email, string position)
        {
            Employee employee = new Employee(name, email, position);
            employees.Add(employee);
            Console.WriteLine("Employee account create successfully.");
        }

        public void ShowEmployees()
        {
            if (employees.Count == 0)
            {
                Console.WriteLine("No employees found.");
                return;
            }

            foreach (var employee in employees)
            {
                Console.WriteLine(employee);
            }
        }
    }
}
