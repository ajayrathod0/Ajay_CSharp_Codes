using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
        public int Experience { get; set; }//property
        public Company Company { set; get; }//property   / this is Associstion




        public void Datails()
        {
            Console.WriteLine($"Employee Id: {EmployeeId} Name : {Name}  City : {City} "  +
            $"Experimence : {Experience}");
        }

    }
}
