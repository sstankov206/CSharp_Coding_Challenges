using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonManager.Models
{
    public class PersonManager
    {
        private List<Person> people = new List<Person>();

        // Method to add a person
        public void AddPerson(Person person)
        {
            people.Add(person);
        }

        // Method to display all people
        public void DisplayPeople()
        {
            Console.WriteLine("People List:");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        // Method to sort people by name
        public void SortByName()
        {
            var sorted = people.OrderBy(p => p.Name).ToList();
            Console.WriteLine("\nSorted by Name:");
            foreach (var person in sorted)
            {
                Console.WriteLine(person);
            }
        }

        // Method to sort people by age
        public void SortByAge()
        {
            var sorted = people.OrderBy(p => p.Age).ToList();
            Console.WriteLine("\nSorted by Age:");
            foreach (var person in people)
            {
                Console.WriteLine(person);
            }
        }

        // Method to filter people by city using lambda expression
        public void FilterByCity(string city)
        {
            var filtered = people.Where(p => p.City.Equals(city, StringComparison.OrdinalIgnoreCase)).ToList();
            Console.WriteLine($"\nPeople from {city}:");
            foreach (var person in filtered)
            {
                Console.WriteLine(person);
            }
        }

    }
}
