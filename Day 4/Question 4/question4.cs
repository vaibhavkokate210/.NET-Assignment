using System;
using ClassLibrary4;

//Q4. Create a class Printer with a private constructor. Your application should give only one reference of the printer object.

namespace ConsoleApplication16
{
    class question4
    {
        static void Main(string[] args)
        {
            printer p=printer.getPrinter();
            p.display();
        }
    }
}
