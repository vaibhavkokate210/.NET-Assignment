using System;

//Q3. Accept 5 element in an array and copy it to another array.

namespace ConsoleApplication28
{
    class question3
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            int[] copy = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = int.Parse(Console.ReadLine());
                copy[i] = arr[i];
            }
            Console.Write("Copied Array is = ");
            for (int i = 0; i < copy.Length; i++)
            {
                Console.Write(copy[i]+" ");
            }
        }
    }
}
