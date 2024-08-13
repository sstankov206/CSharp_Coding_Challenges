using System;

namespace MultipleChoiceTest
{
    public interface ITestpaper
    {
        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }
    }
}
