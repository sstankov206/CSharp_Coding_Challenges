/* Create a function that takes an array of 10 numbers (between 0 and 9) and returns a string of those numbers formatted as a phone number (e.g. (555) 555 - 5555).

Examples:

FormatPhoneNumber([1, 2, 3, 4, 5, 6, 7, 8, 9, 0]) ➞ "(123) 456-7890"

FormatPhoneNumber([5, 1, 9, 5, 5, 5, 4, 4, 6, 8]) ➞ "(519) 555-4468"

FormatPhoneNumber([3, 4, 5, 5, 0, 1, 2, 5, 2, 7]) ➞ "(345) 501-2527"

*/

using System;
class Program {
    public static void Main(string[] args) {

        Console.WriteLine("Enter numbers in range 0-9 :");
        //reading input:
        var phoneNumber = Console.ReadLine();
            
        //check for right length for the phone number entered:
        if (phoneNumber.Length != 10) {
            Console.WriteLine("Invalid phone number"); 
        }

        //printing output:
        Console.WriteLine($"Phone number entered is : ({phoneNumber[0..3]}) {phoneNumber[3..6]}-{phoneNumber[6..10]}");
    
    
    
    
    }
}