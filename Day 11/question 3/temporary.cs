﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication50
{
    class temporary:Employee
    {
        public temporary(string name, int salary):base(name, salary)
        {

        }
        public override void giveBonus(int a)
        {
            Salary = Salary + a;
            demo(Name, a, Salary);
        }
    }
}
