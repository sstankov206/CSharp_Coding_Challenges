using System;

namespace LibrarySystem.Models
{
    public class Member
    {
        public string Name { get; set; }
        public int MemberId { get; set; }

        public Member(string name, int memberId)
        {
            Name = name;
            MemberId = memberId;
        }

        public override string ToString()
        {
            return $"{Name} (ID: {MemberId})";
        }
    }
}
