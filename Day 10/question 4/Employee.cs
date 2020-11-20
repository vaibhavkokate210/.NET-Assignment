using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication45
{
    class Employee:ICloneable
    {
        public address a = new address();
        public string Name
        {
            get;
            set;
        }
        public int salary
        {
            get;
            set;
        }
        public override string ToString()
        {
            return (" Name = " + Name + " salary = " + salary + " addresss = " + a.Location);
        }
        public object Clone()
        {
            Employee b=(Employee)this.MemberwiseClone();
            address a1 = new address();
            a1.Location = b.a.Location;
            b.a = a1;
            return b;
        }

    }
}
