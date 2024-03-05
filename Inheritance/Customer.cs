using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //perent Class / base class =      jo comman data hai n child class ka vo ham ye parent class me likhenge
    //example :- "ticketamount" feild , "showtime" method, "GetTecktAmount" method
    public class Customer
    {
        public int TicketAmount;//Feild
        public string Name = "Customer";


        public Customer()
        {
            Console.WriteLine("Customer Constuctor called");
        }
        public Customer(string n)   // silverConstuctor   :base(name)
        {
            Console.WriteLine($"Customer contructor called():{n} ");
        }

        public void ShowTime() //Method
        {
            Console.WriteLine($"** TODAY SHOWS **");
        }

        public void GetTicketAmount() //Method
        {
            Console.WriteLine($"Ticket Amount is {TicketAmount}");
        }


    }
}
