﻿using System;
using ClassLibrary8;

//Q3. Create a class Employee having private instance member Id, Name Salary, netsalary.
//    Id should be generated by application Create method calculate_netsalary who’s job is to deduct 10% of TDS. 
//    Declare TDS as static variable. Write method display which will display name and netsalary. This application will be classlibrary.
//    Declare const int maxemp=3 ie. You can have only 3 employee.
//    Also declare const int maxsal=50000. Use this for validation in constructor if you try to create object with salary 80000,
//    it should display error
//    Create console application and use this class library. Create at least two object of Employee class 

namespace ConsoleApplication20
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Vaibhav",20000);
            e.calculate_netSalary();
            e.display();
            Employee e1 = new Employee("Ajay",30000);
            e1.calculate_netSalary();
            e1.display();
            Employee e2 = new Employee("Raj",90000);
            e2.calculate_netSalary();
            e2.display();
        }
    }
}
