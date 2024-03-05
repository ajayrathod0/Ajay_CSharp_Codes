using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WELCOME TO CALCULATOR APP");
            try
            {
                Console.WriteLine("Please Enter Numerator");
                int num = int.Parse(Console.ReadLine());

                Console.WriteLine("Please Enter Denomirator");
                int den = int.Parse(Console.ReadLine());

                Divide(num, den);
            }
            catch (FormatException ex) //try ke sath catch multiple likh sakte hai
            {
                Console.WriteLine($"{ex.Message}");
            }
            catch (OverflowException e) //OverflowException Exception ke derived class hai 
            {
                Console.WriteLine($"{e.StackTrace}  : {e.Message}");
            }

            catch (Exception ex)//Exception base class hai last me likhna mandatory hai
            {
                Console.WriteLine($"TYPE NAME : {ex.GetType().Name} EXCEPTION MESSAGE : {ex.Message}");
            }

            Console.ReadLine();
        }

        static void Divide(int num, int den)
        {
            try //try ke sath catch/fanally likhna mandatory hai try akela nahi aayenga
            {
                int div = num / den;
                Console.WriteLine($"Division {num} / {den} = {div}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception type: {ex.GetType().Name} and massege {ex.Message}");
            }
            finally //finally block run honga 100% , try catch se kuch lena dena nahi hai 
            {
                Console.WriteLine("DIvision Operation Completed");
            }
        }
    }
}
