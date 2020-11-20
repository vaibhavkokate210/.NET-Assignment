using System;

//Q6. Create a class mymath having method sum who’s job is to find average. 
//    This method should work even if it’s called with different number of arguments eg. sum(4,5) ,sum(4,7,8,9)

namespace ConsoleApplication38
{
    class myMath
    {
        public static double sum(params double[] arr)
        {
            double add=0;
            for (int i = 0; i < arr.Length; i++)
            {
                add += arr[i]; 
            }
            return (add / arr.Length);
        }
        static void Main(string[] args)
        {
          Console.WriteLine(myMath.sum(10, 20));
          Console.WriteLine(myMath.sum(15,10,10));
        }
    }
}
