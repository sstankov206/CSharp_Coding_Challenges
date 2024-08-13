using System;
using System.Text.RegularExpressions;

namespace MultipleChoiceTest
{
    public class Student : IStudent //Student class inherits from IStudent interface
    {
        public Stack<string> TestTaken { get; set; } = [];

        public void TakeTest(ITestpaper paper, string[] answers)
        {
            int passedAnswers = 0;
            foreach (var answer in paper.MarkScheme)
            {
                if (answers.Contains(answer))
                {
                    passedAnswers += 1;
                }
            }

            var passedAnswersInPercents = (passedAnswers * 100) / paper.MarkScheme.Length;


            TestTaken.Push($"{paper.Subject}: {isPassed(passedAnswersInPercents, Regex.Match(paper.PassMark, @"[\d]{1,}"))} ({passedAnswersInPercents}%)");

        }

        private string isPassed(int passedAnswersInPercents, Match match)
        {
            if (passedAnswersInPercents >= Convert.ToInt32(match.Value))
            {
                return "Passed!";
            }
            return "Failed";
        }
        public string GetTakeTest()
        {
            if (!TestTaken.Any())
            {
                return "No tests taken";
            }
            return string.Join(", ", this.TestTaken);
        }
    }
}