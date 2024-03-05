using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverRiding
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            Customer c = new Customer("A", "B");
            c.print();  //Customer

            SilverCustomer s = new SilverCustomer("Ajay", "Rathod");
            s.print(); //SilverCustomer

            Customer c1 = new SilverCustomer("Vishal", "Jathod");
            //without method me override keyword output hame vo jiska refarence honga vo denga o/p "Custome" 
            c1.print(); //with override keyword in method "SilverCustomer"
*/

            /*Customer a = new Customer("A","a");
            a = new SilverCustomer("A","j");
            a = new GoldCustomer("A","a");
            a = new AdvancedGoldCustomer("A","y");
            a.print();
*/

            Customer[] aj = new Customer[]
            {
              new Customer("A","A"),
              new SilverCustomer("A","B"),
               new GoldCustomer("A","C"),
              new AdvancedGoldCustomer("A","D")
            };
            for (int i = 0; i < aj.Length; i++)
            {
                aj[i].print();
            }




            Console.ReadLine();
        }
    }
}
