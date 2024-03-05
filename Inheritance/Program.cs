using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* SilverCustomer sc1 = new SilverCustomer();
             sc1.ShowTime();
             sc1.GetTicketAmount();
             sc1.PrintSilverTicket();

             GoldCustomer gc1 = new GoldCustomer();
             gc1.ShowTime();
             gc1.GetTicketAmount();
             gc1.PrintGoldTicket();

             PlatinumCustomer pc1 = new PlatinumCustomer();
             pc1.ShowTime();
             pc1.GetTicketAmount();
             pc1.PrintPlatinumCustomer();*/

            // Customer c1 = new Customer();

            Customer c = new SilverCustomer("Ajay");


            Console.ReadLine();
        }
    }
}
