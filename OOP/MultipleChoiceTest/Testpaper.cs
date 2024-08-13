using System;

namespace MultipleChoiceTest
{
   public class Testpaper: ITestpaper //Tespaper class inherits from ITestpaper interface
    {
        //properties:

        public string Subject { get; set; }
        public string[] MarkScheme { get; set; }
        public string PassMark { get; set; }

        //constructor:
        public Testpaper(string subject, string[] markscheme, string passmark)
        {
            this.Subject = subject;
            this.MarkScheme = markscheme;
            this.PassMark = passmark;
        }
    }

}
