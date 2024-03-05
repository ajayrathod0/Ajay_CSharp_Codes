using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_keyword 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*SilverCustomer c = new SilverCustomer();
            c.ShowTime();
            c.PrintTicket();

            GoldCustomer g = new GoldCustomer();
            g.ShowTime();
            g.PrintTicket();*/


            //  Customer c2 = new Customer(); //Error - abstract class khud ka object nahi banata

            Customer c1 = new SilverCustomer();
            c1.ShowTime();
            c1.PrintTicket();

            Customer c2 = new GoldCustomer();
            c2.ShowTime();
            c2.PrintTicket();

            Console.ReadLine();
        }
    }
}
