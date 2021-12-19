using System;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class ListAndArray
    {
        public static void Fn_List(string filter)
        {
            //create array countries of type string containing the collection of data  
            string[] countries = { "US", "UK", "India", "Russia", "China", "Australia", "Argentina" };
            //countries.ToList() convert the collection of data into the list.  
            if (filter == "list")
            {
                List<string> result = countries.ToList();
                foreach (string s in result)
                {
                    Console.WriteLine(s);
                }
            }
            if (filter == "array")
            {
                //method linq    
                string[] method = (from n in countries select n).ToArray();
                foreach (string s in method)
                {
                    Console.WriteLine(s);
                }
            }

        }




    }
}
