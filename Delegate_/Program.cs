using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_
{
    public delegate void DelegatePrint(string a);
    public class Program
    {
        static void Main(string[] args)
        {
            //DelegatePrint d = new DelegatePrint(PrintA); // 1st way

            // DelegatePrint d = PrintA; //2nd way shortcut
            //d("Ajay");

            DelegatePrint d2 = PrintA;
            DelegatePrint d3 = PrintB;
            DelegatePrint d4 = PrintC;
            DelegatePrint D = d2 + d3 + d4;
            D("Ajay");

            DelegatePrint a = PrintA;
            a += PrintB;
            a += PrintC;
            a -= PrintB; // de ragister PrintB
            a("Vishal");


            Console.ReadLine();
        }

        static void PrintA(string name)
        {
            Console.WriteLine($"Hello , {name}");
        }
        static void PrintB(string name)
        {
            Console.WriteLine($"Good Morning : {name}");
        }
        static void PrintC(string name) { Console.WriteLine($"Bye , {name}"); }
    }

}
