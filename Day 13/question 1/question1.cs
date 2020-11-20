using System;

namespace ConsoleApplication32
{
    abstract class Account
    {
        static int id;
        int Accid;
        string name;
        double balance;
        protected const double minbal = 10000;

        public Account(String name, double balance)
        {
            Accid = ++id;
            if (name == " ")
                throw new ValidName("Please Enter Valid Name");
            else
            Name = name;
            Balance = balance;
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        public void deposit(double a)
        {
            Balance = Balance + a;
        }
        public void display()
        {
            Console.WriteLine("Name = {0}..Balance = {1}",name,balance);
        }
        public abstract void withdraw(double e);

    }

    class Current : Account
    {
        public Current(String name, Double bal)
            : base(name, bal)
        {
        }
        public override void withdraw(double a)
        {
            if (Balance < a)
            {
                throw new LowBalance("InSufficient Balance....");
            }
            else
            Balance = Balance - a;
        }
    }

    class Saving : Account
    {
        public Saving(String name, Double bal)
            : base(name, bal)
        {
        }

        public override void withdraw(double a)
        {
            if (Balance < a)
            {
                throw new LowBalance("InSufficient Balance...."); 
            }
            else
            Balance = Balance - a;
        }
    }

    public class LowBalance : ApplicationException
    {
        public string s;
        public LowBalance(string s)
        {
            this.s = s;
        }
    }
    public class ValidName : ApplicationException
    {
        public string s1;
        public ValidName(String s1)
        {
            this.s1 = s1;
        }
    }
    class question1
    {
        static void Main(string[] args)
        {
          
                Account a = new Saving("Ajay", 35000);               
                Account a1 = new Current("Sujay", 40000);
                try
                {
                    a.withdraw(40000);
                }
                catch (LowBalance l)
                {
                    Console.WriteLine(l.s);
                }
                a1.withdraw(10000);
                a.deposit(10000);
                a1.deposit(10000);
                a.display();
                a1.display();

        }
    }
}
