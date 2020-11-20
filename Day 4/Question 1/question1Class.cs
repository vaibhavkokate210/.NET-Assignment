using System;

namespace ClassLibrary1
{
    public class account
    {
        private int id;
        private string name;
        private float balance;

        public account(int i,string n,float b)
        {
            id = i;
            name = n;
            balance = b;
        }
        public void deposit(int amount)
        {
            balance += amount;
        }
        public void withdraw(int amount)
        {
            if (balance > 1000)
                balance -= amount;
            else
                Console.WriteLine("Insufficient Balance....Please deposit");
        }
        public void display()
        {
            Console.WriteLine("Name -- {0}\nBalance -- {1}",name,balance);
        }
    }
}
