/* Description: This application's purpose is to showcase a simple C#
 * application, that implements OOP principles and is able to 
 * create new emlpoyee accounts for a fictinal firm, and assign
 * employee attributes sich as name, email, and job position
 */

using System;
using EmployeeUserAccountCreation.Models;
class Program
{
    static void Main(string[] args)
    {
        EmployeeManager employeeManager = new EmployeeManager();

        while (true)
        {
            Console.WriteLine("\nEmployee Account Creation System");
            Console.WriteLine("1. Create Employee Account");
            Console.WriteLine("2. Show All Employees");
            Console.WriteLine("3. Exit");
            Console.Write("Choose an option: ");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Console.Write("Enter employee name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter employee email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter employee position: ");
                    string position = Console.ReadLine();
                    employeeManager.CreateEmployee(name, email, position);
                    break;

                case "2":
                    employeeManager.ShowEmployees();
                    break;

                case "3":
                    return;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}
