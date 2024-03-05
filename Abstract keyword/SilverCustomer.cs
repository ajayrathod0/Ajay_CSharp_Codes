using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_keyword
{
    public class SilverCustomer : Customer //base class abstract hai to derived call ke method ko overridden banana padenga mandtory hai ye
    {
        public override void PrintTicket() // override keyword likhane ke bad no error
        {
            Console.WriteLine("Silver Customer called");
        }
    }
}
