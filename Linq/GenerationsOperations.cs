using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class GenerationsOperations
    {
        public static void fn_Empty()
        {
            var result1 = Enumerable.Empty<int>();
            foreach (var item in result1)
            {
                Console.WriteLine(item);
            }

        }
        public static void fn_Range()
        {
            //Enumerable.Range() method iterate upto 10 numbers from 100 to 109  
            IEnumerable<int> obj1 = Enumerable.Range(100, 10);
            //foreach loop used to print the numbers from 100 to 109  
            foreach (var item in obj1)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();

        }
    }
}
