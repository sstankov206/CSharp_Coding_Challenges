/* create a simple program that performs basic math, usch as adding/subtracting 2 integers. */

using System;

class Program
{

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a number: ");
        //creating integers from user input:
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number: ");
        int num2 = int.Parse(Console.ReadLine());

        //prompting user to select operation:
        Console.WriteLine("Enter which operation to perform - Add or Subtract?");
        string mathOperator = Console.ReadLine();
        //if the selected opration to perform is addition:
        if (mathOperator == "add" || mathOperator == "Add" || mathOperator == "ADD")
            //print the sum output:
            Console.WriteLine(num1 + num2);
        //otherwise print the output from the subtraction:
        else
            Console.WriteLine(num1 - num2);

    }
}