using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Join_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ALL EMPLOYEE
            List<Employee> employees = Employee.GetEmployee();
            Console.WriteLine("***All Employee**");
            foreach (Employee item in employees)
            {
                Console.WriteLine($"Employee Id : {item.EmployeeId} Employee Name : {item.EmployeeName} " +
                    $" Experince : {item.Experince} Department Id : {item.DepartmentId} ");
            }
            Console.WriteLine();


            //ALL DEPARTMENT
            List<Department> departments = Department.GetDepartment();
            Console.WriteLine("***ALL Department***");
            foreach (Department item in departments)
            {
                Console.WriteLine($"Department ID : {item.DepartmentId} " +
                    $"Department Name : {item.DepartmentName} ");
            }
            Console.WriteLine();



            //Method Syntax
            Console.WriteLine("-----------------------   Method Syntax  ---------------------------------------");


            //inner (Join)
            var result = employees.Join(departments, b => b.DepartmentId, a => a.DepartmentId,
            (e, t) => new
            {
                EmployeeName = e.EmployeeName,
                DepartmentName = t.DepartmentName,
            });
            Console.WriteLine("Method syntax Inner Join");
            foreach (var item in result)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();




            //Left (Group join)
            var result1 = employees.GroupJoin(departments, a => a.DepartmentId, b => b.DepartmentId,
                (e, tt) => new
                {
                    EmployeeName = e.EmployeeName,
                    DepartmentName = tt.FirstOrDefault()?.DepartmentName
                });

            Console.WriteLine("Method syntax Left Join");
            foreach (var item in result1)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();




            // Query Syntax

            Console.WriteLine("-----------------------   Query Syntax  ---------------------------------------");





            //inner join
            var inner = from e in employees
                        join d in departments
                        on e.DepartmentId equals d.DepartmentId
                        select new
                        {
                            EmployeeName = e.EmployeeName,
                            DepartmentName = d.DepartmentName
                        };
            Console.WriteLine("***Query syntax Inner Join***");
            foreach (var item in result)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();



            //Left Join

            var left = from e in employees
                       join d in departments
                       on e.DepartmentId equals d.DepartmentId
                       into temp
                       from dd in temp.DefaultIfEmpty()
                       select new
                       {
                           EmployeeName = e.EmployeeName,
                           DepartmentName = dd?.DepartmentName
                       };
            Console.WriteLine("***Query syntax Left Join***");
            foreach (var item in left)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();



            //Right join

            var right = from d in departments
                        join e in employees
                        on d.DepartmentId equals e.DepartmentId
                        into temp
                        from ee in temp.DefaultIfEmpty()
                        select new
                        {
                            EmployeeName = ee?.EmployeeName,
                            DepartmentName = d.DepartmentName
                        };
            Console.WriteLine("***Query syntax Right Join***");
            foreach (var item in right)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();





            //Full Join 

            var full = left.Union(right);

            Console.WriteLine("***Query syntax Full Join***");
            foreach (var item in full)
            {
                Console.WriteLine($"Employee Name : {item.EmployeeName} Department Name :{item.DepartmentName}");
            }
            Console.WriteLine();



            //Cross Join

            var cross = from e in employees
                        from d in departments
                        select new
                        {
                            Employee = e,
                            DepartMent = d
                        };
            Console.WriteLine("***Query syntax Cross Join***");
            foreach (var item in cross)
            {
                Console.WriteLine($"Employee ID : {item.Employee.EmployeeId} Employee Name : {item.Employee.EmployeeName} " +
                    $"Expeince : {item.Employee.Experince} " +
                    $"Department Name :{item.DepartMent.DepartmentName}");
            }
            Console.WriteLine();






            Console.ReadLine();
        }
    }

    public class Employee
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int? DepartmentId { get; set; }
        public int Experince { get; set; }


        public static List<Employee> GetEmployee()
        {
            return new List<Employee>()
            {

             new Employee() { EmployeeId = 1, EmployeeName = "Ajay" , Experince = 2 ,DepartmentId = 2 },
             new Employee() { EmployeeId = 2, EmployeeName = "Vishal" , Experince = 5 ,DepartmentId = null },
             new Employee() { EmployeeId = 3, EmployeeName = "Dashrath" , Experince = 1 ,DepartmentId = 1 },
             new Employee() { EmployeeId = 4, EmployeeName = "yatharth" , Experince = 0 ,DepartmentId = 3 },
             new Employee() { EmployeeId = 5, EmployeeName = "Kunal" , Experince = 3 ,DepartmentId = null },
             new Employee() { EmployeeId =1, EmployeeName = "Vihaan" , Experince = 2 ,DepartmentId = 2 },

            };
        }
    }

    public class Department
    {
        public int DepartmentId { get; set; }
        public string DepartmentName { get; set; }


        public static List<Department> GetDepartment()
        {
            return new List<Department>()
            {
             new Department(){ DepartmentId = 1 , DepartmentName ="Front-End" },
             new Department(){ DepartmentId = 2 , DepartmentName ="Full-Stack" },
             new Department(){ DepartmentId = 3 , DepartmentName ="DataBase" },
             new Department(){ DepartmentId = 4 , DepartmentName ="Back-End" },

            };
        }
    }
}
