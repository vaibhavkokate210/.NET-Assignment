using System;
using ClassLibrary2;
//Q2. Create a class Employee having private instance member Id, Name Salary, netsalary. 
//    Create method calculate_netsalary who’s job is to deduct 10% of TDS.. Write method display which will display name and netsalary. 
//    This application will be classlibrary.
//    Create console application and use this class library. Create at least two object of Employee class 

namespace ConsoleApplication14
{
    class question2
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Vaibhav",20000);
            Employee e1 = new Employee("Ajay", 40000);
            e.calculate_netSalary();
            e.display();
            e1.calculate_netSalary();
            e1.display();
        }
    }
}
