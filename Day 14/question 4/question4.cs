using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q4. Write a generic delegate which will point to method which will return square , cube ,and factorial of a number

namespace ConsoleApplication41
{
    public delegate T task<T>(T a);

    class question4
    {
        public static int sqr(int a)
        {
            return a * a;
        }
        public static int cube(int a)
        {
            return a*a*a;
        }
        public static int fact(int a)
        {
            int f=1;
            for(int i=1;i<=a;i++)
            {
                f=f*i;
            }
            return f;
        }
    
        static void Main(string[] args)
        {
            task<int> sq = new task<int>(sqr);
            Console.WriteLine("Square = "+ sq(10));
            task<int> cu = new task<int>(cube);
            Console.WriteLine("Cube = " + cu(10));
            task<int> factorial = new task<int>(fact);
            Console.WriteLine("Factorial = " + factorial(5));
        }
    }
}
