using System;


namespace ConsoleApplication48
{
   static class staticDelegate
    {
       public static int square(int a)
       {
           return a * a;
       }
       public static int cube(int a)
       {
           return a * a * a;
       }
       public static int fact(int a)
       {
           int f = 1;
           for (int i = 1; i <= a; i++)
           {
               f = f * i;
           }
           return f;
       }
    }
}
