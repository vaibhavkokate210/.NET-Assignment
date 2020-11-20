using System;
using System.IO;

//Q2. Create a class student having member id, name,  marks. Write method public void give_gracemarks(int mks) 
//    when you call method with marks>5 it should throw  user define exception.
//    It should print name id and marks to file, using file handling topic

namespace ConsoleApplication31
{
    class student
    {
        int id;
        string name;
        double marks;
        
        public student(int id,string name,double marks)
        {
            this.id = id;
            this.name = name;
            this.marks = marks;
        }
        public void give_gracemarks(int mks)
        {
            if (mks > 5)
            {
                throw new MyException("Out of Marks"); 
            }
        }
        public override string ToString()
        {
            return (id + name + marks);
        }
        public void saveTofile(student s)
        {
            FileStream fs = null;

            fs = new FileStream("abc.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.Write(s);
            Console.WriteLine("Done");
            sw.Close();
        }
        
        static void Main(string[] args)
        {
            student s = new student(01,"Vaibhav",85);
            s.saveTofile(s);
            try
            {
                s.give_gracemarks(10);
            }
            catch (MyException e)
            {
                Console.WriteLine(e.sms);
            }
        }
    }

    public class MyException : ApplicationException
    {
        public string sms;
        public MyException(string s)
        {
            this.sms = s;
        }
    }
}
