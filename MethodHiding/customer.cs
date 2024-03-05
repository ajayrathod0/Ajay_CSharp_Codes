using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    public class Customer
    {
        public void Print()
        {
            Console.WriteLine("Customer class Print() method called");
        }

        public void PrintA()
        {
            Console.WriteLine("Customer Class PrintA() method called");
        }
    }
    public class SilverCustomer : Customer
    {
        new public void Print()
        {
            Console.WriteLine("SilverCustomer Class Print() method Called");
        }
        public void PrintB()
        {
            Console.WriteLine("SilverCustomer Class PrintB() Method called");
        }

    }
}
