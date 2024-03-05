using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ObjectType
{
    public class Program
    {
        static void Main(string[] args)
        {
            /* object obj = "Ajay";
             Console.WriteLine(obj.GetType());

             obj = 'A';
             Console.WriteLine(obj.GetType());

             obj = 1;
             //object me koi bhi value hold kar sakte hai 
             //object base type hota hai
             Console.WriteLine(obj.GetType());

             //GetType() method = we can use with variable
             //TypeOf() operator = we can use type name

             Type a = typeof(double);
             Console.WriteLine(a);
             object ab = new Student();
             */

            #region ToString() method

            int i = 10;
            int j = 20;
            Console.WriteLine(i + j);//30
            Console.WriteLine(i.ToString() + j.ToString());//1020



            #endregion()

            Console.ReadLine();
        }
    }
    public class Student
    {
        
    }
}
