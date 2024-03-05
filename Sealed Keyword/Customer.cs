using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sealed_Keyword
{
    // public sealed class Customer // seald class me inherite nahi ka sakte 
    public class Customer
    {
        public virtual void Print()
        {
            Console.WriteLine("Customer calss Print()");
        }
    }

    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("Silver Customer Print() Called");
        }
    }

    public class GoldCustomer : Customer
    {
        public sealed override void Print()
        //sealed method, me karna hai to vah keyword override ke sath aayenga mandtory hai 
        {
            Console.WriteLine("Gold Customer print() called");
        }
    }

    public class AdvanceGoldCustomer : GoldCustomer
    {
        // override nahi honga kyu ki iske base class me sealed override likha hai method
        // override nahi kar sakte
        // public override void Print()
        //{
        //    Console.WriteLine("Advance Gold Customer Called");
        //   }
    }
}
