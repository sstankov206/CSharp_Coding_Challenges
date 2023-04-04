/* Create a function that takes voltage and current and returns the calculated power.
 * 
 * power = voltage * current
 * 
 */

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter amount for VOLTAGE:");
        int voltage = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter amount for CURRENT:");
        int current = int.Parse(Console.ReadLine());

        //printing output:
        Console.WriteLine(CircuitPower(voltage, current));

    }

    //Method for calculating the Circuit's Power:
    public static int CircuitPower(int voltage, int current)
    {return (voltage * current); }
}