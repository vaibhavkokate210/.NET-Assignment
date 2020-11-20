using System;

namespace ClassLibrary3
{
    public class customer
    {
        int id;
        String name;
        double billAmount;

        static customer()
        {
            Console.WriteLine("Tasgaon Software Pvt. Ltd,Tasgaon");
        }
        public customer(int i, string n, double b)
        {
            id = i;
            name= n;
            billAmount = b;
        }
        public void display()
        {
            Console.WriteLine("ID = {0} \nName= {1} \nbillAmount= {2}",id,name,billAmount);
        }
    }
}
