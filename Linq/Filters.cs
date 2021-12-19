using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Filters
    {
        public void Fn_Thenby(string filter)
        {
            //create an object Objstudent of the class Student, and create a list of the information of the student  
            List<Students> Objstudent = new List<Students>()
            {
                new Students() { RoleId=1, Name = "Ak", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
                new Students() { RoleId=2, Name = "Shalu", Gender = "Female", Subjects = new List<string> { "Computers", "Botany" } },
                new Students() { RoleId=3, Name = "Shubham", Gender = "Male", Subjects = new List<string> { "Economics", "Operating System", "Java" } },
                new Students() { RoleId=4, Name = "Rohit", Gender = "Male", Subjects = new List<string> { "Accounting", "Social Studies", "Chemistry" } },
                new Students() { RoleId=5, Name = "Shivani", Gender = "FeMale", Subjects = new List<string> { "English", "Charterd" } }
            };
            var studentname = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleId);

            if (filter == "asc")
            {
                //ThenBy() operator is used here to sort the Information of the student in ascending form on the behalf of the RollNumber  
                studentname = Objstudent.OrderBy(x => x.Name).ThenBy(x => x.RoleId);

            }
            else if (filter == "desc")
            {
                studentname = Objstudent.OrderBy(x => x.Name).ThenByDescending(x => x.RoleId);
            }




            //foreach loop is used to print the information  
            foreach (var student in studentname)
            {
                Console.WriteLine("Name={0} studentid={1}", student.Name, student.RoleId);
            }
            Console.ReadLine();
        }
    }
    class Students
    {
        public int RoleId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }

}
