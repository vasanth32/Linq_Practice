using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linq
{
    public class Experssion
    {
        public static void fn_experssion()
        {
            Expression<Func<Student, bool>> isTeenAgerExpr = s => s.Age > 12 && s.Age < 20;

            //compile Expression using Compile method to invoke it as Delegate
            Func<Student, bool> isTeenAger = isTeenAgerExpr.Compile();

            //Invoke
            bool result = isTeenAger(new Student() { Name = "Steve", Age = 20 });
            Console.WriteLine(result);

        }
    }
}
