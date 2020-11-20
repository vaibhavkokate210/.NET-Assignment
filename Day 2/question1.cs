using System;

//Q1. Accept two number from user and print sum of it.

namespace ConsoleApplication4
{
    class question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the two numbers");
           int a = int.Parse(Console.ReadLine());
           int b = int.Parse(Console.ReadLine());
           Console.WriteLine("{0} + {1} = {2}",a,b,a+b);
           Console.ReadLine();
        }
    }
}
