using System;

//3. create class  Employee having member id, name, salary write ToString() method..
//   Create a object of employee class and store it in var ,Object and dynamic variable.
//   Call tostring method to display data.

namespace ConsoleApplication54
{
    class Employee
    {
        int id;
        string name;
        double salary;
        public Employee(int id, string name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public int Id
        {
            get;
            set;
        }
        public string Name
        {
            set;
            get;
        }
        public double Salary
        {
            set;
            get;
        }
        public override string ToString()
        {
            return string.Format("Id = {0}-----Name = {1}----Salary ={2}",Id,Name,Salary);
        } 
        static void Main(string[] args)
        {
            var e = new Employee(01,"Ajay",30000);
            Employee e1 = new Employee(02,"Sujay",40000);
            dynamic e2 = new Employee(03,"Jay",50000);
            Console.WriteLine(e.ToString());
            Console.WriteLine(e1.ToString());
            Console.WriteLine(e2.ToString());
        }
    }
}
