using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary9
{
    public class Employee
    {
        static int getid;
        int id;
        string name;
        double salary;
        double netSalary;
        static double TDS = 0.1;
        const double maxSalary = 50000;
        static Employee()
        {
            Console.WriteLine("ABC Software pvt ltd,Sangli");
        }

        public Employee(string n,double s)
        {
            if (getid < 3)
            {
                if (s < maxSalary)
                {
                    id = ++getid;
                    Name = n;
                    Salary = s;
                }
                else
                {
                    throw new Exception("Salary should less than 500000");
                }

            }
            else
            {
                throw new Exception("4th Employee Not allowed");
            }
        }
        public int Id
        {
            get
            {
                return id;
            }
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
        public double Salary
        {
            get
            {
                return salary;
            }
            set
            {
                if (value < 0)
                {
                    throw new Exception("Salary Should not be 0 or Negative");
                }
                else
                {
                    salary = value;
                }
            }
        }
        public double NetSalary
        {
            get
            {
                return netSalary;
            }
            set
            {
                netSalary = value;
            }
        }
        
        public double deduct()
        {
            double tax = 0;
            tax = Salary * TDS;
            NetSalary = Salary - tax;
            return tax;
        }

    }
}
