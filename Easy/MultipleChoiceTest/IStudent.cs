using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleChoiceTest
{
    public interface IStudent
    {
        public string[] TestsTaken { get; set; }

        List<string> TakeTest(ITestpaper paper, string[] answers);
        string TestsTaken(ITestpaper paper, string[] answers);
    }
}
