using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class Customer
    {
        public string FirstName;
        public string LastName;
        public Customer(string fn, string ln)
        {
            FirstName = fn;
            LastName = ln;
        }
        public virtual void print()
        {
            Console.WriteLine($"{FirstName} {LastName} : Customer base class");
        }
    }
}
