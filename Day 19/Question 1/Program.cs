using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1. Create a table Employee having column  Id, Name, Salary. Create a class Employee having member Id, 
//     Name, Salary. Create a class BusinessLayer  and write two method 
//     Public Employee search(int id)
//    Public List<Employee>(string name)
//    Above method will search the record and return results. Entry point class will display data.

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessLayer b = new BussinessLayer();
      
            Employee e = b.search(2);
            Console.WriteLine("{0} {1}  {2}",e.Id,e.Name,e.Salary);
            string str = "Ajay";
            List<Employee> l = b.search(str);
            foreach (Employee ee in l)
            {
                Console.WriteLine("Id = {0}  Name = {1} salary = {2}", ee.Id, ee.Name, ee.Salary);
            }
        }
    }
}
