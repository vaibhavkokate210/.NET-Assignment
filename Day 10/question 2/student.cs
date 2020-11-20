using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication47
{
    public class student
    {
        static int rollNo;
        public student(string name, int marks)
        {
            rollNo = ++rollNo;
            this.Name = name;
            this.Marks = marks;
        }
        public string Name
        {
            get;
            set;
        }
        public int Marks
        {
            get;
            set;
        }
        public override string ToString()
        {
            return ("Name = "+this.Name+" Marks = "+this.Marks);
        }
    }
}
