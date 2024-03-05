using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pactice
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Account a = new Account("Ajay", "Rathod", 123456);
            a.Print();

            SavingAccount a1 = new SavingAccount("Vishal", "jathod", 54611562);
            a1.print();

            CurrentAccount a2 = new CurrentAccount("Vishal", "tanwer", 78484);
            a2.print();

            LoanAccount a3 = new LoanAccount("vikul", "Rathod", 458795);
            a3.print();*/

            /* Account a4 = new SavingAccount("yatharth", "jathod", 784500);
             a4.Print();*/

            Account[] a = new Account[] {
               new Account("Ajay","Rathod",8291),
               new SavingAccount("Ajju","Rathod",7920),
               new CurrentAccount("Vishal","j",0),
              new LoanAccount("Nikhil","R",1)
            };

            for (int i = 0; i < a.Length; i++)
            {
                a[i].Print();
            }

            Console.ReadLine();
        }
    }


}
