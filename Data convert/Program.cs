using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data_convert
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //--------------------------  String type  ------------------------------------------------------
            //**********************************************************************************************


            /*int i = 10, j = 20;
            Console.WriteLine(i+j); //30
*/
            string Name = "Ajay";
            Console.WriteLine(Name); //Ajay

            Name = "     Ajay";
            Console.WriteLine(Name); //     Ajay

            //------------ Trim()   block space----------------

            Console.WriteLine(Name.Trim());  //Ajay



            Name = "Ajay";

            //------------            ToUpper()  case Name    -------------------

            Console.WriteLine(Name.ToUpper());


            //------------           TOLower()   case Name  --------------------
            Console.WriteLine(Name.ToLower());

            //Q. result = "AJAY"
            // Ans ->    using Escape Sequence \
            Name = "\"Ajay\"";
            Console.WriteLine(Name.ToUpper());

            //Q. result = 'ajay'
            Name ="\'Ajay\'";
            Console.WriteLine(Name.ToLower());


            //Q. result = \Ajay\
            Name = "\\Ajay\\";
            Console.WriteLine(Name);


            // kisi file/img/video ka path dena rahe to =>
            String path = @"C:\Users\ajayj\OneDrive\Pictures";
            Console.WriteLine(path);


            //Q. result = Ajay Rathod
            String firstname = "Ajay",
                    lastname = "Rathod";

            String fullname = firstname + " " + lastname;
            Console.WriteLine(fullname);  // Ajay Rathod




            // Concat()  concat me 3 Argument hote hai exam..
            fullname = String.Concat(firstname, " ", lastname);
            Console.WriteLine(fullname);  //Ajay Rathod

            String middlename = "Kumar";
            fullname = String.Concat(firstname," ",middlename," ", lastname);
            Console.WriteLine(fullname.ToUpper());   //AJAY KUMAR RATHOD


            //Join()   join me multi Argument de sakte hai join me pahla argumet jo
            //         denge vaha by default sab me use honga exmaple " "(space)
            fullname = String.Join(" ", firstname,middlename,lastname);
            Console.WriteLine(fullname.ToLower());  //ajay kumar rathod

            // Q)   Result => Full Name : Ajay Kumar Rathod
            fullname = String.Join(" ", "Full", "Name", ":", firstname, middlename, lastname);
            Console.WriteLine(fullname);


            //Placeholder syntax -----------------------------------------------------------
            fullname = String.Format("Full Name : {0} {1} {2} ", firstname, middlename, lastname);
            Console.WriteLine(fullname); //Full Name : Ajay Kumar Rathod


            //String interpolation => interpolation me placeholder ki jahag var likh sakte hai
            fullname = $"full name : {firstname} {middlename} {lastname} ";
            Console.WriteLine(fullname.ToUpper());

            fullname = $"My Name is : {firstname}";
            Console.WriteLine(fullname);

           //---------------------------------------------------------------------------------------------------------
           //*********************************************************************************************************
           //--------------------------------------- Datatype Conversion------------------------------------------------------------------
           //converting one type value in another type
           // jo aasani se convert ho jaye use ham "1.implicit converesion" boleng

            int i = 10 , j = 10 ;

            //int => String 
            String a = i.ToString();
            String b = j.ToString();
            Console.WriteLine(a+b); //1010

            //byte => short
            byte bt = 10;
            short s = bt;
            Console.WriteLine(s); //10

            //Short => float
            float f = s;
            Console.WriteLine($"{f} : {sizeof(float)}");  //10 : 4

            //Float => int
            //yah convert nahi honga iske liye "2. Explicit Conversion" hai
            int i1 =(int)f;
            Console.WriteLine(i1); //10

            // convert class method :

            //String => int
            String st = "2000";
            i1 = Convert.ToInt32(st);
            Console.WriteLine(i1); //2000

            // String => bool
            string ss = "true";
            bool bb = Convert.ToBoolean(ss);
            Console.WriteLine(bb); //true


            //parse()
            //String => int 
            String s1 = "7777";
            int Aj = int.Parse(s1);
            Console.WriteLine(s1); //7777

            //TryParse()
            //String => int
            String S2 = "2000";
            int.TryParse(S2, out Aj);
            Console.WriteLine($" Status : {bb} \n Result : {S2}"); //status : true Result : 2000

            String SS = "XYZ";
            int.TryParse(SS, out Aj);
            Console.WriteLine($"Status : {bb} \n Result : {Aj}"); // status : true result : 0







           // Console.ReadLine();
        }
    }
}
