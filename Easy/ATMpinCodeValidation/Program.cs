/* ATM machines allow 4 or 6 digit PIN codes and PIN codes cannot contain anything but exactly 4 digits
 * or exactly 6 digits. Your task is to create a function that takes a string and returns true if the PIN 
 * is valid and false if it's not.
 * 
 * Examples:
ValidatePIN("1234") ➞ true

ValidatePIN("12345") ➞ false

ValidatePIN("a234") ➞ false

ValidatePIN("") ➞ false

Notes:
Some test cases contain special characters.
Empty strings must return false.

solution by me, sstankov.

*/

using System;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter PIN:");
        //reading input:
        string pin = Console.ReadLine();
        
        //invoking the PIN Validation Method & printing input:
        Console.WriteLine(ValidatePIN(pin));
    
    }

    //method that handles the Validation of the PIN:
    public static bool ValidatePIN(string pin)
    {

        //validation for PIN being exactly 4 digits OR exactly 6 digits long, AND containing ONLY digits:

        return (pin.Length == 4 || pin.Length == 6) && pin.All(char.IsDigit);

    }
}