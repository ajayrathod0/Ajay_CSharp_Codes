using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Trainer> trainers = Trainer.GetTrainers();
            Console.WriteLine("***All Trainers***");
            foreach (var item in trainers)
            {
                Console.WriteLine($"Trainer Id : {item.TrainerId} Trainer Name : {item.TrainerName}  " +
                    $"Experience : {item.Experience}");
            }
            Console.WriteLine();



            List<Student> students = Student.GetStudent();
            Console.WriteLine("***All Students***");
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber : {item.RollNumber} Student Name :{item.StudentName} " +
                    $"City : {item.City} Trainer Id : {item.TrainerId}");
            }
            Console.WriteLine();



            #region Method Syntax Join


            /*
                        //Method syntax  :  2 hi join hai method syntax me Inner Join or Left Join



                        //1.Join

                        var result = students.Join(trainers, s => s.TrainerId, t => t.TrainerId,
                            (s, t) => new { StudentName = t.TrainerName, TrainerName = s.StudentName });
                        foreach (var item in result)
                        {
                            Console.WriteLine($"{item.StudentName}  {item.TrainerName}");
                        }
                        Console.WriteLine();



                        //2.GroupJoin(Left join)

                        var result2 = students.GroupJoin(trainers, s => s.TrainerId, t => t.TrainerId,
                            (s, ts) => new
                            {
                                StudentName = s.StudentName,
                                TrainerName = ts.FirstOrDefault()?.TrainerName//yaha ? nullble ke liye hai FirstOrDefault
                                                                              //kyu ki ese bhi student hai jiske trainer null hai
                                                                              //unhe acces karne ke liye FirstOrDefault method ko call karke ? nullble banayenge
                            });

                        foreach (var item in result2)
                        {
                            Console.WriteLine($"{item.StudentName} {item.TrainerName}");
                        }

            */


            #endregion Method syntax Join


            //Inner Join
            var inner = from s in students
                        join t in trainers
                        on s.TrainerId equals t.TrainerId
                        select new
                        {
                            StudentName = s.StudentName,
                            TrainerName = t.TrainerName
                        };

            Console.WriteLine("Inner Join in Quary Syntax");
            foreach (var item in inner)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }
            Console.WriteLine();




            //Left join
            var left = from s in students
                       join t in trainers
                       on s.TrainerId equals t.TrainerId
                       into temp                         // join result temp me hold karenge
                       from tt in temp.DefaultIfEmpty()  // left(collection) join me jis student ke trainer null hai use default value ke liye
                       select new
                       {
                           StudentName = s.StudentName,
                           TrainerName = tt?.TrainerName
                       };

            Console.WriteLine("Left Join in Quary Syntax");
            foreach (var item in left)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }
            Console.WriteLine();



            //Right join
            var right = from t in trainers
                        join s in students
                        on t.TrainerId equals s.TrainerId
                        into temp
                        from ss in temp.DefaultIfEmpty()
                        select new
                        {
                            StudentName = ss?.StudentName,
                            TrainerName = t.TrainerName
                        };

            Console.WriteLine("Right Join in Quary Syntax");
            foreach (var item in right)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }
            Console.WriteLine();



            //Full join

            var full = left.Union(right);
            Console.WriteLine(" full join ");
            foreach (var item in full)
            {
                Console.WriteLine($"student name : {item.StudentName} " +
                    $"trainer name : {item.TrainerName}");
            }
            Console.WriteLine();



            //Cross join
            var cross = from s in students
                        from t in trainers
                        select new
                        {
                            StudentName = s.StudentName,
                            TrainerName = t.TrainerName
                        };
            Console.WriteLine("Cross Join");
            foreach (var item in cross)
            {
                Console.WriteLine($"Student Name : {item.StudentName} " +
                    $"Trainer Name : {item.TrainerName}");
            }
            Console.WriteLine();




            //ALL Students & All Trainers Get with join

            var all = from s in students
                      join t in trainers
                      on s.TrainerId equals t.TrainerId
                      select new
                      {
                          Student = s,
                          Trainer = t
                      };
            Console.WriteLine("ALl Students & All Trainers");
            foreach (var item in all)
            {
                Console.WriteLine($"Roll Numbar :{item.Student.RollNumber} " +
                      $"Name : {item.Student.StudentName} " +
                      $"City : {item.Student.City}  TrainerId : {item.Student.TrainerId} " +
                      $"Trainer ID : {item.Trainer.TrainerId} Trainer Name : {item.Trainer.TrainerName}");
            }
            Console.WriteLine();



            //ALL Students
            var Sall = from s in students
                       join t in trainers
                       on s.TrainerId equals t.TrainerId
                       select new { Student = s };
            Console.WriteLine($"** ALL STUDENTS **");
            foreach (var item in Sall)
            {
                Console.WriteLine($"{item.Student.RollNumber} {item.Student.StudentName}");
            }


            Console.ReadLine();
        }
    }
}
