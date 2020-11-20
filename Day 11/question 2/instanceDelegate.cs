using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication49
{
    class instanceDelegate
    {
        public int square(int a)
        {
            return a * a;
        }
        public int cube(int a)
        {
            return a*a*a;
        }
        public int factorial(int a)
        {
            int fact = 1;
            for (int i = 1; i <= a; i++)
            {
                fact = fact * i;
            }
            return fact;
        }

    }
}
