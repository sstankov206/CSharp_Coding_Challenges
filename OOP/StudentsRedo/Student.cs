using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsRedo
{
    public class Student
    {
        //properties:
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Grade { get; set; }

        //constructor:
        public Student(string firstName, string lastName, double grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;         
        }
        //override toString, setting up format for printing the output:
        public override string ToString() 
        {
            return $"{FirstName} {LastName}: {Grade:f2}";
        }
    }
}
