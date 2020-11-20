using System;

//Q5. Create a interface Itaxtogov with method void paytax(double amt) create a class myindia, 
//    myeurope let this class implement this interface.In class myindia  paytax method will print tax amount which is 40% of 
//    the data passed in method. 
//    In class myeurope  paytax method will print tax amount which is 30% of the data passed in method.

namespace ConsoleApplication46
{
    class Program
    {
        static void Main(string[] args)
        {
            Itaxtogov i1 = new myIndia();
            i1.paytax(10000);
            Itaxtogov i2 = new myEurop();
            i2.paytax(10000);
        }
    }
}
