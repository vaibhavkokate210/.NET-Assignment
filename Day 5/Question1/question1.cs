using System;
using ClassLibrary6;

//Q1. Create a class Employee having member variable Firstname, Lastname, Middlename.
//    let your application create object even if user does not enter Middlename. 
//    Create two constructor one take parameter for Firstname, Lastname and second constructor which will take all the parameter. 
//     Write display method which will display detail of the object.

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee("Vaibhav","Mahadev","Kokate");
            Employee e1 = new Employee("Ajay","Bhosale");
            e.display();
            e1.display();
        }
    }
}
