// Practice: Create and display list of students and their subjects of study, using C# Dictionaries.

using System;

class Program
{
    public static void Main(string[] args)
    {//enter number of students to record:
        int input = int.Parse(Console.ReadLine());

        //storing students in a dictionary:
        Dictionary<string, List<string>> students = new Dictionary<string, List<string>>();

        //for the total number of students, create the following keys and values:
        for (int i = 0; i < input; i++)
        {
            string student = Console.ReadLine(); //key - students
            string subjects = Console.ReadLine();// value - subjects:
            students.Add(student, new List<string> {subjects}); //adds each created student, and their school subjects

            //printing output
            foreach (var pair in students)
            {
                Console.WriteLine(pair.Key + ": " + string.Join(", ", pair.Value));
            }
        }

    }

}