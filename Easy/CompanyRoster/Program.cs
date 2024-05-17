/* Company Roster

Define a class Employee that holds the following information: a name, a salary and a department.

Your task is to write a program, which takes N lines of employees from the console, calculates 
the department with the highest average salary and prints for each employee in that department
his name and salary – sorted by salary in descending order. The salary should be rounded to 
two digits after the decimal seperator.

Example:

INPUT: 
4

Pesho 120.00 Development

Toncho 333.33 Marketing

Ivan 840.20 Development

Gosho 0.20 Nowhere

OUTPUT:

Highest Average Salary: Development 
Ivan 840.20 
Pesho 120.00

*/

using CompanyRoster;
using System;
using System.Diagnostics.Contracts;
using System.Runtime.CompilerServices;

class Program
{
    public static void Main(string[] args)
    {
        //reading input:
        int input = int.Parse(Console.ReadLine());

        var organization = new Organization();

        //Todo loop: 
        for (int i = 0; i < input; i++)
        {
            // todo read each iteration and split input, also parse:
            string[] roster = Console.ReadLine().Split(" ");
            organization.CreateDepartments(roster);

        }
        
        //printing output:
        Console.WriteLine(organization.GetDeptHighAvgSalary().ToString());

    }
}