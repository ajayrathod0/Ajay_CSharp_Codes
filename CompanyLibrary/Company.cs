using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyLibrary
{
    public class Company
    {
        public int CompanyId { get; set; }//Auto impeliment property 
        public string Name { get; set; }

        public Employee[] Employee { set; get; }// this Association

        public Company(Employee[] emps)
        {
            Employee = emps;
        }



        //INDEXER 
        public string this[int id] //int type se id input me de rahe hai or string (return type)output kar rahe hai
        {
            get//id se name return karenga 
            {
                string name = "No Employee";
                for (int i = 0; i < Employee.Length; i++)
                {
                    if (Employee[i].EmployeeId == id)
                    {
                        name = Employee[i].Name;
                        break;
                    }
                }

                return name;
            }
            set//id se name set(Change) karenga 
            {
                for (int i = 0; i < Employee.Length; i++)
                {
                    if (Employee[i].EmployeeId == id)
                    {
                        Employee[i].Name = value;
                    }
                }

            }

        }

        public Employee this[string name]
        {
            get//name se Employeee ki sari datails return karenga
            {
                for (int i = 0; i < Employee.Length; i++)
                {
                    if (Employee[i].Name == name)
                    {
                        return Employee[i];
                    }
                }
                return null; // name match nahi honga to null return karenga
            }
        }




        public void Datails()
        {
            Console.WriteLine($"Company Id : {CompanyId}  Name : {Name}");
        }
        public void AllEmployees()
        {
            if (Employee != null & Employee.Length > 0)
            {
                for (int i = 0; i < Employee.Length; i++)
                {
                    Console.WriteLine($"Employee ID: {Employee[i].EmployeeId}  Name:{Employee[i].Name} " +
                        $"City : {Employee[i].City}  Exprience {Employee[i].Experience}");
                }
            }

        }
    }
}
