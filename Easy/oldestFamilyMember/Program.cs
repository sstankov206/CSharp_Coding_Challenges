using oldestFamilyMember;
using System;
class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter number of people in your family: ");
        int input = int.Parse(Console.ReadLine());
        Family family = new Family();
        
        for (int i = 0; i < input; i++) 
        {
            string[] inputParams = Console.ReadLine().Split(" ");  
            Person person = new Person(inputParams[0], int.Parse(inputParams[1])); //name, age
            family.AddMember(person);
            
        }
        Console.WriteLine(family.GetOldestMember().ToString());
    }

}