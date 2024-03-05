using MathLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibraryClint
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MathLibraryClint Page");

            Calculator a = new Calculator();
            a.Add(10, 23);
            Console.WriteLine("Enter first number ");
            int first = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number");
            int second = int.Parse(Console.ReadLine());
            a.Add(first, second);

            Console.ReadLine();

        }
    }
    public class x
    {
        private void Printx()
        {
            A aa = new A();
            aa.Print();
        }
    }
    public class Y : A
    {
        public void PrintY()
        {
            Print();
        }
    }
}
