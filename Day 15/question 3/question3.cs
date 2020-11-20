using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q3. Accept 5 element in an array and store all even number in another array and print. Use lambda 

namespace ConsoleApplication59
{
    class question3
    {
        static void Main(string[] args)
        {
            int[] arr=new int[5];
            for(int i=0;i<arr.Length;i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
           IEnumerable<int> disp = arr.Where(q => q % 2 == 0).Select(q=>q);
           Console.Write("Even Number is = ");
           foreach (var a in disp)
           {
               Console.Write(a+"   ");
           }
        }
    }
}
