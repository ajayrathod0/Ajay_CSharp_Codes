using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Where()

            /* Student s1 = new Student();
             var students = s1.GetStudent();

             foreach (Student item in students)
             {
                 Console.WriteLine($"RollNumber : {item.RollNumber} Name : {item.Name} Age :{item.Age} City :{item.City}");
             }
             //------------------------------------------------------------------------------------------------------

             //City = pune hai vahi record return karenga method
             Console.WriteLine("Filtering city");
             var result = students.Where(s => s.City.Equals("Pune"));
             foreach (Student item in result)
             {
                 Console.WriteLine($"{item.RollNumber} {item.Name}  {item.Age} {item.City}"); // only pune wale record o/p me
             }


             //pune wale record or Age jiski 20 se kam hai unka record denga
             var result1 = students.Where(s => s.City.Equals("Pune") && s.Age <= 20);
             foreach (Student item in result1)
             {
                 Console.WriteLine($"{item.RollNumber} {item.Name} {item.Age} {item.City}");
             }

             //Using Quary 

             Console.WriteLine("Using Quary");
             var results = from ss in students
                           where ss.City.Equals("Pune") && ss.Age <= 20
                           select ss;
             foreach (Student item in results)
             {
                 Console.WriteLine($"{item.RollNumber} {item.Name} {item.Age} {item.City}");
             }

 */


            #endregion


            /*

                        List<object> list = new List<object>()
                        {"Ajay" , 10,new Student(),23.3f,"Vishal" ,20};

                        var result = list.Where(o => o.GetType().Name == "String");
                        foreach (var item in result)
                        {
                            Console.WriteLine($"{item} ");//Ajay , Vishal : string wale name aa jaynege jitne bhi list me hai
                        }

                        var result1 = list.Where(o => o.GetType().Name == "Int32");
                        foreach (var item in result1)
                        {
                            Console.WriteLine($"{item} ");//10,20 : list me int wale jitne bhi numbers hai sare o/p me aayenge
                        }

            */


            #region OfType()

            List<object> list = new List<object>()
            {
                "Ajay",23,"Vishal",21,23.3f
            };
            //  var result4 = list.OfType<int>();//int wale sare record print
            var result4 = list.OfType<string>();//Ajay ,vishal : string ke sare record 
            foreach (var item in result4)
            {
                Console.WriteLine($"{item} ");
            }






            List<Car> cars = new List<Car>()
            {
                new BMW(),
                new Audi(),
                new Car(),
                new BMW(),
                new Car()
            };

            var result = cars.OfType<BMW>();
            foreach (var item in cars) //BMW
            {
                Console.WriteLine($"{item.Name} ");
            }

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
                new Student(){ RollNumber = 1, Name = "Ajay" , Age = 23 , City = "Pune" },
                new Student(){ RollNumber = 2, Name = "Vishal" , Age = 25 , City = "Mumbai" },
                new Student(){ RollNumber = 3 , Name = "Nikhil" , Age = 18 , City ="Pune" },
                new Student(){ RollNumber = 4 , Name = "Yathrth" , Age = 15 , City ="indore" }

            };

        }
    }

    public class Car
    {
        public string Name { get; set; }
    }
    public class Audi : Car
    {
        public Audi()
        {
            Name = "Audi";
        }
    }
    public class BMW : Car
    {
        public BMW()
        {
            Name = "BMW";
        }
    }

}
