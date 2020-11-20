using System;

//Q5. Accept a number from user and display its type and parent class 

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
                 int a=int.Parse(Console.ReadLine());
                 Console.WriteLine("Type of {0} is {1} and parent class is {2}",a,a.GetType(),a.GetType().BaseType);
        }
    }
}
