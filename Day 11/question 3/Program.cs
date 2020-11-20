using System;

//3. create class  Employee having member id, name, salary. Id should be autoincrement.
//   Write getter setter for name and salary. Write abstract method givebonus.
//   Create two child class Permanente employee and temporary employee. 
//   Create array of employee class store two object of class Permanente employee and temporary employee. 
//   As soon as you call givebonus it should send message stating total salary ,bonus and name. 

namespace ConsoleApplication50
{
    class Program
    {
        static void Main(string[] args)
        {
            message m = new message();

            Employee[] e=new Employee[2];
            e[0] = new permanant("Ajay",40000);
            e[1] = new temporary("Ashish",60000);

            e[0].sh +=new show(m.disply);
            e[1].sh += new show(m.disply);

            e[0].giveBonus(10000);
            e[1].giveBonus(10000);
          //Console.WriteLine(e[0].Salary);
        }
    }
}
