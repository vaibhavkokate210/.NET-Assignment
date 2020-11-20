using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q1. Create a class Student having member rollno, name, maths, sci, eng,total
//    Create 5 object and store in sorted list class and display detail name wise ascending order

namespace ConsoleApplication56
{
    class student
    {
        int rollno;
        string name;
        int maths, sci, eng;
        double total;

        public student(int rollno,string name,int maths,int sci,int eng)
        {
            Rollno = rollno;
            Name = name;
            Maths = maths;
            Sci = sci;
            Eng = eng;
            Total = Maths + Sci + Eng;
        }
        public int Rollno
        {
            set;
            get;
        }
        public string Name
        {
            set;
            get;
        }
        public int Maths
        {
            set;
            get;
        }
        public int Sci
        {
            set;
            get;
        }
        public int Eng
        {
            set;
            get;

        }
        public double Total
        {
            set;
            get;
        }

        static void Main(string[] args)
        {
            SortedList<String,student> s = new SortedList<string,student>();
            student s1 = new student(01,"Sujay",50,60,70);
            student s2 = new student(02, "Jay", 40, 50, 70);
            student s3 = new student(03, "Raj", 90, 60, 70);
            student s4 = new student(04, "Sam", 70, 70, 70);
            student s5 = new student(05, "Ajay", 50, 90, 70);
            s.Add(s1.Name,s1);
            s.Add(s2.Name, s2);
            s.Add(s3.Name, s3);
            s.Add(s4.Name, s4);
            s.Add(s5.Name, s5);
            
            foreach(KeyValuePair<string,student> a in s)
            {
                student ss = a.Value;
                Console.WriteLine("Roll No = {0}   Name = {1}     Total = {2}", ss.Rollno, ss.Name, ss.Total);
                    Console.WriteLine();
            }
        }
    }
}
