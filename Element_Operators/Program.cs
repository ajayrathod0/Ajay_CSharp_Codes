using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Element_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 2, 3, 4, 5, 6 };

            var a1 = num.ElementAt(2);
            Console.WriteLine(a1);//3 

            //  var a2 = num.ElementAt(7); //Exception kyu ki index 5 hi hai list me
            var a2 = num.ElementAtOrDefault(7); //agar index out of scope hai to default value return karenga
            Console.WriteLine(a2);//0 


            var a = num.First();
            Console.WriteLine($"{a} ");//1  :- return first index value

            var a3 = num.First(s => s % 2 == 0);
            Console.WriteLine(a3);//2

            // var a4 = num.First(s => s > 50);   //Exception

            var a4 = num.FirstOrDefault(s => s > 50);
            Console.WriteLine(a4);//0 

            var a5 = num.Last();
            Console.WriteLine(a5);//return last value

            // var q = num.Last(s => s > 50); //Exception
            var q = num.LastOrDefault(s => s > 50);
            Console.WriteLine(q);//0 Return Default value



            //      var j = num.Single();//Exception :  throws exception if there are multiple matching items

            List<int> numbers = new List<int>() { 5 };
            var d = numbers.Single();
            Console.WriteLine(d);//5

            //  var d1 = numbers.Single(s => s % 50==0);
              var d1 = numbers.SingleOrDefault(s => s % 50==0);
            Console.WriteLine(d1);//0


            Console.ReadLine();
        }
    }
}
