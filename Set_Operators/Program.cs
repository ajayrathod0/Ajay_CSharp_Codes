using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Set_Operators
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region Distinct()

            /*List<int> numbers = new List<int> { 1, 2, 2, 4, 5, 4, 2 ,3};

            var result = numbers.Distinct();//Dublicate remove kar deta hai or uniaq return karta hai
            foreach (var item in result)
            {
                Console.Write($"{item} ");//1 2 4 5 3
            }
*/
            #endregion Distinct()


            #region Union , Concat

            /*  List<int> numbers = new List<int>() { 2, 6, 3, 4 };
              List<int> numbers1 = new List<int>() { 5, 3, 2 };

              var result = numbers.Union(numbers1);//marge list and remove dublicate numbers
              foreach (var item in result)
              {
                  Console.Write($"{item} ");//2 6 3 4 5
              }
              Console.WriteLine();


              //Concat() :~ 
              var result1 = numbers.Concat(numbers1);//marge list all numbers 
              foreach (var item in result1)
              {
                  Console.Write($"{item} ");//2 6 3 4 5 3 2
              }

  */

            #endregion Union , Concat


            #region Intersect , Except
            /*

                        List<int> number = new List<int>() { 3, 2, 5, 1 };
                        List<int> number1 = new List<int>() { 4, 2, 1 };

                        var ans = number.Intersect(number1); // first and second list me only Commun number return
                        foreach (var item in ans)
                        {
                            Console.Write($"{item} ");//2 1
                        }
                        Console.WriteLine();


                        var ans2 = number.Except(number1);//first list ese number jo second list me na ho vahi return karenga
                        foreach (var item1 in ans2)
                        {
                            Console.Write($"{item1} ");// 3 5
                        }

            */
            #endregion Intersect , Except


            #region SequenceEqual


            List<int> num = new List<int>() { 3, 2, 1 };
            List<int> num2 = new List<int>() { 1, 3, 2 };
   

            var result = num.SequenceEqual(num2);
            Console.WriteLine(result);//false

            //SequenceEqual :~ agar compare kar rahe hai to sequence bhi commun hona chaiye
            //nahi to vah false hi denga same raha bhi to
            //- yah bool return karta hai

            num.Sort();
            num2.Sort();

            var results = num.SequenceEqual(num2);
            Console.WriteLine(results);//true


            #endregion SequenceEqual

            Console.ReadLine();
        }
    }
}
