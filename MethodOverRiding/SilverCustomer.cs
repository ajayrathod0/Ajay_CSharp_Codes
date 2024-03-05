using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class SilverCustomer : Customer
    {

        public SilverCustomer(string fn, string ln) : base(fn, ln)
        {

        }
        public override void print()
        {

            Console.WriteLine($"{FirstName} {LastName} : Silver Customer");
        }
    }
}
