using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Property
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*  //setter getter call
              Student s1 = new Student();
              s1.SetRollnumber(-2);
              Console.WriteLine($"Roll Number : {s1.GetRollNumber()}");//Roll Number Can not Nagative
                                                                     //  Roll Number 0

              s1.SetName("Ajay");
              Console.WriteLine($"Name : {s1.GetName()} Pass mark : {s1.GetPassmark()}");
           */

            Student s = new Student();
            s.RollNumber = 1;
            s.Name = "Ajay";
            Console.WriteLine($"Roll Number : {s.RollNumber} Name : {s.Name} mark : {s.Passmark}");

           

            Console.ReadLine();
        }
    }

    #region setter getter method

    /* public class Student
    {
        private int _rollNumber;
        private string _name;
        private int _passmark = 35;

        public void SetRollnumber(int rollnumber)//setter method(set)
        {
            if (rollnumber > 0)
            {
                _rollNumber = rollnumber;
            }
            else
            {
                _rollNumber = 0;
                Console.WriteLine("Roll Number Can not Nagative");
            }
        }
        public int GetRollNumber()//getter mathod(read)
        {
            return _rollNumber;
        }



        public void SetName(string name)//set
        {
            _name = name;
        }
        public string GetName()//read
        {
            return !string.IsNullOrEmpty(_name) ? _name : "No Name Provided";
        }

        public int GetPassmark()
        {
            return _passmark;
        }
        //no set metter() method passmark feild me hi set kar diya value

    }*/

    #endregion

    #region Property
    public class Student
    {
        private int _rollNumber;
        private string _name;
        private int _passMark = 35;

        public int RollNumber
        {
            get
            {
                return _rollNumber;
            }
            set
            {
                if (value > 0)
                {
                    _rollNumber = value;

                }
                else
                {
                    _rollNumber = 0;
                    Console.WriteLine("RollNumber Can not nagetive");
                }

            }
        }

        public string Name
        {
            get
            {
                return !string.IsNullOrEmpty(_name) ? _name : "Envaild Name";
            }
            set
            {
                _name = value;
            }
        }
        public int Passmark
        {
            get
            {
                return _passMark;
            }
        }


        private string _city; //feild

        public string City //property
        {
            set
            {
                _city = value;
            }
            get
            {
                return _city;
            }
        }

        public string Email { set; get; } //Auto Emplemented Property
        public string Standerd { get; set; }

    }
    #endregion
}
