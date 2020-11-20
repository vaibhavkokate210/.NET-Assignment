using System;

//Q5. Accept a number from user and print square of it, if in put is not valid give appropriate message

namespace ConsoleApplication6
{
    class question5
    {
        static void Main(string[] args)
        {
            int a = 0;
            bool f = int.TryParse(Console.ReadLine(),out a);
            if (f == true && a!=0)
            {
                Console.WriteLine("Square of {0} = {1}", a, a * a);
            }
            else
            {
                Console.WriteLine("Please enter valid number");
            }
        }
    }
}
