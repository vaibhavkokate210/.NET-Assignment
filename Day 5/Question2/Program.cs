﻿using System;
using ClassLibrary7;

//Q2. Create a class Account having private instance member Id, Name Balanceamt. Id should be generated by application. 
//    Create method deposit who’s job is to increase Balanceamtby the amout deposited by account holder. 
//    Create method withdraw who’s job is to decrease Balanceamt by the amount  withdrawn by account holder. 
//    Write method display which will display name and Balanceamt. Your application should generate only 3 object, 
//    if you try to generate 4 th object it should display message can not create object. This application will be classlibrary.
//    Create console application and use this class library. Create at least two object of account class and deposit and withdraw money.

namespace ConsoleApplication19
{
    class Program
    {
        static void Main(string[] args)
        {
            Account a = new Account("Vaibhav",10000);
            Account b = new Account("ajay",30000);
            Account c = new Account("Sujay",40000);
            a.deposit(1000);
            b.deposit(5000);
            c.deposit(10000);
            a.withdraw(1000);
            b.withdraw(10000);
            c.withdraw(4000);
            a.display();
            b.display();
            c.display();
            Account d = new Account("Jay",20000);
            d.display();
        }
    }
}
