using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class TakeWhile
    {
        public static void fn_partitions(string val, int skip)
        {
            string[] countries = { "UK", "USA", "Russia", "China", "Australia", "Argentina" };

            IEnumerable<string> result = countries.Take(2);

            //Method syntax
            if (val != "")
                result = countries.TakeWhile(x => x.StartsWith(val));


            if (val != "")
            {    //query syntax
                result = (from n in countries select n).TakeWhile(x => x.StartsWith("U"));
            }

            if (skip != 0)
            {
                result = countries.Skip(skip);
                result = (from n in countries select n).Skip(skip);
            }

            foreach (string s in result)
            {
                Console.WriteLine(s);
            }
        }
    }
}
