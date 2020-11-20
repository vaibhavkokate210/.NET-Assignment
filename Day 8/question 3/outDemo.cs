using System;

//Q3. Create  class  outdemo having method 
//     1.public int[] sqrarray(int[] arr, out int sum)
//     Job of this method is to do the sum of all element of an array. 
//     This method should store square of each elements in to new array. Method should return new array.

namespace ConsoleApplication35
{
    class outDemo
    {
        public int[] sqrArry(int[] arr, out int sum)
        {
            int add = 0;
            int[] sqr=new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                add +=arr[i];
                sqr[i] = arr[i] * arr[i];
            }
            sum = add;
            return sqr;
        }
        static void Main(string[] args)
        {
            int[] arr = new int[]{ 1, 2, 4, 5, 6 };
            int[] sqr=new int[arr.Length];
            int s;
            outDemo o = new outDemo();
            sqr=o.sqrArry(arr,out s);
            Console.WriteLine("Sum of Array Element = {0}",s);
            for (int i = 0; i < sqr.Length; i++)
            {
                Console.Write(sqr[i]+ "  ");
            }
        }
    }
}
