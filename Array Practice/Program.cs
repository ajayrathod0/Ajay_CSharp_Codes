using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine("Enter numbers ");
            // int numbers = int.Parse(Console.ReadLine());
            //  int[] highest = new int[numbers];

            #region Find highest number
            /*
                        int[] numbers = new int[] { 10, 20, 30, 40, 50 };
                        int highest = 0;

                        for (int i = 0; i < numbers.Length; i++)
                        {
                            for (int j = i + 1; j < numbers.Length; j++)
                            {

                                if (numbers[j] > highest)
                                {
                                    highest = numbers[j];
                                }
                            }
                        
                        Console.WriteLine($"{highest} is HIGHEST Number");
            */
            #endregion Find highest number


            #region target number tak even number print
            /*
                        Console.WriteLine("Enter Target number");
                        int target = int.Parse(Console.ReadLine());
                        for (int i = 1; i < target; i++)
                        {
                            if (i % 2 == 0)
                            {
                                Console.WriteLine($"{i}");
                            }
                        }*/
            #endregion'

            #region reverse input string

            Console.WriteLine("Enter your Name ");
            string name = Console.ReadLine();

            string ReverseName = string.Empty;
            for (int i = name.Length - 1; i >= 0; i--)
            {
                ReverseName += name[i];
            } 
            Console.WriteLine($"{name} Reverse {ReverseName}");

            #endregion






            Console.ReadLine();
        }
    }
}
