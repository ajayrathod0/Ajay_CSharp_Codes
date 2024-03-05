using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.Remoting.Lifetime;
using System.Runtime.Remoting.Services;
using System.Text;
using System.Threading.Tasks;

namespace Assigment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            #region 1.Write a program for coffee shop.

            //   display menu to user -
            // Please choose coffee size
            // 1 - small 2 - Medium 3 - Large
            //Total bill amount -

            /*
                        Console.WriteLine("Please choose coffe size: 1.small 2. medium 3.large ");
                        string size = Console.ReadLine().ToUpper();
                        switch (size)
                        {
                            case "SMALL":
                                Console.WriteLine($"Coffee size {size} Your Bill Amount Rs.100");
                                break;
                            case "MEDIUM":
                                Console.WriteLine($"Coffee size {size} Your Bill Amount Rs.150");
                                break;

                            case "LARGE":
                                Console.WriteLine($"Coffee Size {size} Your Bill Amount Rs.200");
                                break;
                            default:
                                Console.WriteLine("No Select Coffee");
                                break;
                        }

            */
            #endregion

            #region 2. Write a program to find whether the given input is prime or not

            /*
                        Console.WriteLine("Please Enter a Number");
                        int num = int.Parse(Console.ReadLine());
                        int a = 0;

                        for (int i = 2; i <= num / 2; i++)
                        {
                            if (num % i == 0)
                            {
                                a++;
                                break;
                            }
                        }

                        if (a == 1)

                        {
                            Console.WriteLine($"{num} is not  Prime number");
                        }
                        else
                        {
                            Console.WriteLine($"{num}  prime");
                        }

            */

            #endregion

            #region 3.Write a program to print all prime numbers till target.
            /*
                        Console.WriteLine("Please Enter A target Number");
                        int target = int.Parse(Console.ReadLine());
                        Console.WriteLine("Prime Number is");
                        for (int i = 1; i <= target; i++)
                        {
                            int a = 0, k = 0;
                            k = i / 2;
                            for (int j = 2; j <= k; j++)
                            {
                                if (i % j == 0)
                                {
                                    break;
                                }
                                if (a == 0)
                                {
                                    Console.WriteLine($"{i}");
                                    break;
                                }
                            }
                        }*/

            #endregion

            #region   4.Write a program to print fibonacci series.

            /*1
                        int f1 = 0, f2 = 1, f3 = 0;
                        Console.WriteLine("Please Enter Fibonacci Limit");

                        int target = int.Parse(Console.ReadLine());
                        Console.WriteLine(f1);
                        Console.WriteLine(f2);
                        for (int i = 1; i < target; i++)
                        {
                            f3 = f1 + f2;
                            Console.WriteLine(f3);

                            f1 = f2;
                            f2 = f3;
                        }


            //2

            // Sir bataya class m

             // int num = 5;
            // 5 factorial = 5 * 4 * 3 * 2 * 1 = 120

            //int factorial = 1;
            //for (int i = num; i  > 0; i--)
            //{
            //    factorial *= i;
            //}
            //Console.WriteLine(factorial);

            */
            #endregion

            #region 5.Write a program to find if a given string is palindrome

            /*
                        Console.WriteLine("Enter Name check palindrome or not");
                        string name = Console.ReadLine().ToUpper();
                        string reverse = string.Empty;
                        for (int i = name.Length - 1; i >= 0; i--)
                        {
                            reverse += name[i];
                        }

                        if (name == reverse)
                        {
                            Console.WriteLine($"{name} is Palindrome string {reverse}");
                        }
                        else
                        {
                            Console.WriteLine($"{name} is Not Palindrome {reverse}");
                        }*/


            #endregion

            #region 6. Write a program to find if a given number is armstrong
            /*
                        Console.WriteLine("Enter Number Check armstrong Number");
                        int num = int.Parse(Console.ReadLine());
                        int temp = 0;
                        double sum = 0;
                        int a = num; 
                        for (int i = 0; i < 3; i++)
                        {
                            temp = num % 10;
                            sum += Math.Pow(temp, 3);
                            Console.WriteLine($"{temp}");
                            num = num / 10;
                        }
                        if (a == sum)
                        {

                            Console.WriteLine($"This is Armstrong Number: {sum}");
                        }
                        else
                        {
                            Console.WriteLine($"Not Armstrong Number : {sum}");
                        }
            */
            #endregion

            #region 7. Write a program to reverse a string. (without using reverse method
            /*
                        Console.WriteLine("Enter Your first Name");
                        string name = Console.ReadLine();
                        string rv = string.Empty;

                        for (int i = name.Length - 1; i >= 0; i--)
                        {
                            rv += name[i];
                        }
                        Console.WriteLine($"Name {name} Revers name {rv}");

            */
            #endregion

            #region 8.Write a program to reverse given array.
            /*
                        Console.Write("Enter five numbers:");
                        int[] numbers = new int[5];
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            numbers[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        Console.WriteLine("\nReverse array");
                        for (int i = numbers.Length - 1; i >= 0; i--)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
            */

            #endregion

            #region 9.Write a program which take input from user -
            //print 'THREE' if that number is divisbile by 3.
            //print 'FIVE' if that number is divisbile by 5.
            //print 'THREEFIVE' if that number is divisbile by 3 & 5 both.
            /*
                        Console.WriteLine("Enter Number");
                        int num = int.Parse(Console.ReadLine());

                        if (num % 3 == 0 && num % 5 == 0)
                        {
                            Console.WriteLine($"{num} divisbile by THREEFIVE");
                        }

                        else if (num % 5 == 0)
                        {
                            Console.WriteLine($"{num} divisbile by FIVE");
                        }
                        else if (num % 3 == 0)
                        {
                            Console.WriteLine($"{num} divisbile by THREE");
                        }*/
            #endregion

            #region 10. Write a program to print below series:
            // (easy with 2 for loops but try with single for loop)
            // if input is 4 -
            //o/p  1 3 2 4
            //if input is 5
            //o/p  1 3 5 2 4
            /*
                        Console.WriteLine("Enter a number");
                        int n = int.Parse(Console.ReadLine());
                        int a = 0;

                        for (int i = 1; i <= n; i++)
                        {

                            if (i <= n / 2 + (n % 2))
                            {
                                Console.Write("  " + (i + a));
                                a++;
                            }
                            else
                            {
                                a--;
                                Console.Write("  " + (i - a));

                            }


                        }*/

            #endregion

            #region 11. Write a program to sort a array using bubble sort.

            /*
                        int[] a = { 2, 5, 8, 3, 4 };
                        int temp = 0;
                        for (int i = 0; i < a.Length; i++)
                        {
                            for (int j = 0; j < a.Length - 1; j++)
                            {
                                if (a[j] > a[j + 1])
                                {
                                    temp = a[j];
                                    a[j] = a[j + 1];
                                    a[j + 1] = temp;
                                }

                            }
                        }
                        Console.WriteLine("Print Sorted Numbers :");
                        for (int i = 0; i <= (a.Length - 1); i++)
                        {
                            Console.Write(a[i]);
                        }

            */

            #endregion

            #region 12. Swap two numbers using third temporary variable.
            /*
                        int var1 = 10;
                        int var2 = 20;
                        int temp;

                        Console.WriteLine($"Before Swaping Number var1 = {var1} , var2 = {var2}");

                        temp = var1;
                        var1 = var2;
                        var2 = temp;

                        Console.WriteLine($"After Swaping Number va1 = {var1} , var2 = {var2}");
            */
            #endregion

            #region 13. Swap two numbers without using third variable.
            /*
                        int i = 50;
                        int j = 100;

                        Console.WriteLine($"Before Swaping number i = {i} , j = {j}");

                        i = i + j;  // i(150) = 50+100
                        j = i - j;  // j(50) = 150-100
                        i = i - j;  // i(100) = 150-50 

                        Console.WriteLine($"After Swaping Without 3rd varable i = {i} , j = {j}");
            */
            #endregion

            #region 15. Write a program to find highest number from array.
            /*
                        int[] numbers = new int[] { 45, 5, 7, 32, 56, };
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
                        }
                        Console.WriteLine($"{highest} is HIGHEST Number");
            */
            #endregion

            #region 16. Write a program to find second highest number from array. 
            /*
                        Console.Write("Enter five numbers:");
                        int[] arr = new int[5];
                        for (int i = 0; i < arr.Length; i++)
                        {
                            arr[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        int temp;

                        for (int i = 0; i < 5; i++)
                        {
                            for (int j = i + 1; j < 5; j++)
                            {
                                if (arr[i] > arr[j])
                                {
                                    temp = arr[i];
                                    arr[i] = arr[j];
                                    arr[j] = temp;
                                }
                            }
                        }
                        Console.WriteLine("Second highest number is:" + arr[5 - 2]);
            */




/*
            List<int> num = new List<int> { 3, 5, 8, 23, 65, 89, 45 };
            int secondHighest = num.OrderByDescending(i => i).Take(2).Min();
           // int secondHighest = num.OrderByDescending(i => i).Take(2).Skip(1).FirstOrDefault();

            Console.WriteLine(secondHighest);//65

*/
            

            #endregion

            #region 17. Write a program to find pairs from array whose sum is equal to 30.
            /*
                        int[] arr = { 15, 15, 10, 4, 5, 6, 20 };

                        for (int i = 0;i< arr.Length; i++)
                        {
                            for (int j = i + 1; j < arr.Length; j++)
                            {
                                if (arr[i] + arr[j] == 30)
                                {
                                    Console.WriteLine($"{arr[i]}  and {arr[j]} Pair found which has sum=30");
                                }
                            }
                        }
            */
            #endregion

            Console.ReadLine();
        }
    }
}
