using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorOverLoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(1, "Ajay", "Rathod");
            Student s2 = new Student(1, "Ajay", "Jathod");
            if (s1 == s2)
            {
                Console.WriteLine($"S1 & S2 are EQUAL");
            }
            else
            {
                Console.WriteLine($"S1 & S2 are NOT EQUAL");
            }


            Student s3 = new Student(1, "Ajay", "Rathod");
            Student s4 = new Student(2, "Vishal", "Jathod");

            Student s5 = s3 + s4;
            Console.WriteLine($"{s5.RollNumber} :{s5.FirstName}:{s5.LastName}");

            Console.ReadLine();
        }
    }
}
