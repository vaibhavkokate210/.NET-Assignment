using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary6
{
    public class Employee
    {
        string firstname;
        string middlename=" ";
        string lastname;

        static Employee()
        {
            Console.WriteLine("Patil Software System Pvt. ltd,Pune");
        }
        public Employee(string first,string last)
        {
            firstname = first;
            lastname = last;
        }
        public Employee(string first,string middle,string last)
        {
            firstname = first;
            middlename = middle;
            lastname = last;
        }
        public void display()
        {
            Console.WriteLine("{0} {1} {2}",firstname,middlename,lastname);
        }
    }
}
