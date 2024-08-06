using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest
{
    public class TestPaper: ITestpaper
    {
        public TestPaper(string subject, string[] markScheme, string passMark)
        {
            this.Subject = subject;
            this.MarkScheme = markScheme;
            this.PassMark = passMark;
        }

        //  string Subject
        public string Subject { get; set; }
        // string[] MarkScheme
        public string[] MarkScheme { get; set; }
        // string PassMark
        public string PassMark { get; set; }
    }
}
