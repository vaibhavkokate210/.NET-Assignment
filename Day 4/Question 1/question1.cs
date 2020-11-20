using System;
using ClassLibrary1;

namespace ConsoleApplication13
{
    class question1
    {
        static void Main(string[] args)
        {
            account a = new account(1,"Vaibhav",2000);
            account a1 = new account(2, "ajay", 3000);
            a.deposit(100);
            a.withdraw(200);
            a.display();
            a1.deposit(1000);
            a1.withdraw(2000);
            a1.display();
        }
    }
}
//Q1. Create a class Account having private instance member Id, Name Balanceamt. 
//    Create method deposit who’s job is to increase Balanceamtby the amout deposited buy account holder. 
//    Create method withdraw who’s job is to decrease Balanceamtby the amout  withdrwan buy account holder. 
//    Write method display which will display name and Balanceamt. This application will be classlibrary.
//    Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.
