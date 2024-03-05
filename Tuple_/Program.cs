using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuple_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple<int, int, int> number = new Tuple<int, int, int>(11, 22, 33);//value dena mandatory hai
            Console.WriteLine(number.Item3);//33 = Item keyword argumet pass kar rahe hai jitne utne item honge
            Console.WriteLine(number.Item2);//22
            Console.WriteLine(number.Item1);//11

            Tuple<int, int, int, int, int, int, int> number1 =
                new Tuple<int, int, int, int, int, int, int>(1, 2, 3, 4, 5, 6, 7);
            Console.WriteLine(number1.Item5); //5


            //Tuple me 7 parameter hote hai or 8 va merameter rest hota hai example..
            //8va rest parameter Tuple<> ke under 8 num. pr Tuple <> denge use hi rest bolenge 

            Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>> number2 =
                new Tuple<int, int, int, int, int, int, int, Tuple<int, int, int>>(1, 2, 3, 4, 5, 6, 7, number);

            Console.WriteLine(number2.Item7);//7
            Console.WriteLine(number2.Rest.Item3);//33  -Rest parameter ko ese acces karenge

           var result= GetDatails();
            Console.WriteLine($"{result.Item1}  {result.Item2} {result.Item3}");


            Console.ReadLine();
        }
        static Tuple<int, string, string> GetDatails()
        {
            Tuple<int, string, string> detail = new Tuple<int, string, string>(1, "Ajay", "Indore");
            //Tuple ka object banaya or usko return kiya 
            return detail;
        }

    }
}
