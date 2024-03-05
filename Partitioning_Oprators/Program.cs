using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partitioning_Oprators
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Take()
            /*
                        List<int> numbers = new List<int>() { 2, 4, 3, 6, 7, 2, 9, 3 };
                        var result = numbers.Take(3);//Take method input me count leta hai 
                                                   //first 3 count tak number return karta hai
                        foreach (var item in result)
                        {
                            Console.Write($"{item} ");//2 4 3 
                        }
                        Console.WriteLine();


            //TakeWhile()

                        var result2 = numbers.TakeWhile(i => i % 2 == 0);
                        // jab tak condtion true hongi tab tak number return karenga 
                        // agar ek bhi condtion false huva uske aage ka kuch nahi return karenga takewhile()
                        foreach (var item1 in result2)
                        {
                            Console.Write($"{item1} ");// 2 4
                        }
            */


            #endregion Take()


            #region Skip()

            List<int> numbers = new List<int>() { 2, 4, 2, 5, 6, 9 };
            var result = numbers.Skip(4); // 4 count tak skip, uske bad ke sare value return karenga
            foreach (var item in result)
            {
                Console.Write($"{item} ");//6 9
            }
            Console.WriteLine();


            var result1 = numbers.SkipWhile(i => i % 2 == 0);
            //condition jab tak true hai vah skip karenga condition false ke bad ke sare value return karenga
            foreach (var item1 in result1)
            {
                Console.Write($"{item1} ");//5 6 9
            }


            #endregion Skip()


            Console.ReadLine();
        }
    }
}
