using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_keyword
{
    public class GoldCustomer : Customer
    {
        public override void PrintTicket()//jitne bhi sare derived class hai sabko override karna mandtory hai abstrat me
        {
            Console.WriteLine("Gold Customer Called");
        }
    }
}
