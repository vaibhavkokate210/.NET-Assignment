using System;

//5. create a two partial Account class.In one class write only methods and another class write constructor and getter setter. 
//   Use this in your existing account application.
namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            account a = new account(01,"Ajay");
            a.display();
        }
    }
}
