using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Loops_practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region syntax
            /* Console.WriteLine("Enter Your Name");
             String username = Console.ReadLine();
             Console.WriteLine("Your Name is: " + username);*/

            /*int? i =  null;
            Console.WriteLine(i);

            bool? type = null;
            Console.WriteLine(type);
*/
            #endregion syntax


            #region for loop

            /*  for(int start =1; start<=10; start++)
              {
                  Console.WriteLine(start);
                  continue;
              }
  */
            #endregion for loop

            #region while loop

            /* int a = 1;
             while (a<=10) {
                 Console.WriteLine(a);
                 a++;
             }
 */
            #endregion while loop

            #region Do while

            /*int a = 1;
            do
            {
                Console.WriteLine(a);
                a++;
            } while (a <= 12);

*/
            #endregion Do while

            /* #region user se input Full name
              Console.WriteLine("Enter Your Fist Name: ");
              string a = Console.ReadLine();
              Console.WriteLine("Enter your middle Name :");
              string b=Console.ReadLine();
              Console.WriteLine("Enter your Last Name :");
              string c= Console.ReadLine();

              Console.WriteLine($"Your Full Name is : {a} {b} {c}");

             #endregion user se input full name */


            /*       #region greater number


                   Console.WriteLine("Enter 1st number :");
                   int first = int.Parse(Console.ReadLine());
                   Console.WriteLine("Enter 2nd number :");
                   int second = int.Parse(Console.ReadLine());
                   Console.WriteLine("Enter 3rd number :");
                   int third = int.Parse(Console.ReadLine());
                   Console.WriteLine($"Your enter number is : {first} , {second} ,{third}");



                   if (first > second)
                   {
                       if (first > third)
                       {
                           Console.WriteLine($"{first} is grater number");
                       }
                       else
                       {
                           Console.WriteLine($"{third} is grater number");

                       }
                   }

                   else if (second > first)
                       if (second > third)
                       {
                           Console.WriteLine($"{second} is grater number");

                       }
                       else
                       {
                           Console.WriteLine($"{third} is grater number");
                       }

                   else
                   {
                       if (first > third)
                       {
                           Console.WriteLine($"{first} and {second} are grater number");
                       }
                       else
                       {
                           Console.WriteLine($"{third} is grater number");
                       }
                   }

                   #region greater number
       */


            /*  #region Nested ternary 
              Console.WriteLine("Enter 1st number :");
              int first = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter 2nd number :");
              int second = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter 3rd number :");
              int third = int.Parse(Console.ReadLine());
             Console.WriteLine($"Your enter number is : {first} , {second} ,{third}");

              //   int number = (first > second) ? first : second;
                //  Console.WriteLine(number);

              int number = (first > second)
                           ?((first>third) ? first:third )
                           :((second > third)? second :third);

              Console.WriteLine($"{number} is greater number (with nasted ternary)");
              #endregion nested ternary*/


            #region devition 3 % 5
            /*//// if input number is divisible by 3 = THREE
            //// if input number is divisible by 5 = FIVE
            //// if input number is divisible by 3 & 5 = THREEFIVE
            Console.WriteLine("Enter Number : ");
            int a = int.Parse(Console.ReadLine());

            if (a % 3 == 0 && a % 5 == 0)
            {
                Console.WriteLine("THREE_FIVE");
            }
            else if (a % 3 == 0)
            {
                Console.WriteLine("THREE");
            }
            else if (a % 5 == 0)
            {
                Console.WriteLine("FIVE");

            }*/
            #endregion devition 3 % 5


            #region EVEN & ODD 
            /* Console.WriteLine("Enter a number : ");
             int a = int.Parse(Console.ReadLine());

             string result = (a % 2 == 0) ? "EVEN" : "ODD";
             Console.WriteLine(result);*/
            #endregion EVEN & ODD

            #region switch case grade 

            /* Console.WriteLine("Enter your Grade :");
             char grade = char.Parse(Console.ReadLine().ToUpper());

             switch (grade)
             {
                 case ('A'):
                     Console.WriteLine($"{grade} : Distinction");
                     break;

                 case ('B'):
                     Console.WriteLine($"{grade} : first class");
                     break;

                 case ('C'):
                     Console.WriteLine($"{grade} : second class");
                     break;

                 case ('F'):
                     Console.WriteLine($"{grade} : faild");
                     break;
                 default :
                     Console.WriteLine($"{grade} :invalid grade");
                     break;
             }*/
            #endregion switch case grade

            #region

            // Console.WriteLine("Enter a number :");

            /*
                int num1, num2, result;
                Console.WriteLine("enter 1st number :");
                num1 = int.Parse(Console.ReadLine());

                Console.WriteLine("enter 2nd number :");
                num2 = int.Parse(Console.ReadLine());

                result = num1 * num2;
                Console.WriteLine($"num1 * num2 = {result}"); */


            #endregion

            #region Foor loop

            /*  for (int i = 1; i <= 5; i++)
              {
                  for (int j = 1; j < 5; j++)
                  {
                      Console.Write($" *\t ");
                  }
                  Console.ReadLine();
              }


            for (int i = 1; i <= 5; i++)
            {

                for (int j = 1; j <= 5; j++)
                {
                    Console.Write($"*\t");
                }
                Console.WriteLine();
            }*/
            
            #endregion Foor loop
            Console.ReadLine();
        }
    }
}
