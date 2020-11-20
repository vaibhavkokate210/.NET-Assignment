using System;

namespace ClassLibrary2
{
    public class Employee
    {
        int id;
        string name;
        double salary;
        double netSalary;
        const double TDS = 0.1;

        public Employee(string n,double s)
        {
            id = ++id;
            name = n;
            salary = s;
        }
        public void calculate_netSalary()
        {
            if (salary > 10000)
            {
                netSalary = salary - (salary * TDS);
            
            }
            else
            {
                Console.WriteLine("Low salary...So no TDS cut");
            } 
        }
        public void display()
        {
            Console.WriteLine("Name = {0}  NetSalary = {1}",name,netSalary);
        }

    }
}
