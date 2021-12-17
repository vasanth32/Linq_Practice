using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class OfType
    {
        public static void fn_ofType(string type)
        {
            ArrayList obj = new ArrayList();
            obj.Add("Australia");
            obj.Add("India");
            obj.Add("UK");
            obj.Add("USA");
            obj.Add(1);
            obj.Add(3);

            if (type == "int")
            {
                //ofType() method will return the value only the specific type  
                IEnumerable<int> result = obj.OfType<int>();
                foreach (var item in result)
                {
                    Console.WriteLine(item);
                }
            }
            if (type=="string")
            {
                //ofType() method will return the value only the specific type  
              IEnumerable<string>  results = obj.OfType<string>();
                foreach (var item in results)
                {
                    Console.WriteLine(item);
                }
            }
           

          

        }
    }
}
