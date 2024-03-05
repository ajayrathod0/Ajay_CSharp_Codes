using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YieldKeyword
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> result = new List<int>() { 1, 2, 3, 4, 5, 6, 7 };
            foreach (int num in GetEven(result))
            {

                Console.WriteLine(num); // 2 4 6
            }


            Console.ReadLine();
        }
        static IEnumerable<int> GetEven(List<int> Number)
        {
            foreach (int num in Number)
            {
                if (num % 2 == 0)
                {
                    yield return num; //1 se jyada return karna hai to yield keyword
                }
            }
        }
    }
}
