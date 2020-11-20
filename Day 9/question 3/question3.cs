using System;

//Q3. Accept a number from user and store in object and print it

namespace ConsoleApplication39
{
    class Program
    {
        static void Main(string[] args)
        {
            object o = int.Parse(Console.ReadLine());
            Console.WriteLine(o);
        }
    }
}
