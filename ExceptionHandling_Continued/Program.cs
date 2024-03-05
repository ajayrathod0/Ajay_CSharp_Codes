using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling_Continued
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("WelCome to Calculator App");
                Console.WriteLine("Enter a Numeritor Number:");
                int numerator, denominator;

                if (int.TryParse(Console.ReadLine(), out numerator))
                {
                    Console.WriteLine("Enter a Denominator number:");
                    if (int.TryParse(Console.ReadLine(), out denominator))
                    {
                        Divide(numerator, denominator);
                    }
                    else
                    {
                        Console.WriteLine("Please Enter Valid Denominator");
                    }
                }
                else
                {
                    Console.WriteLine("Please Enter Valid Numerator");
                }
                Console.WriteLine("Thank You Visit Again");

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();

        }

        static void Divide(int num, int den)
        {
            #region
            /*
                        if (den != 0)
                        {
                            int div = num / den;
                            Console.WriteLine($"{num} / {den} = {div}");
                        }
                        else
                        {
                            Console.WriteLine("Denominator can not zero");
                        }
            */
            #endregion


            try
            {
                /* if (den == 0)
                 {
                     throw new Exception("denominator is zero");
                 }
 */
                int div = num / den;
                Console.WriteLine($"{num} / {den} = {div}");
            }
            catch (Exception ex)
            {
                throw new Exception("denominator is zero");

                //Console.WriteLine($"Divide() catch block: {ex.Message}");
            }
            Console.WriteLine("Divistion operation completed");
        }
    }
}
