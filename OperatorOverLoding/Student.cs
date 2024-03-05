using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoding
{
    public class Student
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;

        public Student(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;

        }

        public static bool operator ==(Student s1, Student s2)
        {
            return s1.RollNumber == s2.RollNumber &&
                s1.FirstName == s2.FirstName &&
                s1.LastName == s2.LastName;

        }

        public static bool operator !=(Student s1, Student s2)
        {
            return s1.RollNumber != s2.RollNumber &&
                s1.FirstName != s2.FirstName &&
                s1.LastName != s2.LastName;
        }

        public static Student operator +(Student s3, Student s4)
        {
            int rn = s3.RollNumber + s4.RollNumber;
            string fn = s3.FirstName + "," + s4.FirstName;
            string ln = s3.LastName + "," + s4.LastName;

            return new Student(rn, fn, ln);
        }
    }
}
