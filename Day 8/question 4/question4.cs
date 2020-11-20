using System;

//Q4. Create a class swapdemo having method
//  	Public void swap(int x, int y)
//   Job of this method is to swap two number. Create a entry point class  who’s job is to call this method and print swapped data.

namespace ConsoleApplication36
{
    class swapDemo
    {
        public void swap(ref int x,ref int y)
        {
            int temp;
            temp = x;
            x = y;
            y = temp;
        }
        static void Main(string[] args)
        {
            swapDemo s = new swapDemo();
            int a = 10, b = 20;
            Console.WriteLine("Before Swapping");
            Console.WriteLine("a = {0}....b = {1}", a, b);
            s.swap(ref a,ref b);
            Console.WriteLine("After Swapping");
            Console.WriteLine("a = {0}....b = {1}",a,b);
        }
    }
}
