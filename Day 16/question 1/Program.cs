using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1. Create class  employee having member id, name, salary, address [put address as Vile parle, Andheri, Kandivali].
//    a. Display all employee detail
//    b. Display all employee who are staying at Andheri
//    c. Display total of all salary
//    d. Display  all employee who’s name start with “v”
//    e. Count number of Employee in a company
//    f. Display all employee getting salary > 50000
//    g. Display min , max and average salary
//    h. Display all name in ascending order.
///   i. display all record salary in descending order salary wise
//    h. display Id and name who’s salary is <20000

namespace ConsoleApplication58
{
    class Employee
    {
        int id;
        string name;
        double salary;
        string address;
        public int Id { set; get; }
        public string Name { set; get; }
        public double Salary { set; get; }
        public string Address { set; get; }

        public override string ToString()
        {
            return string.Format("ID = {0}  Name = {1}  Salary = {2}  Addres = {3}",Id,Name,Salary,Address);
        }

        static void Main(string[] args)
        {
            Employee[] emp = new[] { new Employee{Id=01,Name="Ajay",Salary=30000,Address="Vile Parle"},
                                     new Employee{Id=02,Name="Vikas",Salary=15000,Address="Vile Parle"},
                                     new Employee{Id=03,Name="Raj",Salary=36000,Address="Andheri"},
                                     new Employee{Id=04,Name="Suresh",Salary=10000,Address="Andheri"},
                                     new Employee{Id=05,Name="Sakharam",Salary=50000,Address="Kandiwali"}};
           IEnumerable<Employee> q1= from s in emp select s;
           foreach (var d in q1)
           {
               Console.WriteLine(d);
           }
           Console.WriteLine("=========================================================================================================");
           var q2 = from s1 in emp where s1.Address == "Andheri" select s1.Name;
           foreach (var d1 in q2)
           {
               Console.WriteLine(d1);
           }
           Console.WriteLine("=========================================================================================================");
           var q3 = (from s2 in emp select s2.Salary).Sum();
           Console.WriteLine(q3);
           Console.WriteLine("=========================================================================================================");
           var q4 = from s3 in emp where s3.Name.StartsWith("V") select s3;
           foreach (var d2 in q4)
           {
               Console.WriteLine(d2);
           }
           Console.WriteLine("=========================================================================================================");
           var q5 = (from s4 in emp select s4).Count();
           Console.WriteLine("No of Emplyee = {0}",q5);
           Console.WriteLine("=========================================================================================================");
           var q6 = from s5 in emp where s5.Salary > 20000 select s5;
           foreach (var d3 in q6)
           {
               Console.WriteLine(d3);
           }
           Console.WriteLine("=========================================================================================================");
           var q7 = (from s6 in emp select s6.Salary).Min();
           Console.WriteLine("Minimum salary is = {0}",q7);
           Console.WriteLine("=========================================================================================================");
           var q8 = (from s7 in emp select s7.Salary).Max();
           Console.WriteLine("Maximum salary is = {0}", q8);
           Console.WriteLine("=========================================================================================================");
           var q9 = (from s8 in emp select s8.Salary).Average();
           Console.WriteLine("Average salary is = {0}", q9);
           Console.WriteLine("=========================================================================================================");
           var q10 = from s9 in emp orderby s9.Name select s9;
           foreach (var d3 in q10)
           {
               Console.WriteLine(d3.Name);
           }
           Console.WriteLine("=========================================================================================================");
           var q11 = from s10 in emp orderby s10.Salary descending select s10;
           foreach (var d4 in q11)
           {
               Console.WriteLine(d4.Salary);
           }
           Console.WriteLine("=========================================================================================================");
           var q12 = from s11 in emp where s11.Salary < 20000 select s11;
           foreach (var d5 in q12)
           {
               Console.WriteLine("Id = {0}  Name = {1}",d5.Id,d5.Name);
           }
        }
    }
}
