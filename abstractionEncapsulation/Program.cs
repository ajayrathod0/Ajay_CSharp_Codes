using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstractionEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student(10, "Ajay", "Male");
            s1.Insert();///Abstraction
            //call karenge insert method me if me isvalid() method lo call karenge
            //vo chack karenga ki Rollnumber negative to nahi hai or name null/empty check
            //or gender null/empty to nahi hai agar ek bhi condition galat rahi to 
            //else me chala jayenga "Envalid Data"

            Console.ReadLine();
        }
    }
    public class Student
    {
        private int RollNumber;
        private string Name;
        private string Gender;

        public Student(int rn, string fn, string g)
        {
            RollNumber = rn;
            Name = fn;
            Gender = g;
        }

        private bool IsValid()///Encapsulation
        {
            if (RollNumber > 0 && !string.IsNullOrEmpty(Name) && !string.IsNullOrEmpty(Gender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Insert()
        {
            if (IsValid())
            {
                Console.WriteLine("New Student insert successful");
            }
            else
            {
                Console.WriteLine("Envalid Data"); // code to insert data in database

            }
        }
    }
}
