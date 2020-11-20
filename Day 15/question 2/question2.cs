using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q2. Accept 5 element in an array having duplicate value print unique array.

namespace ConsoleApplication57
{
    class question2
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            for (int i = 0; i < 5; i++)
            {
                arr[i] =int.Parse(Console.ReadLine());
            }
            SortedSet<int> s = new SortedSet<int>();
            for (int i = 0; i < 5; i++)
            {
                s.Add(arr[i]);
            }

            Console.WriteLine("Unique Elements are = ");
            foreach(int i in s)
            {
                Console.WriteLine(i);
            }

                //for (int i = 0; i < 5; i++)
                //{
                //    Console.WriteLine(arr[i]);
                //}
        }
    }
}
