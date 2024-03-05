using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            student s1 = new student();
            s1.Rollnumber = 2;
            s1.Name = "ajay";
            s1.City = "pune";

            s1.print();


            student s2 = new student();
            s2.Rollnumber = 5;
            s2.Name = "vishal";
            s2.City = "pune";
            student.cousename = "JAVA";
            s2.print();

            student s3 = new student();
            s3.Rollnumber = 5;
            s3.Name = "chetan";
            s3.City = "pune";
            s3.print();


            student s4 = new student();
            s4.inputCreate(3, "ganesh", "mumbai");
            s4.print();

            Console.ReadLine();
        }
    }

    class student
    {
        public int Rollnumber;
        public string Name;
        public string City;
        public static string cousename = "DOT NET";
        public void print()
        {

            Console.WriteLine($"rollnumber : {Rollnumber}  name : {Name}  city: {City}  courseName : {cousename} \n");
        }

        public void inputCreate(int Rn, string name, string city)
        {
            Rollnumber = Rn;
            Name = name;
            City = city;

        }
    }
}
