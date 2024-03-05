using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Sort method

            /*  List<int> numbers = new List<int>() { 2, 4, 5, 181, 34, 1, 42, 6, 9 };
              numbers.Sort();
              Console.WriteLine(numbers.Count);//9
              foreach (int item in numbers)
              {
                  Console.Write($"{item} ");//1 2 4 5 6 9 34 42 181
              }
              Console.WriteLine();

              numbers.Sort();

              List<string> alpa = new List<string>() { "K", "W", "A", "C", "B" };
              alpa.Sort();
              foreach (string item in alpa)
              {
                  Console.Write($"{item} ");//A B C K W
              }
              Console.WriteLine();



              Console.WriteLine("__________________________________________________________________");


              Console.WriteLine("All Student");
              Student s1 = new Student();
              var students = s1.GetStudent();

              foreach (Student item in students)
              {
                  Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age : {item.Age}  City : {item.City}");
              }
              Console.WriteLine();




              Console.WriteLine(" students.Sort(o)");

              IComparer<Student> o = new StudentHelper();
              //Icomparer ek interface hai ,interface ka object nahi banta isliye class bana kar impliment karenge
              students.Sort(o);

              foreach (var item in students)
              {
                  Console.WriteLine($"{item.RollNumber}  {item.Name}  {item.Age}  {item.City}");//name se sort ho jayenge
              }
              Console.WriteLine();



              students.Sort(0, 2, o);//limited record sort karenga 0 index se 2 count tak 
              Console.WriteLine("students.Sort(0, 2, o)");
              foreach (Student item in students)
              {
                  Console.WriteLine($" {item.RollNumber}  {item.Name} {item.Age} {item.City}");
              }
              Console.WriteLine();//space





              Console.WriteLine("Sort((x, y) => x.Age.CompareTo(y.Age))");
              //Comparison<Student> com = (x, y) => y.City.CompareTo(x.City);
              //students.Sort(com);



              //students.Sort((x, y) => x.Age.CompareTo(y.Age));//Age se sort karenga
              //students.Sort((x, y) => x.City.CompareTo(y.City));//City se sort honge
              students.Sort((x, y) => y.City.CompareTo(x.City));//descending me city se sort honge

              foreach (var item in students)
              {
                  Console.WriteLine($"{item.RollNumber} {item.Name} {item.Age}  {item.City}");
              }
              Console.WriteLine();

  */
            #endregion Sort Method

            #region GroupBy

            Student s1 = new Student();
            var students = s1.GetStudent();


            // var groups = students.GroupBy(s => s.City);

            var groups = students.ToLookup(s => s.City);

            foreach (var item in groups)
            {
                Console.WriteLine($"{item.Key} {item.Count()} ");//

                foreach (var a in item)
                {
                    Console.WriteLine($"{a.City}");
                }
                Console.WriteLine("--------------------------------------------------");
            }




            #endregion

            Console.ReadLine();
        }
    }


    public class Student : IComparable
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }



        public int CompareTo(object obj)
        {
            Student s = obj as Student;

            /* if (this.Age > s.Age)
             {
                 return 1;
             }
             else if (this.Age < s.Age)
             {
                 return -1;
             }
             else
             {
                 return 0;
             }*/

            return this.Age.CompareTo(s.Age);
        }


        public List<Student> GetStudent()
        {
            return new List<Student>()
            {
                new Student(){ RollNumber = 1 , Name = "Ajay", Age = 20 , City = "Indore" },
                new Student(){ RollNumber = 2 , Name = "Vishal", Age = 25 , City = "Indore" },
                new Student(){ RollNumber = 3 , Name = "Yatharth", Age = 18 , City = "Mumbai" },
                new Student(){ RollNumber = 4 , Name = "Vikul", Age = 30 , City = "Pune" },
            };
        }
    }


    public class StudentHelper : IComparer<Student>
    {
        public int Compare(Student x, Student y)
        {
            return x.Name.CompareTo(y.Name);
        }
    }
}
