/* Simple app with C# OOP and lambda expressions,
 * that manages a list of objects of the 'Person' class.
 * It performs the following operations:
 * - Adding a 'Person'
 * - Displaying a list of people.
 * - Soring the list based on different criteria
 * (name, age,etc., using lambda expressions).
 * 
 */

using System;
using System.Linq;
using PersonManager.Models;
class Program
{
    static void Main(string[] args)
    {
        // Instantiate the PersonManager
        PersonManager.Models.PersonManager manager = new PersonManager.Models.PersonManager();

        // Add some people to the list
        manager.AddPerson(new Person("Alice", 30, "New York"));
        manager.AddPerson(new Person("Bob", 25, "Los Angeles"));
        manager.AddPerson(new Person("Charlie", 35, "Chicago"));
        manager.AddPerson(new Person("David", 28, "New York"));
        manager.AddPerson(new Person("Eva", 22, "Los Angeles"));

        // Display the people list
        manager.DisplayPeople();

        // Sort by name and display
        manager.SortByName();

        // Sort by age and display
        manager.SortByAge();

        // Filter by city "Los Angeles" and display
        manager.FilterByCity("Los Angeles");

        Console.ReadLine(); // Wait for user inpute before closing
    }
}
