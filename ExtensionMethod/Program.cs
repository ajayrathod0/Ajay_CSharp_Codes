using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ek esa method likhenge jiksa first word capital baki small
            //example  ToUpper() ,ToLower() yah method system me likhe hai 

            /*
                        Console.WriteLine("Enter Your First Name ");
                        string a = Console.ReadLine();
                        // string a = "ajay";
                        string b = a.ToCapitalCase();
                        Console.WriteLine(b);

            */

            //Extension Method = Audi class me Print() method nahi hai Print() method CarHelper class se acess kar 
            //rahe hai interface ki help se
            //Audi class ko interface se inharite kiya or public static class Carhelper ke method ke parameter me
            //"this" keyword interface ko as parameter diya vaha se audi object bana kar us class ko access kiya

            Audi s = new Audi();
            s.Print("A");//extenstion method

            BMW w = new BMW();
            w.Print("B");

            Console.ReadLine();
        }
    }
    public static class Student
    {
        public static string ToCapitalCase(this string name)
        {
            string result = string.Empty;
            for (int i = 0; i < name.Length; i++)
            {
                if (i == 0)
                {
                    result += name[i].ToString().ToUpper();//pahala latter Upper me karke denga
                }
                else
                {
                    result += name[i]; // baki ke same latter result me dal denga
                }
            }

            return result; //return kar denga jo result me store huva hai
        }
    }


    public interface Icar { }


    public class Audi : Icar
    {

    }
    public class BMW : Icar
    {
        
    }
    public static class CarHelper
    {
        public static void Print(this Icar o, string a)
        {
            Console.WriteLine($" {a}  Type : {o.GetType().Name}");
        }
    }
}
