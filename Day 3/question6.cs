using System;

//Q6. Create a class having instance member salary. Create a object of a class. 
//    Print data type of reference of a class also print parent class name.

namespace ConsoleApplication12
{
    class question6
    {
        public int salary;
        static void Main(string[] args)
        {
            question6 q = new question6();
            Console.WriteLine("Data type of q = {0}",q.GetType());
            Console.WriteLine("Parent class of q = {0}", q.GetType().BaseType);
        }
    }
}
