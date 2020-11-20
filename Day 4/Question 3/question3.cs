using System;
using ClassLibrary3;

//Q3. Create a class customer having member Id, name, billamount. 
//    When you create a object allow to have default vale. Print default value of id,name, billamount.

namespace ConsoleApplication15
{
    class question3
    {
        static void Main(string[] args)
        {
            customer c = new customer(1,"Vaibhav",1000);
            c.display();
        }
    }
}
