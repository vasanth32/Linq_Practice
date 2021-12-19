using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public static class Joins
    {
        public static List<Department> Dept = new List<Department>
                  (){
           new Department{DepId=1,DepName="Software"},
           new Department{DepId=2,DepName="Finance"},
           new Department{DepId=3,DepName="Health"}
           };
        /* create an object of the class 'Employee' and create a 
        list of the Employee with the added record*/
       public static List<Employee> Emp = new List<Employee>
        ()
           {
           new Employee { EmpId=1,Name = "Akshay Tyagi", DeptId=1 },
           new Employee { EmpId=2,Name = "Vaishali Tyagi", DeptId=1 },
           new Employee { EmpId=3,Name = "Arpita Rai", DeptId=2 },
           new Employee { EmpId=4,Name = "Sateesh Alavala", DeptId =2},
           new Employee { EmpId=5,Name = "Madhav Sai"}
        };

        public static void crossJoin()
        {
            var res = from d in Dept
                      from e in Emp
                      select new
                      {
                          EmployeeName = e.Name,
                          DepartmentName = d.DepName
                      };
            foreach (var i in res)
            {
                Console.WriteLine("Name = " + i.EmployeeName + " || Dept Name = " + i.DepartmentName);
            }
        }

        public static void groupJoin()
        {
            var res = from d in Dept
                      join e in Emp
                      on d.DepId equals e.DeptId
                      into empDept
                      select new
                      {
                          DepartmentName = d.DepName,
                          Employees = from emp2 in empDept
                                     orderby emp2.Name
                                     select emp2.Name
                      };
            foreach (var items in res)
            {
                Console.WriteLine();
                Console.WriteLine("Dept Name = " + items.DepartmentName);
                Console.WriteLine();
                foreach (var eName in items.Employees)
                {
                    Console.WriteLine("{0}", eName);
                }
            }

        }
        public static void leftJoin()
        {

            var res = from e in Emp
                      join d in Dept
                      on e.DeptId equals d.DepId into empDept
                      from ed in empDept.DefaultIfEmpty()
                      select new
                      {
                          EmployeeName = e.Name,
                          DepartmentName = (ed == null ? "No Dept" : ed.DepName)
                      };

            foreach(var i in res)
            {
                Console.WriteLine("Name = " + i.EmployeeName + " || Dept Name = " + i.DepartmentName);
            }

        }
        public static void innerJoin()
        {
           

            var res = from d in Dept
                      join e in Emp
                      on d.DepId equals e.DeptId
                      select new
                      {
                          EmployeeName = e.Name,
                          DepartmentName = d.DepName
                      };
            foreach(var i in res)
            {
                Console.WriteLine("Name = "+i.EmployeeName +" || Dept Name = "+ i.DepartmentName);
            }
        }      
    }
    public class Department
    {
        public int DepId { get; set; }
        public string DepName { get; set; }
    }
    public class Employee
    {
        public int EmpId { get; set; }
        public string Name { get; set; }
        public int DeptId { get; set; }
    }
}
