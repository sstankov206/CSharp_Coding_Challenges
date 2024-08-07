﻿/* Your task is to write a program which allows teachers to create a multiple choice test
 * in a class called Testpaper and also be able to assign a minimum pass mark. 
 * The Testpaper class should implement the ITestpaper interface given in the code 
 * template which has the following properties:

string Subject
string[] MarkScheme
string PassMark

*/

using MultipleChoiceTest;
using System;
class Program
{
    public static void Main(string[] args)
    {
        var paper1 = new TestPaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
        var paper2 = new TestPaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
        var paper3 = new TestPaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");

        var student1 = new Student();
        var student2 = new Student();

        Console.WriteLine(student1.TestsTaken);
        student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
        Console.WriteLine(student1.TestsTaken);

        Console.WriteLine(student2.TestsTaken);
        student2.TakeTest(paper2, new string[] { "1C", "2D", "3A", "4C" });
        student2.TakeTest(paper3, new string[] { "1A", "2C", "3A", "4C", "5D", "6C", "7B" });
        Console.WriteLine(student2.TestsTaken);






    }


}