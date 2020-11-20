using System;

//Q5. Accept data in an array and print average.

namespace ConsoleApplication25
{
    class question5
    {
        static void Main(string[] args)
        {
            double sum = 0;
            double[] arr = new double[4];
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = double.Parse(Console.ReadLine());
                sum = sum + arr[i];
            }
            Console.WriteLine("Average = {0}",(sum/arr.Length));
        }
    }
}
