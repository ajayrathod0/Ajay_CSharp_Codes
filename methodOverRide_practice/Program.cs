using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methodOverRide_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Animal a = new Animal();
            a.AnimalSound();

            Animal b = new Animal();
            b = new Pig();
            b = new Dog();
            b.AnimalSound();
*/
            Animal[] A = new Animal[]
            {
                new Animal(),
                new Pig(),
                new Dog(),
                new Cat()
            };
            for (int i = 0; i < A.Length; i++)
            {
                A[i].AnimalSound();
            }


            Console.ReadLine();
        }
    }
}
