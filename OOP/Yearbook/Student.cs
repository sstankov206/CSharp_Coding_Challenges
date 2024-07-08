using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yearbook
{
    public abstract class Student(string firstName, string lastName, int grade, string photo)
    {
        public string firstName { get; set; } = firstName;
        public string lastName { get; set; } = lastName;
        public virtual int grade { get; set; }
        public virtual string photo { get; set; } //default for grades 9 - 11; grade 12 will have "senior picture"

    }
}
