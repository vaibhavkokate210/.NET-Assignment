using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q4. Accept data in an array pass it to static method let this method store cube of each element , modify original array

namespace ConsoleApplication24
{
    class question4
    {
        static int[] arr = new int[4];
        public static void cube(int[] c)
        {
            for (int i = 0; i < c.Length; i++)
            {
                c[i] = c[i] * c[i] * c[i];
            }
        }
        static void Main(string[] args)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
            }
            cube(arr);
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            } 
        }
    }
}
