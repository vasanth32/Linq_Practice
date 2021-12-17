using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class ElementOperators
    {
        public static void fn_First()
        {
            int[] ob = { 1, 2, 3, 4, 5 };

            int method = ob.First();

            int qry = (from n in ob select n).First();

            Console.WriteLine("Element from the List: {0}", qry);

        }
        public static void fn_Last()
        {
            int[] ob = { 1, 2, 3, 4, 5 };

            int method = ob.Last();

            int qry = (from n in ob select n).Last();

            Console.WriteLine("Element from the List: {0}", qry);

        }


        public static void fn_Single()
        {
            List<Student> objStudent = new List<Student>()
            {
                new Student() { Name = "Shubham Rastogi", Gender = "Male" },
                new Student() { Name = "Rohini Tyagi", Gender = "Female"},
                new Student() { Name = "Akshay Tyagi", Gender = "Male"},
                new Student() { Name = "Sateesh Rastogi", Gender = "Male"},
                new Student() { Name = "Madhav Sai", Gender = "Male"}
            };

            int[] ob = { 1 };
            var SingleOb = objStudent.Single(n=>n.Name== "Madhav Sai");
            var Where = (from n in objStudent select n).Where(n => n.Name == "Madhav Sai");
            foreach(var s in Where)
            {
                Console.WriteLine(s.Name);
                Console.WriteLine(s.Gender);
                Console.WriteLine();
                Console.WriteLine();
            }
            //Console.WriteLine("Where Element from objStudent: {0}", Where);
            Console.WriteLine("SingleOb Element from objStudent: {0}", SingleOb.Name);
            Console.WriteLine("Element from objList: {0}", ob.Single());

            //SingleOrDefault
            int[] vs = { 1, 2, 3, 4, 5 };

            //objStudent.SingleOrDefault() method will return the information of the student  
            var user = objStudent.SingleOrDefault(i => i.Name == "Akshay Tyagi");
            var result = user.Name;
            int val = vs.SingleOrDefault(j => j > 5);
            Console.WriteLine("SingleOrDefault Element from objStudent: {0}", result);
            Console.WriteLine("SingleOrDefault Element from objList: {0}", val);


        }

        public static void fn_DefaultIfEmpty()
        {
            int[] b = { };
            int[] a = { 1, 2, 3, 4, 5 };

            //It will return all values or if value is empty it will return default value
            var result = a.DefaultIfEmpty();
            var result1 = b.DefaultIfEmpty();

            //it is like fn_LastOrDefault

            Console.WriteLine("----List1 with Values----");
            foreach (var val1 in result)
            {
                Console.WriteLine(val1);
            }

            Console.WriteLine("---List2 without Values---");
            foreach (var val2 in result1)
            {
                Console.WriteLine(val2);
            }

        }
        public static void fn_LastOrDefault()
        {
            int[] LISTOBJ = { 1, 2, 3, 4, 5 };
            int[] ValObj = { };
            int result = (from l in LISTOBJ select l).LastOrDefault();
            int val = (from x in ValObj select x).LastOrDefault();
            Console.WriteLine("Element from the List1: {0}", result);
            Console.WriteLine("Element from the List2: {0}", val);

        }

        public static void fn_ElementAt()
        {
            int[] a = { 1, 2, 3, 4, 5 };
            string[] st = { "1", "2", "3" };

            string sRes = st.ElementAt(2);
            int result = a.ElementAt(1);
            int val = a.ElementAt(3);

            int Dresult = a.ElementAtOrDefault(1);
            int Dval = a.ElementAtOrDefault(3);


            /*WriteLine function will print the value of the specified index*/
            Console.WriteLine("Element At Index 1: {0}", result);
            Console.WriteLine("Element At Index 3: {0}", val);
            Console.WriteLine("String Element At Index 3: {0}", sRes);
            Console.WriteLine("ElementAtOrDefault Element At Index 1: {0}", Dresult);
            Console.WriteLine("ElementAtOrDefault Element At Index 3: {0}", Dval);

        }
        public static void fn_FirstOrDefault()
        {
            int[] ob = { 1, 2, 3, 4, 5 };
            int[] test = { };
            string[] st = { "one", "two", "three" };
            string[] st1 = { };

            int method = ob.FirstOrDefault();
            int method1 = test.FirstOrDefault();
            string method2 = st.FirstOrDefault();
            string method3 = st1.FirstOrDefault();
            
            //this one will throws err if there is no values
            //string method4 = st1.First();

            int qry = (from n in ob select n).First();

            Console.WriteLine("Element from the List: {0}", qry);
            Console.WriteLine("String Element from the List: {0}", method2);
            Console.WriteLine("String 2 Element from the List: {0}", method3);
            //Console.WriteLine("String 2 Element from the List: {0}", method4);
        }


    }
}
