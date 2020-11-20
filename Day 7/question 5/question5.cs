using System;

//Q5. Accept a name from user accept password and confirm password from user if password and confirm password string are same 
//    give message valid data else print invalid data.

namespace ConsoleApplication29
{
    class question5
    {
        static void Main(string[] args)
        {
            string name;
            string password;
            string ConPassword;

            Console.Write("Enter Name = ");
            name = Console.ReadLine();
            Console.Write("Enter Password  = ");
            password = Console.ReadLine();
            Console.Write("Conform Password = ");
            ConPassword = Console.ReadLine();
            if (password.Equals(ConPassword))
            {
                Console.WriteLine("Valid Data");
            }
            else
            {
                Console.WriteLine("InValid Data");
            }
        }
    }
}
