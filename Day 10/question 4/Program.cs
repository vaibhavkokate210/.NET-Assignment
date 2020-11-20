using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q4. Create a class employee having member name and salary,it has reference of address class which display location name[eg. vile-parle] 
//    Create a duplicate object using clone method.

namespace ConsoleApplication45
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee e = new Employee();
            e.Name = "Ajay";
            e.salary = 20000;
            Employee e1= (Employee)e.Clone();
            e1.a.Location = "Tasgaon";
            Console.WriteLine(e);
            Console.WriteLine(e1);
        }
    }
}
