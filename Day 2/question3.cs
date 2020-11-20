using System;

//Q3. Accept two name from user and concat.

namespace ConsoleApplication5
{
    class question3
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter two Strings");
            String s1 = Console.ReadLine();
            String s2 = Console.ReadLine();
            Console.WriteLine("{0} + {1} = {2}",s1,s2,s1+s2);
        }
    }
}
