using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generation_Operator
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region

            List<Student> students = new List<Student>()
            {
               new Student() { RollNumber = 1, Name="Ajay",   Age = 23 },
               new Student() { RollNumber = 2, Name="Vishal", Age = 30},
               new Student() { RollNumber = 3, Name="Kishor", Age = 28},
               new Student() { RollNumber = 4, Name ="Chetan",Age = 18 }
            };
            Console.WriteLine("@@@ All Student @@@");
            foreach (Student item in students)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber}  Name : {item.Name} Age : {item.Age}");
            }
            Console.WriteLine();


            Console.WriteLine(" Filtering Student Age 18 to 25 (foreach loop me if())");
            foreach (Student a in students)
            {
                if (a.Age >= 18 && a.Age <= 25)
                {
                    Console.WriteLine($"Roll number : {a.RollNumber} name : {a.Name} Age : {a.Age}");
                }
            }
            Console.WriteLine();


            //"where":-  Func<TSource, bool>
            // jiski Age 18 se 25 hai vo revoke honge

            Console.WriteLine("**** 18 to 25 Age Student (using Lambda Expression)****");
            var result = students.Where(s => s.Age >= 18 && s.Age <= 25);
            foreach (Student item in result)
            {
                Console.WriteLine($"{item.RollNumber}  {item.Name} {item.Age}");
            }
            Console.WriteLine();



            //select all 
            Console.WriteLine("*** ALL STUDENTS (LINQ se sql query)***");
            var result1 = from s in students
                          select s;
            foreach (Student aj in result1)
            {
                Console.WriteLine($"{aj.RollNumber} {aj.Name} {aj.Age}");
            }
            Console.WriteLine();//space ke liye



            Console.WriteLine("All Student (Lambda Expression se)");
            var result3 = students.Select(s => s);

            foreach (Student item1 in result3)
            {
                Console.WriteLine($"{item1.RollNumber}  {item1.Name}  {item1.Age}");
            }
            Console.WriteLine();//space ke liye



            Console.WriteLine("OrderBy name (Linq sql query se)");
            var result4 = from s in students
                          orderby s.Name
                          select s;
            foreach (Student a1 in result4)
            {
                Console.WriteLine($"{a1.RollNumber}  {a1.Name}  {a1.Age}");
            }
            Console.WriteLine();


            Console.WriteLine("Orderby Name (Lambda Expression se)");
            var result5 = students.OrderBy(s => s.Name);
            foreach (Student a2 in result3)
            {
                Console.WriteLine($"{a2.RollNumber}  {a2.Name}  {a2.Age}");
            }



            #endregion  
            
            Console.ReadLine();
        }


    }
    public class Student
    {
        public int RollNumber { set; get; }
        public string Name { set; get; }
        public int Age { set; get; }
    }
}
