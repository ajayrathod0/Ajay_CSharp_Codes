using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace constuctor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Student s1 = new Student();  // default constructor calling---------------------------------------
            s1.details();

            Student s2 = new Student();
            s2.RollNumber = 10;
            s2.FirstName = "Ajay";
            s2.LastName = "Rathod";
            s2.details();


            //object intialize syntax
            Student s3 = new Student()    //parametic Constructor calling-----------------------------------------------------
            {
                RollNumber = 11,
                FirstName = "Vishal",
                LastName = "Jathod"
            };
            s3.details();

            // initialize method 
           *//* Student s4 = new Student();
            s4.initialize(14,"yatharth","jathod");  
            s4.details();

           *//*

            Student s5 = new Student(15,"nikhil","Jathod");
            s5.details();


            //copy data
            Student s7 = s2;
            s7.details();

            Student s8 = new Student();
            s8.RollNumber = s2.RollNumber;
            s8.FirstName = s2.FirstName;
            s8.LastName = s2.LastName;
            s8.details();


            Student s9 = new Student(s2); //copy Constuctor calling--------------------------------------------------
            s9.details();*/

            //Student s10 = new Student();
            //s10.details();



            // static Constructor ----------------------------------------------------------

            Student s20 = new Student();
            s20.details();
            Console.WriteLine($"Courses {Student.CourseName}");

            Console.ReadLine();
        }
    }
}
