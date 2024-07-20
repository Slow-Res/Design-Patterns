using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Example2
{
    public class StudentInfo : IDeepCopy<StudentInfo>
    {
        public string FirstName { get; set; }
        public string LastName { get; set;}

        public StudentInfo(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public StudentInfo DeepCopy()
        {
            return new StudentInfo(FirstName, LastName);
        }
    }
}