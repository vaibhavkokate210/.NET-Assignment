using System;
using ClassLibrary10;

//Q1. Create a static class Mymeth having two static  method
//   	1. public int sqr(int n) :this method return square of a number
//	    2. public double sqr(double s): this method return square of a number
//    Create a entry point class and call this method.

namespace ConsoleApplication33
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Mymeth.sqr(4));
            Console.WriteLine(Mymeth.sqr(5.0));
        }
    }
}
