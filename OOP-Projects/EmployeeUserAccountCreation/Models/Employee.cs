using System;

namespace EmployeeUserAccountCreation.Models
{
    public class Employee
    {
        public string Name { get; private set; }
        public string Email { get; private set; }
        public string Position { get; private set; }

        public Employee(string name, string email, string position)
        {
            Name = name;
            Email = email; 
            Position = position;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Email: {Email}, Position: {Position}";
        }
    }
}
