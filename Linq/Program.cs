using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Student> Objstudent = new List<Student>(){
        new Student() { Name = "Suresh Dasari", Gender = "Male", Subjects = new List<string> { "Mathematics", "Physics" } },
        new Student() { Name = "Rohini Alavala", Gender = "Female", Subjects = new List<string> { "Entomology", "Botany" } },
        new Student() { Name = "Praveen Kumar", Gender = "Male", Subjects = new List<string> { "Computers", "Operating System", "Java" } },
        new Student() { Name = "Sateesh Chandra", Gender = "Male", Subjects = new List<string> { "English", "Social Studies", "Chemistry" } },
        new Student() { Name = "Madhav Sai", Gender = "Male", Subjects = new List<string> { "Accounting", "Charted" } }
        };

            var tmp = Objstudent.OrderBy(x => x.Name);
            var tmpDes = Objstudent.OrderByDescending(x => x.Name);
            var tmps = from ob in Objstudent orderby ob.Name select ob;

            //uncommmand for orderby
            //foreach (var stu in tmp)
            //    Console.WriteLine(stu.Name);

            //uncommmand for thenby
            //Filters fn = new Filters();
            //fn.Fn_Thenby("desc");

            //uncommmand for patitions
            //Partition.fn_partitions("");

            //uncommmand for StartsWith
            //TakeWhile.fn_partitions("U",0);

            //uncommmand for skip
            //TakeWhile.fn_partitions("", 5);


            //uncommmand for List
            //ListAndArray.Fn_List("list");

            //uncommmand for Array
            //Conversions.Fn_List("array");

            //uncommmand for lookup
            //ToLookup.fn_lookup();

            //uncommmand for ofType - int
            //OfType.fn_ofType("int");

            //uncommmand for ofType - string
            //OfType.fn_ofType("string");

            //uncommmand for fn_AsEnumerable
            //ChangeTo.fn_AsEnumerable();

            //uncommmand for fn_Dictionary
            //ChangeTo.fn_Dictionary();

            //uncommmand for First
            //ElementOperators.First();

            //uncommmand for First
            //ElementOperators.fn_FirstOrDefault();

            //uncommmand for First
            //ElementOperators.fn_Last();

            //uncommmand for First
            //ElementOperators.fn_LastOrDefault();

            //uncommmand for First
            //ElementOperators.fn_ElementAt();

            //uncommmand for First
            //ElementOperators.fn_Single();

            //uncommmand for First
            ElementOperators.fn_DefaultIfEmpty();

            Console.ReadLine(); }
    }
    class Student
    {
        public string Name { get; set; }
        public string Gender { get; set; }
        public List<string> Subjects { get; set; }
    }

}
