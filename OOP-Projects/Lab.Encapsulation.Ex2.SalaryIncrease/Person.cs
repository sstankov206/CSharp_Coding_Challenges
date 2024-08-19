using System;

namespace Lab.Encapsulation.Ex2.SalaryIncrease
{
    public class Person
    {
        //properties (public) with private setters:

        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }

        // new property for this exercise:

        public decimal Salary { get; private set; }

        //constructor, expanded to include new property - Salary:

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }

        //new method for this lab - IncreaseSalary
        public void IncreaseSalary(decimal percentage)
        {
            if (this.Age > 30) //if the person is over 30 years of age:
            {
                this.Salary += this.Salary * percentage / 100; //increase salary by provided percentage.
            }
            else //else if the person is <30 years of age:
            {
                this.Salary += this.Salary * percentage / 200; //increase salary by half of the percentage.
            }
        }

        //override ToString(), modified from last lab to include the methods and properties for this lab :

        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} receives {this.Salary} leva.";
        }
    }
}
