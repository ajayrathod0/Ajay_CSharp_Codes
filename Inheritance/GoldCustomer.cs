using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Child class / derived Class
    public class GoldCustomer : Customer
    {
        //public int TicketAmount;

        public GoldCustomer() // constuctor 
        {
            TicketAmount = 300;
        }

        public void PrintGoldTicket() //method
        {
            Console.WriteLine(" Gold Ticket Printed");
        }
    }
}
