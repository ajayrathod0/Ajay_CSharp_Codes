using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public class A
    {
        // private void Print() // same type/Class me hi excess honga 
        // protected void Print() // same class me , derived class me or dusre(refer) project me derived class m excess honga 
        //internal void Print() //same assembly me har jagah
        //  protected internal void Print() // combinastion of both protected + internal
        //same assembly me 
        //another assembly only derived type
        public void Print() // anywere har jagah same assembly har jagah anothor assembly 
        {
            Console.WriteLine("Class A Print()");
        }
        void PrintA()
        {
            Print();
        }

    }

    public class B : A
    {
        private void PrintB()
        {
            Print();
        }
    }
    public class C
    {
        private void PrintC()
        {
            A ab = new A();
            ab.Print();
        }
    }
}
