using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Child class / derived Class

    public class PlatinumCustomer : Customer
    {
        public PlatinumCustomer()
        {
            TicketAmount = 500;
        }

        public void PrintPlatinumCustomer()
        {
            Console.WriteLine("Platinum Ticket printed");
        }
    }
}
