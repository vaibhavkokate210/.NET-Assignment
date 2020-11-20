using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication42
{
    public class programmer:person
    {
        public void testing()
        { 
            Console.WriteLine("I am testing code also");
        }
    
       public override string dojob()
       {
           return "doing coding";
       }
    }
}
