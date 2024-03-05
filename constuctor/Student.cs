using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constuctor
{
    internal class Student
    {
        public int RollNumber;
        public string FirstName;
        public string LastName;
        public static string CourseName = "Dot net";


        //default constuctor-------------------------------------
        public Student()
        {
            // Console.WriteLine("default constuctor(less/intance constuctor)");
        }


        //parameter Constructor------------------------------------
        public Student(int rn, string fn, string ln) 
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;
        }

        //copy constructor---------------------------------------------
        public Student(Student a)
        {
            this.RollNumber = a.RollNumber;
            this.FirstName = a.FirstName;
            this.LastName = a.LastName;

        }

        static Student() {
            Console.WriteLine($"static Constructor called()");
            string CourseName;
        }
        public void details()
        {
            Console.WriteLine($"Rollnumber : {RollNumber} Full Name: {FirstName} {LastName} Course Name : {CourseName}");
        }

        public void initialize(int rn, string fn, string ln)
        {
            RollNumber = rn;
            FirstName = fn;
            LastName = ln;

        }

    }
}
