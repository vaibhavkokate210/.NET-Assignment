using System;

//2. . create  a  class having instance  method to find
//  	a. factorial of a number
//  	b.  square of a number
//      c.  cube of a number.
//    Using delegate  call this method.

namespace ConsoleApplication49
{
    class Program
    {
        delegate int demoMath(int a);
        static void Main(string[] args)
        {
            instanceDelegate d = new instanceDelegate();
            demoMath sqr = d.square;
            Console.WriteLine("Square of 10 = {0}",sqr(10));
            demoMath cub = d.cube;
            Console.WriteLine("Cube of 10 = {0}", cub(10));
            demoMath fact = d.factorial;
            Console.WriteLine("Factorial of 5 = {0}", fact(5));
        }
    }
}
