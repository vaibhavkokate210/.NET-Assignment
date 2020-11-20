using System;
using ClassLibrary9;

namespace ConsoleApplication21
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Vaibhav",20000);
            Console.WriteLine("Name = {0}",e.Name);
            Console.WriteLine("Salary = {0} ",e.Salary);
            Console.WriteLine("Tax = {0}",e.deduct());
            Console.WriteLine("NetSalary = {0}",e.NetSalary);

        }
    }
}
