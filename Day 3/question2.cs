using System;

//Q2. Accept a number from user and pass it to static method of a struct calculator it should print all factor of a number.

namespace ConsoleApplication9
{
    struct demo
    {
        public static int[] calculator(int a)
        {
            int[] fact = new int[10];
            for (int i = 0, j = 1; j <= a;j++)
            {
                if (a % j == 0)
                {
                    fact[i]=j;
                    i++;
                }
            }
            return fact;
        }
    }
    class question2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the no tobe calculate factor");
            int a = int.Parse(Console.ReadLine());
            int[] fact= demo.calculator(a);
            Console.WriteLine("Factors are = ");
            for (int i = 0; i < fact.Length; i++)
            {
                Console.Write("{0}  ", fact[i]);
            }
           
        }
    }
}
