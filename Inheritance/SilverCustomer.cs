using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    //Child class / derived Class

    public class SilverCustomer : Customer
    {
        // public int TicketAmount;      ye feild likha hai base class me to esliye comment karke rakha hai

        public string Name = "SilverCustomer";

        /*public SilverCustomer() //constuctor default
        {
            // TicketAmount = 150;
            Console.WriteLine($"Currant value: {this.Name}"); //this current class se yahi
            Console.WriteLine($"base class value: {base.Name}");  // base class se jo name diya hai field me vaha name aayenga
        }*/

        public SilverCustomer(string name) : base(name)
        {
            Console.WriteLine($"inside Silvercustomer(string n) {name}");
        }
        public void PrintSilverTicket()
        {
            Console.WriteLine("Silver ticket print ");
        }

    }
}
