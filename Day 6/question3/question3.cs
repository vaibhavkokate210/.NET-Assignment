using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q3. Accept data in an array and print sum .
//  also store square of each element in new array.

namespace ConsoleApplication23
{
    class question3
    {
        static void Main(string[] args)
        {
            int x = 0;
            Console.WriteLine("Enter length of array",x);
            x = int.Parse(Console.ReadLine());
            int[] arr = new int[x];
            int[] sq = new int[x];
            Console.WriteLine("Enter the Elements");
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i]=int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                sq[i] = arr[i] * arr[i];
                Console.Write(sq[i]+" ");
            }
        }
    }
}
