using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_delegate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Predicate delegate

            // public delegate bool Predicate<in T>(T obj);
            //Predicate generic delegate bool return karta hai yaha system me hai vaha se access kar rahe hai
            /*
                        Predicate<int> d = Print;
                        bool gd = d(10);
                        Console.WriteLine(gd); //true

                        gd = d(20);
                        Console.WriteLine(gd);//false

                        Predicate<string> aj = PrintA;
                        bool ans = aj("Ajay");
                        Console.WriteLine(ans);
                        ans = aj("vishal");
                        Console.WriteLine(ans);
            */
            #endregion

            #region Action delgate

            //public delegate void Action<in T1, in T2>(T1 arg1, T2 arg2);
            //Action generic delgate me 16 overload (matlab 16 parameter) hote hai iska return type void hi hota hai

            /*
                        Action<int, int> ac = Method;
                        ac(10, 10);

                        Action<int, string, string> at = Method1;
                        at(1, "Ajay", "Jathod");
            */

            #endregion

            #region Func delegate

            // public delegate TResult Func<out TResult>();
            //Func delegate ke 17 overload hote hai jo last wala Func<>argument honga func me vah return tyepe honga


            /*     Func<int, string> i = Eodd; //string jo last me hai vaha method ka return type hai or int parameter
                 string result = i(10);
                 Console.WriteLine(result); //even number

                 Func<int, int, int, int> ans = Add;
                 int res = ans(10, 20, 30);
                 Console.WriteLine(res);
     */
            #endregion

            #region Anonymous method
            //Anonymous method ham vahi declare kar sakte hai delegate keyword and parameter and body
          //  generic delegate + Method = anonymous method


            Predicate<string> a = delegate (string j)
            {
                return j.Length > 3 ? true : false;
            };
            bool b = a("Ajay");
            Console.WriteLine(b);

            b = a("Om");
            Console.WriteLine(b);

            Action<string, string> k = delegate (string q, string w)
            {
                Console.WriteLine(q + w);
            };
            k("ajay", "jathod");

            #endregion


            Console.ReadLine();
        }

        static bool Print(int a)
        {
            return 10 + a == 20 ? true : false;
        }
        static bool PrintA(string b)
        {
            return b.Length > 5 ? true : false;
        }
        static void Method(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        static void Method1(int i, string j, string k)
        {
            Console.WriteLine($"{i} {j} {k}");
        }

        static string Eodd(int a)
        {
            return a % 2 == 0 ? "Even Number" : "Odd Number";
        }

        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

    }
}
