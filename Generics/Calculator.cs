using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Calculator
    {
        #region using method overloading
        /*
           public bool EQL(int a, int b)
           {
               return a.Equals(b);
           }
           public bool EQL(string a, string b)
           {
               return a.Equals(b);
           }
           public bool EQL(float a, float b)
           {
               return a.Equals(b);
           }
   */

        #endregion

        #region using Generic

        public bool EEqual<T>(T a, T b)
        {
            return a.Equals(b);
        }

        public void Add<T>(T a, T b)
        {
            dynamic n1 = a;
            dynamic n2 = b;
            Console.WriteLine(n1 + n2);
        }

        #endregion
    }
}
