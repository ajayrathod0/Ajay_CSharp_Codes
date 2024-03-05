using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoding
{
    public class calculator
    {
        public void Print()
        {
            Console.WriteLine("Print() called");
        }
        public void Print(int a)
        {
            Console.WriteLine("print(int num) called");
        }

        public void Print(string name, int num)
        {
            Console.WriteLine("Print(string name, int num) Called)");
        }
        public void Print(int num, string name)
        {

            Console.WriteLine("Print(int num , string name) Called)");
        }

        public void Print(int[] num)
        {

            Console.WriteLine("Print(int[]num) Called");
        }

        //not overload
        /*  public int Print(int num) {
              Console.WriteLine("Print(int num) Called");
              return 10;
          }*/

        public void Print(ref int num)
        {
            Console.WriteLine("Print(ref int num)");
        }

        //not overload ref or out keyword same word dono me se koi bhi ek likh sakte hai call ho jayega
        /*  public void Print(out int num)
          {
               num = 10;
              Console.WriteLine("Print(out int num) Called");
          }*/

        public void Print(short num)
        {
            Console.WriteLine("Print(short num) Called");
        }



        //int type array already depand not overload
        /*public void Print(params int[] num)
        {
            Console.WriteLine("Print(params int[] num) Called");
        }
*/
    }
}

