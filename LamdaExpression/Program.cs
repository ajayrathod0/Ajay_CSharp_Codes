using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpression
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Using separate method

            /*Predicate<int> a = Calculator.Even;
            bool result = a(10);
            Console.WriteLine(result);//true
            result = a(11);
            Console.WriteLine(result);//false
*/
            #endregion
            #region Using Anonymous method
            /*

                        Predicate<int> del = delegate (int num)
                        {
                            return num % 2 == 0;
                        };
                        Console.WriteLine(del(10));//true
                        Console.WriteLine(del(13));//false
            */

            #endregion

            #region Using Lambda Expression
            //int parameter jo i hai or Predicate me bool return type 

            Predicate<int> result = i => i % 2 == 0;

            Console.WriteLine(result(10));//true
            Console.WriteLine(result(15));//false

            Action<string, string> result1 = (s1, s2) => Console.WriteLine($"{s1} {s2}");
            result1("Ajay", "Rathod");

            Action<string, string> result2 = (s1, s2) =>
            {
                string s = s1 + " " + s2;
                Console.WriteLine(s);
            };
            result2("Vishal", "Jathod");

            Func<String> result3 = () => { return "Hello World !!!"; };
            Console.WriteLine(result3());

            Func<string, string, string> result4 = (s1, s2) =>
            {
                string s = s1 + " " + s2;
                return s;
            };
            Console.WriteLine(result4("Ajay","Jathod"));
            #endregion

            Console.ReadLine();
        }


    }
    public class Calculator
    {
        public static bool Even(int num)
        {
            return num % 10 == 0;
        }
    }
}
