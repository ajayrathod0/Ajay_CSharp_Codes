using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LazyLoading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer();
            Console.WriteLine(a.Name.Value);
            Console.WriteLine(a.Oders.Value);

            Console.ReadLine();
        }
    }
    public class Oder
    {
        public int OrderId { get; set; }
        public string Description { get; set; }

    }

    public class Customer
    {
        public Lazy<string> Name { get; set; }
        public Lazy<Oder[]> Oders { get; set; }

        public Customer()
        {
            Name = new Lazy<string>(GetName);
            Oders = new Lazy<Oder[]>(GetOrder);
        }

        public string GetName()
        {
            Console.WriteLine("Get Name() called");
            return "Ajay";
        }

        public Oder[] GetOrder()
        {
            Console.WriteLine("Get Order() called");
            return new Oder[]
            {
              new Oder(){OrderId = 1, Description="Order 1" },
              new Oder(){OrderId = 2, Description= "Order 2" },
              new Oder(){OrderId = 3, Description= "Order 3" }

            };
        }
    }
}
