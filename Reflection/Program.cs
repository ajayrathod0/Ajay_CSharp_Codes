using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_
{
    public class Program
    {
        static void Main(string[] args)
        {
            //reflection ki help se ham assembly se type members ko get kar sakte hai 
            //jo get kar rahe hai vo assembly me hona chaiye 

            Assembly assembly = Assembly.GetExecutingAssembly();
            Type customer = assembly.GetType("Reflection_");

            if (customer != null)
            {

                object c = Activator.CreateInstance(customer);

                if (c != null)
                {
                    MethodInfo PrintA = customer.GetMethod("PrintA");
                    if (PrintA != null)
                    {
                        PrintA.Invoke(c, null);
                    }

                    MethodInfo PrintC = customer.GetMethod("PrintC");
                    Console.WriteLine("Enter Your FirstName ");
                    string fn = Console.ReadLine();
                    Console.WriteLine("Enter Your LastName ");
                    string ln = Console.ReadLine();
                    PrintC.Invoke(c, new object[] { fn, ln });
                }

                MethodInfo PrintB = customer.GetMethod("PrintB");
                PrintB.Invoke(null, null);


                MethodInfo PrintD = customer.GetMethod("printD",
                    BindingFlags.NonPublic | BindingFlags.Instance);
                PrintD.Invoke(c, null);
            }









            /*  Console.WriteLine("*** All Methods ***");
              MethodInfo[] methods = customer.GetMethods();
              for (int i = 0; i < methods.Length; i++)
              {
                  Console.WriteLine(methods[i].Name);
              }*/

            /* Console.WriteLine("*** All Property ***");
             PropertyInfo[] property = customer.GetProperties();
             for (int i = 0; i < property.Length; i++)
             {
                 Console.WriteLine($" Property Name : {property[i].Name}  Property Type " +
                     $"{property[i].PropertyType}");
             }*/


            Console.ReadLine();
        }
    }
    public class Customer
    {
        public int Id { get; set; }
        public string Name { set; get; }

        public void PrintA()
        {
            Console.WriteLine("Print() :  called");
        }
        public static void PrintB()
        {
            Console.WriteLine("PrintB() :  called ");
        }
        public void PrintC(string firstname, string lastname)
        {
            Console.WriteLine($"PrintC : Called {firstname} {lastname}");
        }
        private void PrintD()
        {
            Console.WriteLine("PrintD called");
        }
    }
}
