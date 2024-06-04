// Exercise: Create student's gradebook using Dictinary.

using System;
using System.Security.Cryptography.X509Certificates;
class Program 
{
    public static void Main(string[] args) 
    {//enter number of students to record:
    int input = int.Parse(Console.ReadLine());

        //storing students in a dictionary:
        Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

        //for the total number of students, create the follwing keys and values:
        for (int i = 0; i < input; i++)
        {
            string student = Console.ReadLine(); //key - students
            double grades = double.Parse(Console.ReadLine());// value - grades
            students.Add(student, new List<double> { grades }); //adds each created student, and their grades

            //printing output
            foreach (var pair in students)
            {
                Console.WriteLine(pair.Key + ": " + string.Join(", ", pair.Value));
            }
        }

    }

}