using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace method_1
{
    internal class Program
    {

        // void => agar kuch bhi nahi "return" karna hai to vaha void aayenga
        //parameter => agar method likhate time jo parameter ke data type or varible de rahe hai use parameter kahenge
        //argument => call karte time jo pass kar rahe hai use argumet kahenge
        //parameter alag alag datatype ke likh sakte hai par parameter likhane ke pahle data type likhna padenga
        //parameter jis Dtype ka lika hai usi type ka argument pass karna padenga

        static void Main(string[] args)
        {
            PrintA();
            PrintB("Ajay"); // argument pass = ajay
            string first = "Ajju", second = "Kumar";//1 way
            PrintC(first, second); //1 way
            PrintC("Ajay", "Rathod"); // second way => argument pass karne ka tarika

            string result = PrintD("Chetan", "Chavhan"); //return me hold karke print karna padta hai 
            Console.WriteLine($"Print D () called : {result}");

            PrintE(false); // console me kuch nahi aayenga kyu ki conditon false ho gayi return me aa jaynega if loop
            PrintE(true);

            PrintF(null);  //else wala loop chala => "no number add"
            int[] numbers = new int[] {10,20,30};
            PrintF(numbers); //O/P => 60

            Console.ReadLine();
        }

        // 1. method without return without parameter
        static void PrintA()
        {

            Console.WriteLine("Print A () Method called");

        }

        //2. method without return with parameter
        static void PrintB(string name)
        {
            Console.WriteLine($"Print B() called Hello :{name}");

        }
        //3. method without return with multiple parameter
        static void PrintC(string fn, string ln)
        {
            Console.WriteLine($"method C Called FisrtName is : {fn} LastName : {ln}");

        }

        //4. method with return with parameter
        static string PrintD(string fn, string ln)
        {
            return fn + " " + ln;
        }

        //5. bool type
        static void PrintE(bool isConfirmed)
        {
            if (!isConfirmed)
            {
                return;
            }
            Console.WriteLine($"Print E() ({isConfirmed}):Session Allowed");
        }
        //6. sum of Array Element
        static void PrintF(int[] number)
        {
            if (number != null && number.Length > 0) //yah condition false hui to else me massage print honga
            {
                int sum = 0;
                for (int i = 0; i < number.Length; i++)
                {
                    sum += number[i];
                  //sum =0+0
                }
                Console.WriteLine($"sum of array items: {sum}");
            }
            else
            {
                Console.WriteLine("No number Add");
            }



        }
    }
}
