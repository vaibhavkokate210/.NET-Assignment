using System;

//Q2. Create a class  having two method 
//   	1. 1. public int sqr(int n) :this method return square of a number
//  	2. public double sqr(int s): this method return cube of a number
//    Compile code and observed message given by compiler.

namespace ConsoleApplication34
{
    class question2
    {
        public int sqr(int a)
        {
            return a * a;
        }
        public double sqr(int b)
        {
            return b*b*b;
        }

        static void Main(string[] args)
        {
            question2 q = new question2();
            q.sqr(4);
            q.sqr(5.0);
        }
    }
}
