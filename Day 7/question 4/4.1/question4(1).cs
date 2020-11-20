using System;

//Q3. Accept a string from user and convert it to lowercase and check reference of both string.

namespace ConsoleApplication30
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the String = ");
            string user = Console.ReadLine();
            string convert = user.ToLower();
            Console.WriteLine(convert);
            if (user == user.ToLower())
            {
                Console.WriteLine("Equal..");
            }
            else
                Console.WriteLine("Not Equal..");
        }
    }
}
