using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstReadonlyKeyword
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer a = new Customer();
            a.Id = 1;
            a.Name = "Ajay";
            Console.WriteLine($" Id : {a.Id} Name : {a.Name} Comapany Name : {a.CompanyName}");

            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        // public const string CompanyName = "V#";    //access classname.feild name

        public readonly string CompanyName ;

        public Customer() {
            CompanyName = "V#";
        }

    }
}
