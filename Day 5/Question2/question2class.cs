using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary7
{
    public class Account
    {
        static int id;
        String name;
        double balance;

        public Account(string n,double b)
        {
            if (id <= 2)
            {
                id = ++id;
                name = n;
                balance = b;
            }
            else
            {
                Console.WriteLine("Can not create object");
                throw new Exception("can't create object");
            }
        }
        public void deposit(double amount)
        {
            balance = balance + amount;
        }
        public void withdraw(double amount)
        {
            if (balance > 1000)
                balance = balance - amount;
            else
                Console.WriteLine("Insufficient balance");
        }
        public void display()
        {
            Console.WriteLine("id = {0} Name = {1}....Balance = {2}",id,name,balance);
        }
    }
}
