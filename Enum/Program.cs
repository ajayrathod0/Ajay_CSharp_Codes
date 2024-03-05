using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enum_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student();
            s.Id = 1;
            s.Name = "Ajay";
            s.Gender = Gender.Male;
            s.Subject = Sbj.Hindi;

            Console.WriteLine($"Id : {s.Id}  Name :{s.Name}  Gender : {s.Gender} Subject : {s.Subject}");

            Type t = Enum.GetUnderlyingType(typeof(Gender));
            Console.WriteLine($"{t.Name}"); //int

            string[] names = Enum.GetNames(typeof(Gender));
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} \t"); //gender enum me jitne bhi name hai sare print honge
            }


            int[] value = (int[])Enum.GetValues(typeof(Gender));
            for (int i = 0; i < value.Length; i++)
            {
                Console.WriteLine($"{value[i]}");//gender enum me ki item/variable ke value print hongi
                //by default 0 se start hoti hai matlab 0, 1 ,2
            }



            Console.ReadLine();
        }
    }
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Gender Gender { get; set; } //Property  : enum gender type ka Gender 
        public Sbj Subject { get; set; }

    }
    public enum Gender // enum ko class ke bahar likha jata hai
    {
        Male, Female, Unkyoun //options

    }
    public enum Sbj
    {
        Math,
        Hindi,
        English
    }
}
