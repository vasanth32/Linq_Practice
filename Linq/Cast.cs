using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Linq
{
    public class Cast
    {
        public static void fn_cast()
        {
            ArrayList obj = new ArrayList();
            obj.Add("USA");
            obj.Add("Australia");
            obj.Add("UK");
            obj.Add("India");

            IEnumerable<string> result = obj.Cast<string>();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }


    }
}
