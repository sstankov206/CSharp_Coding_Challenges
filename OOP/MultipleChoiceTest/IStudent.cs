using System;

namespace MultipleChoiceTest
{
    public interface IStudent
    {
        Stack<string> TestTaken { get; set; }
        void TakeTest(ITestpaper paper, string[] answers);
    }
}