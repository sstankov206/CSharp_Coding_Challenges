/* Your task is to write a program which allows teachers to create a multiple choice test in
 * a class called Testpaper and also be able to assign a minimum pass mark. The Testpaper 
 * class should implement the ITestpaper interface given in the code template 
 * which has the following properties:

string Subject
string[] MarkScheme
string PassMark
Interfaces do not define constructors for classes which implement them so you will need
to add a constructor method which takes the parameters (string subject, string[] markScheme, string passMark).

As well as that, we need to create student objects to take the test itself! 
Create another class called Student which implements the given IStudent 
interface which has the following members:

string[] TestsTaken
void TakeTest(ITestpaper paper, string[] answers)

*/

using System;
using MultipleChoiceTest;
class Program
{
    static void Main(string[] args)
    {
        var paper1 = new Testpaper("Maths", new string[] { "1A", "2C", "3D", "4A", "5A" }, "60%");
        var paper2 = new Testpaper("Chemistry", new string[] { "1C", "2C", "3D", "4A" }, "75%");
        var paper3 = new Testpaper("Computing", new string[] { "1D", "2C", "3C", "4B", "5D", "6C", "7A" }, "75%");
        var student1 = new Student();
        var student2 = new Student();


        Console.WriteLine(student1.GetTakeTest());
        student1.TakeTest(paper1, new string[] { "1A", "2D", "3D", "4A", "5A" });
        Console.WriteLine(student1.GetTakeTest());// { "Maths: Passed! (80%)" }

        student2.TakeTest(paper2, ["1C", "2D", "3A", "4C"]);
        student2.TakeTest(paper3, ["1A", "2C", "3A", "4C", "5D", "6C", "7B"]);
        Console.WriteLine(student2.GetTakeTest());// { "Chemistry: Failed! (25%)", "Computing: Failed! (43%)" }
    }
}