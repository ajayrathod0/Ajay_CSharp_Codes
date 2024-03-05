using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegate
{
    delegate string Printdelegate();
    internal class Program
    {
        static void Main(string[] args)
        {
            Printdelegate pd = PrintA;
            pd = PrintB;
            pd = PrintC;
         //   string result = pd();
           // Console.WriteLine(result); //printc   last wala print kar raha hai kyu ki tino method return kar rahe hai last wALA RETURN KA value print karenga

            Delegate[] delegates = pd.GetInvocationList();
            for (int i = 0; i < delegates.Length; i++)
            {
                try
                {
                   var ans = delegates[i].DynamicInvoke();
                    Console.WriteLine(ans);
                }
                catch {
                    Console.WriteLine("Exception occered");
                }
            }


            Console.ReadLine();
        }

        static string PrintA()
        {
            return "PrintA";
        }
        static string PrintB()
        {
            throw new Exception("Intentionally Exception throw ");
            return "PrintB";
        }
        static string PrintC()
        {
            return "Printc";
        }
    }
}
