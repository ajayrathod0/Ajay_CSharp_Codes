using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface Icustomer
    {
        void ShowTimeing(); //method yaha by default public hota hai pubic likhane ki jarurat nahi hai
        void Print(); //interface me likhe method ko mandatory impement karna padata hai derived class me
    }
    class SilverCustomer : Icustomer, Ib
    {
        public void ShowTimeing()
        {
            Console.WriteLine("Silver Customer : Showtiming()");
        }
        public void Print()
        {
            Console.WriteLine("Sliver Customer : print()");
        }
    }
    public interface Ib : Icustomer
    {
        void Print();
    }
    class GoldCustomer : Icustomer, Ib
    {
        public void Print()
        {
            Console.WriteLine("Gold Customer print()");
        }

        public void ShowTimeing()
        {
            Console.WriteLine("Gold Customer ShowTimeing() ");
        }
    }
}
