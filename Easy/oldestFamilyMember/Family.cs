using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oldestFamilyMember
{
    public class Family
    {   //property:
        public List<Person> People { get; set; }
        
        //constructor:
        public Family()
        {
            People = new List<Person>();
        }

        //Todo ctor with args number of persons into family... that means the collection must be exact/fixed Count of peple.
        // TODO complete with list. Commit & push into main branch, later make new branch and replace List with Array

        //method for adding family members:
        public void AddMember(Person member)
        {
            this.People.Add(member);
        }

        //method for returning the oldest family member:
        public Person GetOldestMember()
        {
            Person? oldestPerson = this.People.OrderByDescending(p => p.Age).FirstOrDefault();
            return oldestPerson;
        }
    }

}
