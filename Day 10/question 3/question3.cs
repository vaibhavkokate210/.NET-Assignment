using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q3. Create array of anonymous object displaying name and salary. Print all detail

namespace ConsoleApplication43
{
    class question3
    {
        static void Main(string[] args)
        {
            var ob1 = new[] { new {Name="Ajay",salary=40000},new {Name="sujay",salary=300000} };
            Console.WriteLine(ob1.GetType().Name);
            foreach(var v in ob1)
            {
                Console.WriteLine(v.Name+"  "+v.salary);
            }
        }
    }
}
