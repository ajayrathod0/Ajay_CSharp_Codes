using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_Condintion_Statements
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region if else 
            /*
                        int i = 10, j = 12;
                        if (i == j)
                        {
                            Console.WriteLine($"{i} And {j} are EQUAL");
                        }
                        else
                        {
                            Console.WriteLine($"{i} And {j} are NOT EQUAL");
                        }
            */
            #endregion if else
            //-----------------------------------------------------------------------------------------------------------


            #region ternary operator
            /* string a = (i == 10) ? ("TEN") : ("NOT TEN");
             Console.WriteLine(a);
 */
            #endregion



            //----------------------------------------------------------------------------------------------------------------


            #region if-else if-else lader

            /* i = 50;
             if (i == 10)
             {
                 Console.WriteLine($"TEN : {i}");
             }
             else if (i == 20)
             {
                 Console.WriteLine($"TWINTY : {i}");
             }
             else if (i == 30)
             {
                 Console.WriteLine($"THIRTY : {i}");
             }
             else
             {
                 Console.WriteLine($"{i} NOT 10,20 or 30");
             }*/


            #endregion if-else if-else lader

            //----------------------------------------------------------------------------------------------------------

            #region if else grater value

            //user se input lenge

            /* 
             Console.WriteLine("Enter  first Number ");
             int a = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter Second Number ");
             int b = int.Parse(Console.ReadLine());

             if (a > b)
             {
                 Console.WriteLine($"{a} grater then {b}");
             }
             else if (b > a)
             {
                 Console.WriteLine($"{b} grater then {a}");
             }
             else
             {
                 Console.WriteLine($"{a} and {b} are Equal");
             }

             */
            #endregion if else grater value

            //----------------------------------------------------------------------------------------------------------------------------

            #region nested if else
            /*
                        Console.WriteLine("ENTER FIRST NUMBER ");
                        int first = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER SECOND NUMBER ");
                        int second = int.Parse(Console.ReadLine());
                        Console.WriteLine("ENTER THIRD NUMBER ");
                        int third = int.Parse(Console.ReadLine());

                        if (first > second)
                        {
                            if (first > third)
                            {
                                Console.WriteLine($"{first} is grater Number ");
                            }
                            else
                            {
                                Console.WriteLine($"{third} is grater Number");
                            }
                        }
                        else if (second > first)
                        {
                            if (second > third)
                            {
                                Console.WriteLine($"{second} is grater number ");
                            }
                            else
                            {
                                Console.WriteLine($"{third} is grater number ");
                            }
                        }

                        else
                        {
                            if (first > third)
                            {
                                Console.WriteLine($"{first} and are {second} Equal number ");
                            }
                            else
                            {
                                Console.WriteLine($"{third} is grater number ");
                            }
                        }
            */

            #endregion nested if else


            //------------------------------------------------------------------------------------------------------------------------------


            #region Switch
            /*
                        int i = 50;
                        switch (i)
                        {
                            case 10:

                                Console.WriteLine($"{i} : TEN");
                                break;

                            case 20:
                                Console.WriteLine($"{i} : TWENTY");
                                break;

                            case 30:
                                Console.WriteLine($"{i} : THIRTY");
                                break;
                            default:
                                Console.WriteLine($"{i} Not 10 , 20 or 30");
                                break;
                        }
            */
            #endregion Switch

            //--------------------------------------------------------------------------------------------------------------------------------------

            #region nested ternary operator grater number
            /*
                        Console.WriteLine("Enter First Number ");
                        int frist = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Second Number ");
                        int second = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Third Number ");
                        int third = int.Parse(Console.ReadLine());

                        int number = (frist > second) ? ((frist > third) ? frist : third) : ((second > third) ? second : third);
                        Console.WriteLine($"{number} is grater number");

            */


            #endregion nasted ternary operator


            //--------------------------------------------------------------------------------------------------------------------------------


            #region  even odd number 

            /*  Console.WriteLine("Enter a Number");
              int num = int.Parse(Console.ReadLine());
              string result = (num % 2 == 0) ? "EVEN" : "ODD";

              Console.WriteLine($"{num} is {result} Nomber ");
  */
            #endregion even odd number

            //--------------------------------------------------------------------------------------------------------------------------------------



            #region greade using switch
            /*
                        Console.WriteLine("Please Enter a greade");
                        char greade = char.Parse(Console.ReadLine().ToUpper());

                        switch (greade)
                        {
                            case 'A':
                                Console.WriteLine($"{greade} : First Class");
                                break;

                            case 'B':
                                Console.WriteLine($"{greade} : Second Class");
                                break;

                            case 'C':
                                Console.WriteLine($"{greade} : Third Class");
                                break;

                            case 'D':
                                Console.WriteLine($"{greade} : Fourt Class");
                                break;

                            case 'F':
                                Console.WriteLine($"{greade} : Failed");
                                break;

                            default:
                                Console.WriteLine($"{greade} invalid gread");
                                break;

                        }

            */
            #endregion greade using switch case


            string a = "Ajay";
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(a);
            }

            Console.ReadLine();
        }
    }
}
