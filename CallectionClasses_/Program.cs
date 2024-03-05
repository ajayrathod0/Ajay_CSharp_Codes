using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallectionClasses_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Array

            /*  int[] number = new int[2];
              number[0] = 10;
              number[1] = 20;
              number[3] = 30; //yaha exception aayenga kyu Array ki limit 2 hi hai
              for (int i = 0; i < number.Length; i++)
              {
                  Console.WriteLine(number[i]);
              }
  */
            #endregion

            #region ArrayList

            /*              ArrayList numbers = new ArrayList(2);
                        numbers.Add(10);
                        numbers.Add(20);
                        numbers.Add(30);
                                   for (int i = 0; i < numbers.Count; i++)
                                    {
                                        Console.WriteLine(numbers[i]);
                                    }
                                    Console.WriteLine("*** Origenal Array ***");

                        //for loop se bhi result nikal sakte hai or foreach loop se bhi



                        foreach (int item in numbers)
                        {
                            Console.Write(item);
                        }
                        Console.WriteLine();
                        Console.WriteLine();

                        ICollection temp = new ArrayList() { 40, 50, 60, 70 };
                        numbers.AddRange(temp);
                        foreach (var num in numbers)
                        {
                            Console.Write($"{num} "); //10,20,30,40,50,60,70
                        }
                        Console.WriteLine(); //space ke liye

                        Console.WriteLine("*** ICollection AddRange(temp) ***");



                        numbers.Insert(1, 13);
                        //second number par 13 add karenga insert method system se
                        foreach (int num in numbers)
                        {
                            Console.Write($"{num} ");//10,13,20,30,40,50,60,70
                        }
                        Console.WriteLine(); //space ke liye



                        ICollection temp2 = new ArrayList() { 16, 17, 18, 19 };
                        numbers.InsertRange(2, temp2);
                        //insertRange 2 index  se start karenga or print karenga add kar denga array ko
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} ");//10 13 16 17 18 19 20 30 40 50 60 70
                        }
                        Console.WriteLine();

                        //Contains method hame dund kar deta hai ki yah number hai ya nahi bool return karta hai 
                        // true|false
                        bool a = numbers.Contains(13);
                        Console.WriteLine(a); //trua
                        a = numbers.Contains(9);
                        Console.WriteLine(a); //false

                        numbers.Remove(13);//list me se 13 value ko remove kar denga
                        numbers.RemoveAt(0); // 0 number jo idex hai matlab 10 use remove kar denga

                        Console.WriteLine("***  remove(13) and removeAt(0)  ***");
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} ");
                        }
                        Console.WriteLine();



                        numbers.RemoveRange(0, 3); //0 number par index se 3 count tak remove kar denga

                        for (int i = 0; i < numbers.Count; i++)
                        {
                            Console.Write($"{numbers[i]} "); //19 20 30 40 50 60 70
                        }
                        Console.WriteLine();


                        // numbers.Clear();//remove All

            */

            #endregion

            #region Hashtable


            /*    Hashtable students = new Hashtable();
                students.Add(1, "Ajay");
                students.Add(2, "Vishal");
                students.Add(3, "yathart");

                Console.WriteLine($"*** All Item ***");
                foreach (DictionaryEntry item in students)
                {
                    Console.WriteLine($"{item.Key} {item.Value}");
                }
                bool b = students.ContainsKey(4);
                Console.WriteLine($"Contain Key : {b}"); //false matlab 4 key nahi hai  

                b = students.ContainsValue("Ajay");
                Console.WriteLine($"Value : {b}");//False Ajay name hai

                object val = students[1];
                Console.WriteLine(val); //jiski 1 key hongi uska value name aa jayenga
    */

            #endregion


            #region Stack

            /*
                        Stack visitedSites = new Stack();
                        visitedSites.Push("facebook.com");
                        visitedSites.Push("facebook.com/Friend");
                        visitedSites.Push("facebook.com/User/Ajay");

                        Console.WriteLine($"{visitedSites.Count}"); 

                        var site = visitedSites.Pop();//Pop() last added value deta hai or use remove kar deta hai
                        Console.WriteLine($"visitedSites.Pop() : {site}");
                        Console.WriteLine(visitedSites.Count);

                        site = visitedSites.Peek();//Peek() last added value deta hai or count ko remove nahi karta 
                        Console.WriteLine($"visitedSites.Peek() : {site}");
                        Console.WriteLine(visitedSites.Count);
            */

            #endregion

            #region Queue

            Queue token = new Queue();
            token.Enqueue("Ajay");
            token.Enqueue("Kishor");
            token.Enqueue("ganesh");
            token.Enqueue("chetan");
            Console.WriteLine($"token count : {token.Count}");

            foreach (var item in token)
            {
                Console.WriteLine(item);
            }

            var BankToken = token.Dequeue(); //Dequeue() : result first and remove first value
            Console.WriteLine($"Token Dequeue() : {BankToken}");

            Console.WriteLine($"Token count {token.Count}");
            Console.WriteLine();

            foreach (var item in token)
            {
                Console.WriteLine(item);
            }
            BankToken = token.Peek(); //Peek() : show first number value and not remove this value
            Console.WriteLine(BankToken);

            Console.WriteLine(token.Count);
            #endregion

            Console.ReadLine();
        }
    }
}
