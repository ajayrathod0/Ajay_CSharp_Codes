using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace String_StringBuilder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StringBuilder a = new StringBuilder();
            a.Append("Ajay  " );
            a.Append("Ramsing  " );
            a.Append("Rathod" );
            Console.WriteLine(a.ToString());

            Console.ReadLine();
        }
    }
}
