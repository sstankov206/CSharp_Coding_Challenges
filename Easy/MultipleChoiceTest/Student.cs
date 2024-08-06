using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest
{
    public class Student : IStudent
    {
        // string[] TestsTaken
        public List<string> TestsTaken { get; set; } = new List<string>();

        // void TakeTest(ITestpaper paper, string[] answers)
        public List<string> TakeTest(ITestpaper paper, string[] answers)
        {
            if (answers.Length == 0)
            {
                this.TestsTaken.Add( "No tests taken" );
            }
            else
            { 
                int successCount = 0;
                for (int i = 0; i < answers.Length; i++)
                {
                  if(  paper.MarkScheme[i]== answers[i]) { successCount++; }
                }


                double successPercentege = successCount / paper.MarkScheme.Length * 100;
                string abv = "";
                if (int.Parse(paper.PassMark.Replace("%",string.Empty))<= successPercentege)
                {
                    abv = "Failed";
                }
                    TestsTaken.Add($"{paper.Subject}: {abv}! ({successPercentege}%)");
            }
            return this.TestsTaken;
        }
    }
}
