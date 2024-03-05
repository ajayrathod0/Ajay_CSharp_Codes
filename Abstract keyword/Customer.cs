using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_keyword 
{
    public abstract class Customer // abstract method banaya hai to class ko bhi abstract banana padenga nahi to error aayenga
    {
        public void ShowTime()
        {
            Console.WriteLine("**TODAY SHOW**");
        }

        public abstract void PrintTicket(); // abstract means incomplate
    }
}
