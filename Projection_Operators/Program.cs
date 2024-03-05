using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projection_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* List<string> names = new List<string>() { "Ajay", "Vishal", "Vikul", "timru" };
             var result = names.Select(a => a.ToUpper());
             foreach (var item in result)
             {
                 Console.Write($"{item} ");//AJAY VISHAL VIKUL TIMRU
             }
             Console.WriteLine();


             var result1 = names.Select(a => a.Length);
             foreach (var item in result1)
             {
                 Console.Write($"{item} ");//4 6 5 5
             }
 */

            Student s = new Student();
            List<Student> students = s.GetStudents();

            // IEnumerable<string> names = students.Select(x => x.Name); //method sysntax se
            //IEnumerable<string> names = from s1 in students  //Quary sysntax se 
            //                            select s1.Name;

            /*            var shorts = students.Select(a => new { Name = a.Name, City = a.City });
                        foreach (var item in shorts)
                        {
                            Console.WriteLine(item);
                        }
                        Console.WriteLine();*/

            IEnumerable<List<string>> sub = students.Select(a => a.Subjects);
            foreach (var item in sub)
            {
                foreach (var result in item)
                {
                    Console.WriteLine($"{result}");
                }
            }
            Console.WriteLine();


            IEnumerable<string> subject = students.SelectMany(a => a.Subjects);
            foreach (var item in subject)
            {
                Console.WriteLine($"{item} ");
            }


            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }
        public List<string> Subjects { get; set; }



        public List<Student> GetStudents()
        {
            return new List<Student>()
            {
                 new Student(){ RollNumber = 1 , Name = "Ajay", Age = 20 , City = "Indore" ,Subjects = new List<string>(){"Java" , "SQL"} },
                new Student(){ RollNumber = 2 , Name = "Vishal", Age = 25 , City = "Indore" ,Subjects = new List<string>(){"C" , "C++"}},
                new Student(){ RollNumber = 3 , Name = "Yatharth", Age = 18 , City = "Mumbai" ,Subjects = new List<string>(){"DOT net" , "C#"}},
                new Student(){ RollNumber = 4 , Name = "Vikul", Age = 30 , City = "Pune" ,Subjects = new List<string>(){"Python" , "SQL"}},

            };
        }
    }
}
