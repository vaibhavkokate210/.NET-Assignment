using System;

//1. create  a  static class having static method to find
//  	a. factorial of a number
//  	b.  square of a number
//      c.  cube of a number.
//      Using delegate  call this method.

namespace ConsoleApplication48
{
    delegate int DemoMath(int a);
    class Program
    {
        static void Main(string[] args)
        {
            DemoMath sqr = staticDelegate.square;
            Console.WriteLine("Square of 10 = {0}",sqr(10));

            DemoMath cub = staticDelegate.cube;
            Console.WriteLine("Cube of 10 = {0}",cub(10));

            DemoMath factorial = staticDelegate.fact;
            Console.WriteLine("Factroial of 5 = {0}",factorial(5));
        }
    }
}
