using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Keyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Print();

            Customer cs = new SilverCustomer();
            cs.Print();

            Customer c1 = new GoldCustomer();
            c1.Print();

            Customer c2 = new AdvanceGoldCustomer();
            c2.Print();

            Console.ReadLine();
        }
    }
}
