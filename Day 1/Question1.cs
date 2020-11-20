using System;

//Q1. Declare 2 variable of a type short and store sum of it in a variable and print it.
namespace Question1
{
    class Program
    {
        static void Main(string[] args)
        {
            short a = 10, b = 10;
            short c = (short)(a + b);
            Console.WriteLine("a + b = {0}",c);
            Console.ReadLine();
        }
    }
}
