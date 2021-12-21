using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class LINQwithObjects
    {
        public static void fn_LinqToIntArray()
        {
            int[] numarray = { 1, 6, 9, 10, 50, 60, 100, 200, 300 };
            IEnumerable<int> result = from a in numarray
                                      where a > 10 && a < 200
                                      select a;
            foreach (int item in result)
            {
                Console.WriteLine(item);
            }

        }
        public static void fn_LinqToArray()
        {
            string[] array = { "Vaishali", "Shalu", "Akshay", "Akki" };

            IEnumerable<string> res = from a in array
                                      where a.ToLowerInvariant().StartsWith("s")
                                      select a;
            foreach (string item in res)
            {
                Console.WriteLine(item);
            }

        }
        public static void fn_LinqToString()
        {
            string str1 = "Welcome     to   Java T Point.Com";
            //here StringSplitOptions.RemoveEmptyEntries() is used to remove the spaces between the words.  
            var result = from s in str1.ToLowerInvariant().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                         select s;
            foreach (var item in result)
            {
                Console.Write(item);
            }

        }
    }
}
