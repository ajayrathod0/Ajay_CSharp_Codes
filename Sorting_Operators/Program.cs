using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sorting_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Simple Type Sorting
            /*
                        List<int> list = new List<int>()
                        { 12,2,45,14,332,5,7,50 };
                        Console.WriteLine("Origernal Numbers");
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();

                        //number reverse()
                        list.Reverse();
                        Console.WriteLine("Reverse Number");
                        foreach (var item in list)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();//space ke liye




                        //OrderBy() by default assending me sort karke denga
                        Console.WriteLine("OrderBy()");
                        var result = list.OrderBy(a => a);
                        foreach (var item in result)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();


                        //OrderByDescending number ko descending me return karenga
                        Console.WriteLine("OrderByDescending()");
                        var result1 = list.OrderByDescending(s => s);
                        foreach (var item in result1)
                        {
                            Console.Write($"{item} ");
                        }
            */

            #endregion

            #region Complex Type Sorting


            Student s = new Student();
            var students = s.GetStudent();

            Console.WriteLine("*** All Students ***");
            foreach (Student item in students)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age: {item.Age}" +
                    $"City : {item.City} ");
            }
            Console.WriteLine();


            Console.WriteLine("Order By city");
            //   var result = students.OrderBy(a => a.City);//city se sort karenga //"method systax  se"
            var result = from sss in students //"Query systax se"
                         orderby sss.City
                         select sss;

            foreach (Student item in result)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age: {item.Age}" +
                    $"City : {item.City} ");
            }
            Console.WriteLine();//space



            Console.WriteLine("OrderByDescending()");
            var result1 = students.OrderByDescending(a => a.Name);//Name ko descending order me return karenga
            foreach (Student item in result1)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age: {item.Age}" +
                    $"City : {item.City} ");
            }
            Console.WriteLine();


            //City ko sort karenga ascending me jo commen city hongi use Age se sort karenga
            //ThenBy akela nahi aata jo pahale sort huva hai usi par apply kar sakte hai
            //by default yah ascendind me sort karta hai

            Console.WriteLine("OrderBy(d => d.City).ThenBy(a=>a.Age)");
            var result2 = students.OrderBy(d => d.City).ThenBy(a => a.Age);
            foreach (Student item in result2)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age: {item.Age}" +
                    $"City : {item.City} ");
            }
            Console.WriteLine();


            //City ko sort karenga ascending me jo commen city hongi use Name se sort karenga descending me
            Console.WriteLine("OrderBy(z => z.City).ThenByDescending(w => w.Name)");
            var result3 = students.OrderBy(z => z.City).ThenByDescending(w => w.Name);
            foreach (Student item in result3)
            {
                Console.WriteLine($"Roll Number : {item.RollNumber} Name : {item.Name} Age: {item.Age}" +
                    $"City : {item.City} ");
            }
            Console.WriteLine();



            #endregion

            Console.ReadLine();
        }
    }

    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string City { get; set; }


        public List<Student> GetStudent()
        {
            return new List<Student>()
            {
                new Student() { RollNumber = 1, Name = "Ajay", Age = 23, City = "Pune" },
                new Student() { RollNumber = 2, Name = "Vishal", Age = 25, City = "Mumbai" },
                new Student() { RollNumber = 3, Name = "Nikhil", Age = 18, City = "Pune" },
                new Student() { RollNumber = 4, Name = "Yathrth", Age = 15, City = "indore" }
            };
        }
    }
}
