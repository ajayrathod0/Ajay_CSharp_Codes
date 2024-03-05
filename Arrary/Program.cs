using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Arrary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //declaring Array = first way
            /* int[] fees = new int[4];
             fees[0] = 10000;
             fees[1] = 20000;
             fees[2] = 35000;
             fees[3] = 50000;
             Console.WriteLine($"Totel Lenght is : {fees.Length}");

             for (int i = 0; i < fees.Length; i++)
             {
                 Console.WriteLine($"Fees is : {fees[i]}");
             }

             //declaring Array = second way
             string[] Names = new string[] { "Ajay", "chetan", "ganesh" };

             for (int i = 0; i < Names.Length; i++)
             {
                 Console.WriteLine(Names[i]);
             }*/

            //--------------------------------------------------------------------------------------------
            // string[] email = null;
            //  Console.WriteLine(email.Length);  //run time error

            /*
                        email = new string[] { "ajayjathod@gmail.com", "ajay.Rathod.net@gmail.com" };

                        Console.WriteLine($"Totel Emails : {email.Length}");

                        for (int i = 0; i < email.Length; i++)
                        {
                            Console.WriteLine($"Emails : {email[i]}");
                        }*/

            #region Reverse array
            //----------------Reverse array----------------------------------------------------------------------------

            /* int[] number = new int[] { 2, 5, 0, 2, 2, 0, 0, 1 };
             Console.WriteLine("Numbers in array");

             for (int i = 0; i < number.Length; i++)
             {
                 Console.Write($"{number[i]} ");
             }
             Console.WriteLine("\nReverse array");

             for (int i = number.Length - 1; i >= 0; i--)
             {
                 Console.Write($"{number[i]} ");
             }
             Console.WriteLine("\n");*/
            #endregion Reverse array


            #region Find Highest Number
            //---------Find Highest Number-----------------------------------------------------------------------------

            /*   number = new int[] { 140, 45, 7, 3, 23, 4543, 334, 532, 4 };

               int highest = 0;

               for (int i = 0; i < number.Length; i++)
               {
                   for (int j = i + 1; j < number.Length; j++)
                   {
                       if (number[j] > highest)
                       {
                           highest = number[j];
                       }
                   }
               }
               Console.WriteLine($" HIGHEST NUMBER : {highest}\n");*/
            #endregion Find Highest Number


            #region reverse input string
            //---------------- reverse input string-------------------------------------------------------------------------------------

            /* Console.WriteLine("Enter Your First Name : ");
             string name = Console.ReadLine();
             string username = string.Empty;

             for (int i = name.Length - 1; i >= 0; i--)
             {

                 username += name[i];
             }
             Console.WriteLine($"your name: {name} \n Reverse Name is : {username}\n");*/

            #endregion reverse input string

            #region Reverse Words in Sentence
            //------------------Reverse Words in Sentence------------------------------------------------------------------------------

            /* Console.WriteLine("Enter a sentence :");
             string sentence = Console.ReadLine();

             string[] words = sentence.Split(new char[] { ' ' });

             Console.WriteLine("output : \n");
             for (int i = words.Length - 1; i >= 0; i--)
             {
                 Console.Write($"{words[i]}\n");
             }
            */
            #endregion Reverse Words in Sentence 

            #region Target number even number
            //----------------Target number tak sare even number without array-----------------------------------------------------------------------------------------------------

            /* Console.WriteLine("please enter a target number:");
             int target = int.Parse(Console.ReadLine());

             for (int i = 1; i <= target; i++)
             {
                 if (i % 2 == 0)
                 {
                     Console.Write($"{i} ");
                 }
             }
             Console.WriteLine(); //new Line*/
            #endregion Target number even number

            //-------------------Multi Dimensional Array---------------------------------------------------------------------------------------------------------------
            //two dimensional array

            int[,] numbers = new int[3, 3];

            for (int i = 0; i <= 3; i++)
            {
                for (int j = 0; j <= 3; j++)
                {
                    Console.Write($"{i}{j} ");
                }
                Console.WriteLine();
            }

            int[,] num = new int[3, 3];
            for (int i = 0; i <3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (i == j)
                    {
                        Console.Write($"*");
                    }
                    else
                    {
                        Console.Write($"\t");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }
    }
}
