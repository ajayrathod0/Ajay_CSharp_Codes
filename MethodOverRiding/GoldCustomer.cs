using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    public class GoldCustomer : Customer
    {
        public GoldCustomer(string fn, string ln) : base(fn, ln)
        {

        }

        public override void print()
        {
            Console.WriteLine($"{FirstName} {LastName} Gold Customer");


        }
    }
    public class AdvancedGoldCustomer : GoldCustomer
    {
        public AdvancedGoldCustomer(string fn, string ln) : base(fn, ln)
        {

        }
        public override void print()
        {
            Console.WriteLine($"{FirstName} {LastName} : AdvancedGold Customer");
        }
    }

}
