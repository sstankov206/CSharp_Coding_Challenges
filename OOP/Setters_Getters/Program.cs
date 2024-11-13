/* Setters & Getters Comparison:
 * - No Setters: Properties are read-only. You can only
 *set their values through the constructor or 
 *internally in the class, and they cannot be changed
 *externally.
* - Private Setters: Properties are read-write, but 
the setter is private, meaning the value can only
be modified within the class, not externally.
* - Public Setters: Properties are read-write, 
* and both the getter and setter are accessible
* from outside the class.
* 
*/

using System;
using Setters_Getters.Models;
class Program
{
    static void Main(string[] args)
    {
        // Create instances of the classes
        var noSetter = new NoSetterExample("Alice");
        var privateSetter = new PrivateSetterExample("Bob");
        var publicSetter = new PublicSetterExample { Name = "Charlie" };

        // Display initial values
        noSetter.DisplayInfo();
        privateSetter.DisplayInfo();
        publicSetter.DisplayInfo();

        // Try modifying the properties and observe behavior
        // noSetter.Name = "New Name"; // Error: Cannot modify read-only property
        // privateSetter.Name = "New Bob"; // Error: Cannot access private setter

        // Modify privateSetter's name using a method inside the class
        privateSetter.ChangeName("New Bob");
        privateSetter.DisplayInfo();

        // Modify publicSetter's name directly
        publicSetter.Name = "New Charlie";
        publicSetter.DisplayInfo();

        // Demonstrating the difference in setter accessibility
        Console.WriteLine("Demonstrating difference in setter accessibility complete.");
    }
}
