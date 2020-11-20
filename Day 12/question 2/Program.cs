using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication53
{
    delegate int myth(int a);
    class Program
    {
        static void Main(string[] args)
        {
            myth sqr = x => x * x;
            myth cube = x => x * x * x;
            myth fact = x =>
            {
                int f = 1;
                for (int i = 1; i <= x; i++)
                {
                    f = f * i;
                }
                return f;
            };
            Console.WriteLine("Square of 10 = {0}",sqr(10));
            Console.WriteLine("Cube of 10 = {0}", cube(10));
            Console.WriteLine("Factorial of 5 = {0}", fact(5));
        }
    }
}
