using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    public delegate void show(string nm,int sal,int total);
 

    public abstract class Employee
    {
        public event show sh;
        static int id;
        string name;
        int salary;

        public Employee(string name, int salary)
        {
            id = ++id;
            Name = name;
            Salary = salary;
        }

        public string Name
        {
            get
            {
                return name;
            }
            set
        {
            name = value;
        }
        }
        public int Salary
        {
            set
            {
                salary = value;
            }
            get
            {
                return salary;
            }
        }
         public void demo(string name,int sal,int total)
         {
             if (sh != null)
                 sh(name, sal, total);
        }
        public abstract void giveBonus(int a);
    }
}
