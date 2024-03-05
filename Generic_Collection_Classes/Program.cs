using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic_Collection_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region  1.List<>
            /*   List<int> numbers = new List<int>();
               numbers.Add(10);
               numbers.Add(20);
               numbers.Add(30);
               numbers.Add(40);

               Console.WriteLine(numbers.Count); //4
               foreach (int item in numbers)
               {
                   Console.Write($"{item} ");
               }
               Console.WriteLine("_______________________________________________________________");

               List<int> temp = new List<int>() { 50, 60, 70 };
               numbers.AddRange(temp); //AddRange() value ko add karenge 

               numbers.Insert(1, 15); //insert method jo first argument hai vaha index number hai(postion)
                                      //us index me 15 add kar denga index 0 se start hota hai

               foreach (int item in numbers)
               {
                   Console.Write($"{item} "); //10 15 20 30 40 50 60 70
               }

               Console.WriteLine();
               Console.WriteLine(numbers.Count); //8

               bool b = numbers.Contains(30);
               Console.WriteLine(b); //true matlbal hai yah value

               b = numbers.Contains(35);
               Console.WriteLine(b);//false - 35 value nahi list me

               numbers.RemoveAt(0);  //remove 0 index par jo value hai '10'
               numbers.Remove(15); //list me se 15 value remove kar denga
               numbers.RemoveRange(1, 2); //1 index se 2 count tak ki value remove karenga


               foreach (int item in numbers)
               {
                   Console.Write($"{item} ");
               }

               // numbers.Clear();//all remove
   */
            #endregion


            #region 2. Dictionary<>

            /*            Dictionary<int, string> students = new Dictionary<int, string>();
                        students.Add(1, "Ajay");
                        students.Add(2, "Vishal");
                        students.Add(3, "Rupesh");

                        Console.WriteLine($"students Count{ students.Count} "); // 3

                        foreach (KeyValuePair<int, string> item in students)
                        {
                            Console.WriteLine($"{item.Key}  {item.Value} ");
                        }


                        //ContainsKey() dund kar denga key and value hai ya nahi list me , yah bool return karta hai
                        bool b = students.ContainsKey(2);
                        Console.WriteLine(b);//true - key 2 hai esliye true

                        b = students.ContainsValue("Vijay"); 
                        Console.WriteLine(b);//false

                        string name = students[1];
                        Console.WriteLine(name);//jiski key 1 hongi uska value aayenga = Ajay
            */
            #endregion


            #region 3. Stack<>
            /*
                        Stack<string> names = new Stack<string>();
                        names.Push("jay");
                        names.Push("Ajay");
                        names.Push("Vijay");

                        Console.WriteLine(names.Count); //3

                        foreach (string item in names)
                        {
                            Console.WriteLine(item); //Vijay Ajay jay
                        }

                        string name = names.Pop(); //Pop() return last value and remove value 
                        Console.WriteLine(name);//vijay
                        Console.WriteLine(names.Count); //2

                        name = names.Peek(); //Peek() return last value and not remove value 
                        Console.WriteLine(name);//ajay
                        Console.WriteLine(names.Count);//2
            */

            #endregion

            #region 4. Queue<>

            Queue<string> Names = new Queue<string>();
            Names.Enqueue("Ajay");
            Names.Enqueue("Jay");
            Names.Enqueue("Vishal");

            Console.WriteLine(Names.Count);//3

            string name = Names.Dequeue();  //return first value and remove
            Console.WriteLine(name); //Ajay
            Console.WriteLine(Names.Count);//2

            Names.Peek();//return first value end not remove
            Console.WriteLine(name);//Jay
            Console.WriteLine(Names.Count);//2

            foreach (string i in Names) { Console.WriteLine(i); }
            #endregion

            Console.ReadLine();

        }
    }
}
