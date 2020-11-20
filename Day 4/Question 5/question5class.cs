using System;


namespace ClassLibrary5
{
    public class calculator
    {
        public static int square(int a)
        {
            return a * a;
        }
        public static int cube(int a)
        {
            return a * a * a;
        }
        public static int absolute(double d)
        {
            int a = (int)(d / 1);
            return a;
        }
        public static int floor(double d)
        {
            int a = (int)(d / 1);
            return a;
        }
        public static int ceil(double d)
        {
            int a=(int)(d/1);
            return a + 1;
        }
    }
}
