using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace MethodHiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer c = new Customer();
            c.Print(); // customer ka print() call honga
            c.PrintA(); // customer ka hi method hai call ho jayenga
            //c.PrintB();  nahi honga kyu ki vah child/derived class ka method hai

            SilverCustomer sc = new SilverCustomer();
            sc.Print(); //SilverCustomer ka Print call honga  "new" = method hideing kiya hai same method hai to khud ka print call honga na ki parent ka
            sc.PrintA(); //jo base class ka hai vo derived class ka bhi hai inherate kiya hai esliye call ho jayenga
            sc.PrintB(); // call ho jayenga kyu ki vah current(SilverCustomer) class me hai 

            Customer c2 = new SilverCustomer();
            c2.Print();  // customer class ka method call honga kyu ki refarence usi ka hai  
            c2.PrintA(); //printA usi class me hai or usi ka refarence hai to call ho jayenga
            //c2.PrintB(); // call nahi honga kyu vah derived class me hai base class acces nahi kar payenga 
            //Q. agar access karna hi hai to use conver karna padenaga type cast 
            ((SilverCustomer)c2).PrintB(); // silverCustumer type me convert kiya ab call ho jayenga

            Console.ReadLine();
        }
    }
}
