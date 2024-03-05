using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conversion_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region AsQuaryable , AsEnumerable

            /*
                        List<int> num = new List<int>() { 1, 2, 3 };

                        IQueryable<int> result = num.AsQueryable();
                        foreach (int item in result)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();



                        IEnumerable<int> result1 = num.AsEnumerable();
                        foreach (int item in result1)
                        {
                            Console.Write($"{item} ");
                        }
                        Console.WriteLine();


                        ArrayList numbers = new ArrayList() { 2, 3, 4, 5 };
                        IEnumerable<int> ans = numbers.Cast<int>();
                        foreach (int item in ans)
                        {
                            Console.Write($"{item} ");
                        }
            */
            #endregion AsQuaryable , AsEnumerable


            #region ToArray(), ToList(), Dictionary 


            int[] numbers = new int[] { 1, 2, 3 };

            //  Array->List
            List<int> list1 = numbers.ToList();

            // List->Dictionary
            Dictionary<int, int> dict = list1.ToDictionary(i => i);

            //Array->Dictionary
            Dictionary<int, int> dic1 = numbers.ToDictionary(i => i);

            //Dictionary->List
            List<KeyValuePair<int, int>> list2 = dic1.ToList();

       

            #endregion


            Console.ReadLine();
        }
    }
}
