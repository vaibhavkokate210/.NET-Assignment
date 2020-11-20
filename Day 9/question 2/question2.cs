using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q2. Create a class person having virtual method
// public virtual string  dojob(){ “doing job”}
//create three child class programmer,dancer and singer.
//In programmer class override virtual method
//public override string  dojob(){ “doing coding”}
//programmer class also has method public void testing{  “I am testing code also” }
//In  singer class override virtual method
//public override string  dojob(){ “singing”}
//in dancer class no method available.
//Create array of person class and call dojob() method.
//Also call testing method of programmer class in a loop

namespace ConsoleApplication42
{
    class question2
    {
        static void Main(string[] args)
        {
            person[] p = new person[3];
            p[0] = new programmer();
            p[1] = new singer();
            p[2] = new dancer();

            for (int i = 0; i < p.Length; i++)
            {
               Console.WriteLine(p[i].dojob());
               if (p[i] is programmer)
               {
                   programmer p1 = (programmer)p[i];
                   p1.testing();
               }
            }
        }
    }
}
