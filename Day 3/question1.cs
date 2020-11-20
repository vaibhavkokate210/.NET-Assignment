using System;

//Q1. Create a struct Math having two static method square and cube. 
//    Using struct variable call this method and print square and cube of a number

namespace ConsoleApplication7
{
    struct Math
    {
        public static int square(int a)
        {
            return a*a;
        }
        public static int cube(int b)
        {
            return b * b*b;
        }
    }
    class question1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square = {0}", Math.square(10));
            Console.WriteLine("Cube = {0}", Math.cube(10)); 
        }
    }
}

