using CompanyLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibararyClient
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Employee a = new Employee() { EmployeeId = 1, Name = "Ajay", City = "Indore", Experience = 2 };
            a.Datails();


            a.Company = new Company() { CompanyId = 1, Name = "CG" };
            Console.WriteLine($"Company ID: {a.Company.CompanyId}  Name {a.Company.Name}");
*/

            Employee e1 = new Employee() { EmployeeId = 101, Name = "Ajay", City = "Indore", Experience = 2 };
            Employee e2 = new Employee() { EmployeeId = 102, Name = "Vishal", City = "Indore", Experience = 9 };
            Employee e3 = new Employee() { EmployeeId = 103, Name = "Vikul", City = "Pune", Experience = 12 };
            Employee e4 = new Employee() { EmployeeId = 104, Name = "Yatharth", City = "Mumbai", Experience = 1 };

            Employee[] Employees = new Employee[] { e1, e2, e3, e4 };
            Company c = new Company(Employees) { CompanyId = 1, Name = "TCS" };
            c.Datails(); //CompanyId = 1, Name = "TCS"
            c.AllEmployees();

            string name = c[101]; //get indexer me code
            Console.WriteLine($"Employee Name : {name}");

            c[101] = "AJJU";//set indexer me code
            name = c[101];
            Console.WriteLine($"Employee Name : {name}");


            Employee aj = c["AJJU"]; //index likha hai esliye sara datails aa raha hai AJJU Employee ka
            Console.WriteLine($"{aj.EmployeeId}  {aj.Name}  {aj.City}  {aj.Experience}");

            Console.ReadLine();
        }
    }
}
