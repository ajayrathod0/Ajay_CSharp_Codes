using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            calculator a = new calculator();
            a.Print();
            a.Print(10);
            a.Print("Ajay", 12);

            a.Print(12, "Ajay");

            int num = 10;
            a.Print(ref num);

            a.Print();

            short i = 10;
            int n = 10;

            a.Print(10); // int print
            a.Print(i);



            Console.ReadLine();
        }
    }
}
