using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student() { Name = "Ajay" };
            s.AddEnquiry();

            Console.ReadLine();
        }
    }
}
