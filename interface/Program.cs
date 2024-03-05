using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Icustomer c = new Icustomer(); khud ka object nahi banenga

            /*Icustomer a = new SilverCustomer();
            a.ShowTimeing();
            // a.Print();

            Icustomer b = new GoldCustomer();
            b.ShowTimeing();

            SilverCustomer cc = new SilverCustomer();
            cc.ShowTimeing();

            GoldCustomer g = new GoldCustomer();
            g.ShowTimeing();
*/

            /*Icustomer[] ar = new Ib[2];
            ar[0] = new GoldCustomer();
            ar[1] = new SilverCustomer();
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i].ShowTimeing();
                ar[i].Print();
            }
*/
            /*
            IA a = new Ajay();
            a.PrintA();
            a.Print();
            //a.PrintB(); // error yah print B method IB interface ka hai 

            IB b = new Ajay();
            b.PrintB();
            b.Print();
*/
            Ajay aj = new Ajay();
            aj.PrintA();
            aj.PrintB();
            ((IA)aj).Print();  //ye method IA interface me hai or IA inherite kiya
                               //ajay class me sam method IB interface me bhi hai
                               //usko call karne ke liye type cast karna padenga
            ((IB)aj).Print();//same


            Console.ReadLine();
        }
    }
}
