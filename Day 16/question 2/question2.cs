using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

//Q2. Write a method which will print 1 to 10. Create 2 thread and let both thread use this method.
//    Use sleep method .

namespace ConsoleApplication62
{
    class question2
    {
        public void print()
        {
            for (int i = 1; i < 11; i++)
            {
                Console.Write(Thread.CurrentThread+"   ");
                Console.WriteLine(i);
                Thread.Sleep(500);
            }
        }
        static void Main(string[] args)
        {
            question2 q = new question2();
            Thread t1 = new Thread(new ThreadStart(q.print));
            Thread t2 = new Thread(q.print);
            t1.Name = "Thread 1";
            t2.Name = "Thread 2";
            t1.Start();
            t2.Start();
        }
    }
}
