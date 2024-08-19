/*  SALARY INCREASE:
 *  
 *  Refactor the project from the last lab - "Lab Encapsulation, Exercise 1: Sort People by Name & Age".
 *  
 *  Create objects of the class Person. Read their name, age, and salary from the console.
 *  Read the percentage of the bonus to every Person's salary.
 *  People younger than 30 get half the increase. 
 *  Expand Person from the previous task.

New properties and methods:
    • Salary: decimal
    • IncreaseSalary(decimal percentage)
*/

using System;
using Lab.Encapsulation.Ex2.SalaryIncrease;
class Program
{
    public static void Main(string[] args)
    {
        //creating user input:
        Console.WriteLine("How many people to enter? :");
        var lines = int.Parse(Console.ReadLine());

        var persons = new List<Person>();
        for (int i = 0; i < lines; i++)
        {
            var cmdArgs = Console.ReadLine().Split();
            var person = new Person(cmdArgs[0],
                                    cmdArgs[1],
                                    int.Parse(cmdArgs[2]),
                                    decimal.Parse(cmdArgs[3])); //records each person's first+last name, age & salary from user input.

            persons.Add(person); //adds each person to list
        }
        Console.WriteLine("Percentage % for salary increase :");
        var percentage = decimal.Parse(Console.ReadLine()); //reads percentage of salary increase from user input
        persons.ForEach(p => p.IncreaseSalary(percentage));
        persons.ForEach(p => Console.WriteLine(p.ToString())); //performs salary increase calculation, prints output in requested format.


    }
}


