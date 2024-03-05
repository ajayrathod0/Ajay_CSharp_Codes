using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace a_Loops
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 5; i++) {
                Console.Write("@ \t");
            }

            Console.WriteLine("\n \n \t");

            



            for (int i = 5; i > 0; i--)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"* \t");
                }
                Console.WriteLine();

            }



            for (int a = 1; a <= 5; a++)
            {
                for (int b = 1; b <= a; b++)
                {
                    Console.Write($"* \t");
                }
                Console.WriteLine();
            }


            for (int i = 1; i <= 5; i++)
            {
                for (int j = i; j <= 5; j++)
                {
                    Console.Write($"*\t");
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
