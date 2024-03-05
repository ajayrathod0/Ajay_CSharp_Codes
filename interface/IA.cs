using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public interface IA
    {
        void PrintA();
        void Print();
    }

    public interface IB
    {
        void PrintB();
        void Print();
    }

    public class Ajay : B, IA, IB // agar interface ko inherite kar rahe ho or class
                                  // ko bhi inherite karna hai to class ko pahale inherite
                                  // karenge uske baad "," laga kar interface ko inherite
                                  // karenge
    {
        public void PrintA()
        {
            Console.WriteLine("class Ajay : IA PrintA()");
        }
        public void PrintB()
        {
            Console.WriteLine("class Ajay : IA, IB PrintB()");
        }

        void IA.Print()  // agar sam method alag alag interface me hai or
                         // usko impelyment karna hai to use method ke pahle
                         // interface ka name . karke method ka name likhenge
                         // or public likhne ki jarurt nahi hai kyu ki vaha by
                         // default public hota hai
        {
            Console.WriteLine("IA : Print()");
        }
        void IB.Print()
        {
            Console.WriteLine("IB : Print()");
        }
    }

    public class B { }
}

