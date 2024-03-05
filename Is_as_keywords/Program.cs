using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Is_as_keywords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer a = new SilverCustomer();
            a.Print();

            Customer b = new GoldCustomer();
            b.Print();


            //GoldCustomer sc = (GoldCustomer)a;
            // sc.Print();

            bool b1 = a is GoldCustomer;
            Console.WriteLine(b1); //false

            GoldCustomer g3 = a as GoldCustomer;// if type cast not possible it returns null
            if (g3 != null)
            {
                g3.Print();
            }


            Console.ReadLine();
        }
    }
    public abstract class Customer
    {
        public abstract void Print();
    }
    public class SilverCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("SilverCustomer Print() called");
        }

    }
    public class GoldCustomer : Customer
    {
        public override void Print()
        {
            Console.WriteLine("GoldCustomer Print() called");
        }
    }
}
