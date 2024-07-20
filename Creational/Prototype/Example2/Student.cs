using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

namespace Design_Patterns.Creational.Prototype.Example2
{

    
    public class Student : IDeepCopy<Student>
    {
        public string[] subjects; //{ get; set; }

        public StudentInfo StudentInfo; //{ get; set; }

        public string[] Subjects 
        { get { return subjects; }
          set { subjects = value; }
        }

        public Student() {}

        public Student(string[] subjectss, StudentInfo studentInfo)
        {
            Subjects = subjectss;
            this.StudentInfo = studentInfo;
        }

        public override string ToString()
        {
            return $"{string.Join(", ", Subjects)}, {StudentInfo.FirstName} {StudentInfo.LastName}";
        }

        public Student DeepCopy()
        {
            return new Student( (string[]) Subjects.Clone(), StudentInfo.DeepCopy());
        }
    }
}