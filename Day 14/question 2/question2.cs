using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q2. Write a static class with generic method swap, 
//    which should able to swap 2 value of any type and it should also swap two employee object. 

namespace ConsoleApplication40
{
    public class employee
    {
        string s;
        public employee(string s)
        {
            this.s = s;
        }
        public override string ToString()
        {
            return this.s;
        }
    }
    static class question2
    {
        public static void swap<T>(ref T a, ref T b)
        {
            T temp;
            temp = a;
            a = b;
            b = temp;
        }

        static void Main(string[] args)
        {
            int a=10,b=20;
            Console.WriteLine("before swapping");
            Console.WriteLine("a = {0}....b = {1}",a,b);
            swap<int>(ref a, ref b);
            Console.WriteLine("After swapping");
            Console.WriteLine("a = {0}....b = {1}", a, b);
            String a1="Suajay", b1 = "Ajay";
            Console.WriteLine("before swapping");
            Console.WriteLine("a1 = {0}....b1 = {1}", a1, b1);
            swap<String>(ref a1, ref b1);
            Console.WriteLine("After swapping");
            Console.WriteLine("a1 = {0}....b1 = {1}", a1, b1);
            employee e = new employee("e");
            employee e1 = new employee("e1");
            Console.WriteLine("Before swapping");
            Console.WriteLine("e = {0}....e1 = {1}", e, e1);
            swap<employee>(ref e,ref e1);
            Console.WriteLine("After swapping");
            Console.WriteLine("e = {0}....e1 = {1}", e, e1);
        }
    }
}