using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // date formatting
            // https://www.c-sharpcorner.com/blogs/date-and-time-format-in-c-sharp-programming1

            DateTime varr = DateTime.Now;
            Console.WriteLine(varr);//20-12-2023 00:22:32
            Console.WriteLine(varr.Day);//20 (aaj ki date de raha hai)
            Console.WriteLine(varr.ToShortDateString());//20-12-2023
            Console.WriteLine(varr.ToShortTimeString());//12:20 AM
            Console.WriteLine(varr.ToString("dddd,dd-mmmm-yyyy"));

            /*

                        Customer a = new Customer() { CustomerId = 1, FirstName = "Ajay", LastName = "Rathod" };
                        a.Datail();

            */
            Console.ReadLine();
        }
    }
    public struct Customer
    {
        //struct class by default sealad
        public int CustomerId { set; get; }
        public string FirstName { set; get; }
        public string LastName { set; get; }

        //public Customer(){}  //ParameterLess constuctor nahi likh sakte struct class me
        public Customer(int id, string fn, string ln)
        {
            CustomerId = id;
            FirstName = fn;
            LastName = ln;
        }
        public void Datail()
        {
            Console.WriteLine($"{CustomerId}  {FirstName}  {LastName}");
        }
    }

    public class SilverCustomer //: Customer    //struct class ko inherite nahi kar sakte hai
    {

    }
}
