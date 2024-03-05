using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Program
    {
        static void Main(string[] args)
        {
            //using operator overloading
            /*  Calculator c = new Calculator();
              bool r = c.EQL(10, 11);
              Console.WriteLine(r); //False

              r = c.EQL("A", "A");
              Console.WriteLine(r); //trua

              r = c.EQL(10.5f,10.5f);
              Console.WriteLine(r); //true
  */

            #region using generic parameter
            /*
                        Calculator c1 = new Calculator();
                        bool aj = c1.EEqual<int>(10, 10);
                        Console.WriteLine(aj);// true

                        aj = c1.EEqual<string>("Ajay", "Ajay");
                        Console.WriteLine(aj);//trua

                        Calculator c2 = new Calculator();
                        c2.Add<int>(10, 23); //32

                        c2.Add<string>("Ajay", "Jathod"); //AjayJathod

                        c2.Add<float>(10.2f, 9.9f); //20.1
            */
            #endregion

            Student<int, string> c3 = new Student<int, string>();
            c3.Id = 1;
            c3.Name = "Ajay";
            string b = c3.datail();
            Console.WriteLine(b);

            Console.ReadLine();
        }
    }
}
