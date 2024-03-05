using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aggeegation_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            var a = numbers.Aggregate((i, j) => i + j);
            Console.WriteLine(a);//45 = all numbers equals

            var a1 = numbers.Count();
            Console.WriteLine(a1);//9

            var a2 = numbers.Min();
            Console.WriteLine(a2);//1

            var a3 = numbers.Max();
            Console.WriteLine(a3);//9

            var a4 = numbers.Sum();
            Console.WriteLine(a4);//45

            var a5 = numbers.LongCount();
            Console.WriteLine(a5);//9

            var a6 = numbers.Average();
            Console.WriteLine(a6);//5

            var z = numbers.Contains(5);
            Console.WriteLine(z);//true


            // Any() -> it returns true even any one item matches given condition
            var z2 = numbers.Any(s => s > 5);
            Console.WriteLine(z2); //true


            // All() -> it checks whether all items matches given condition
            var z3 = numbers.All(s => s > 10);
            Console.WriteLine(z3);//false



            Student s1 = new Student() { FirstName = "Ajay", LastName = "Rathod" };
            Student s2 = new Student() { FirstName = "Vikul", LastName = "Rathod" };
            Student s3 = new Student() { FirstName = "Vishal", LastName = "Jathod" };

            List<Student> students = new List<Student> { s1, s2, s3 };

            Student s4 = new Student() { FirstName = "Vihaan", LastName = "Rathod" };

            /*   var result1 = students.Contains(s4);
               Console.WriteLine(result1);//false

               bool result2 = students.Contains(s4, new StudentHelper());
               Console.WriteLine(result2);
   */

            Console.ReadLine();
        }
    }

    class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class StudentHelper : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.FirstName.Equals(y.FirstName) &&
            x.LastName.Equals(y.LastName);
        }

        public int GetHashCode(Student obj)
        {
            return obj.FirstName.GetHashCode() ^ obj.LastName.GetHashCode();
        }
    }
}
