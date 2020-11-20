using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary4
{
    public class printer
    {
        public static printer Printer = null;

        static printer()
        {
            Console.WriteLine("ABC Software pvt. ltd, Mumbai");
        }
        private printer()
        {
            Console.WriteLine("In printer Private constructor");
        }

        public static printer getPrinter()
        {
            if (Printer==null)
            {
                Printer = new printer();
            }
            return Printer;
        }
        public void display()
        {
            Console.WriteLine("display is called");
        }
    }
}
