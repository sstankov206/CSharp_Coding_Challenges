/* Students

Write a program that receives a count of students - n and orders them by grade in descending order.
Each student should have a First name (string), a Last name (string) and a grade (a floating-point number).

Input

· On the first line, you are going to receive n - the count of students

· On the next n lines, you will be receiving the info about the students in the following format:

"{first name} {second name} {grade}"

Output

· Print each student in the following format: "{first name} {second name}: {grade}"

*/

using System;
using StudentsRedo;
class Program
{
    // 'n' - count of students, from input:
    public static void Main(string[] args)
    {
       //list that will be used to store the students:
        List<Student> students = new List<Student>();

        int studentsCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < studentsCount; i++)
        {
            var studentInfo = Console.ReadLine().Split().ToArray(); //ex: Lakia Eason 3.90
            //creating new student entry:
            Student student = new Student(studentInfo[0], studentInfo[1], double.Parse(studentInfo[2]));
            students.Add(student); //adds each newly created student to the list "students"
        }

        //printing output:
        Console.WriteLine(String.Join(Environment.NewLine, students.OrderByDescending(x=>x.Grade)));


    }
}
