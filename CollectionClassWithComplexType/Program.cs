using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClassWithComplexType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 1, Name = "Ajay", City = "Indore" };
            Student s2 = new Student() { RollNumber = 2, Name = "Vishal", City = "Indore" };
            Student s3 = new Student() { RollNumber = 3, Name = "Rupesh", City = "Mumbai" };
            Student s4 = new Student() { RollNumber = 4, Name = "Yathart", City = "Pune" };

            #region List <Student>

            /* List<Student> students = new List<Student>();
             students.Add(s1);
             students.Add(s2);
             students.Add(s3);
             students.Add(s4);
             Console.WriteLine(students.Count);//4
             foreach (Student item in students)
             {
                 Console.WriteLine($"Studnet RollNumber : {item.RollNumber} Student Name :" +
                     $"{item.Name}  Studnet City : {item.City}");
             }

 */

            #endregion

            #region Dictionary <int(key) , Student(value)>

            Dictionary<int, Student> students = new Dictionary<int, Student>();
            students.Add(s1.RollNumber, s1);
            students.Add(s2.RollNumber, s2);
            students.Add(s3.RollNumber, s3);
            students.Add(s4.RollNumber, s4);

            foreach (KeyValuePair<int, Student> item in students)
            {
                Console.WriteLine($"students Keys : {item.Key} ");
                Student ss = item.Value;
                Console.WriteLine($"Roll Number : {ss.RollNumber} Name : {ss.Name} City : {ss.City}");
            }

            #endregion
            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { set; get; }
        public string Name { set; get; }
        public string City { set; get; }
    }
}
