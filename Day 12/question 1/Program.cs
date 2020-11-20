using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication51
{
     delegate void cal(int a);

    class Program
    {
        static void Main(string[] args)
        {

         cal square = delegate(int a)
        {
            Console.WriteLine("Square of {0} = {1}", a, a * a);
        };
  cal cube=delegate(int a)
        {
            Console.WriteLine("cube of {0} = {1}", a, a * a * a);
        };
 cal factorial=delegate(int a)
        {
            int f = 1;
            for (int j = 1; j <= a; j++)
            {
                f = f * j;
            }
            Console.WriteLine("Square of {0} = {1}", a,f);
        };

 square(10);
 cube(10);
 factorial(5);
        }
    }
}
