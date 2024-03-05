//Ajay class
//Task
//Property

namespace PartialClass
{
    //Part 1
    public partial class Student : IStudent 
    {
        public string Name { get; set; }

        public Student()//constructor method call karne ke liye likha
        {
            PrintA();//partial method remove call
            //and remove declartion
        }
        partial void PrintA();//by default private
    }


    interface IStudent
    {
        void Print(); //interface ka method
        //agar inherite kar rahe hai interface ko to uske method ko initializtion karna mandatory hai
    }
}
