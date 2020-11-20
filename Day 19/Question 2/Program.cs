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

//Q2. In the above example 
//   a. store employee record in database  using store procedure and strongly type insert.
//   b. Accept id and value for the name to update record.
//  using ExecutenonQuery() method

namespace ConsoleApplication68
{
    class Program
    {
        static void Main(string[] args)
        {
            BussinessLayer b = new BussinessLayer();
      
            //Employee e = b.search(2);
            //Console.WriteLine("{0} {1}  {2}",e.Id,e.Name,e.Salary);
            //string str = "Ajay";
            //List<Employee> l = b.search(str);
            //foreach (Employee ee in l)
            //{
            //    Console.WriteLine("Id = {0}  Name = {1} salary = {2}", ee.Id, ee.Name, ee.Salary);
            //}

            //Employee ad = new Employee { Id = 09, Name = "Vaibhav", Salary = 900000 };
            //b.add(ad);
            b.badal(01,"Rajesh");
        }
    }
}
