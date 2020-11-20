using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Q2. Accept data in 3*3matrix and print row wise sum

namespace ConsoleApplication22
{
    class question2
    {
        static void Main(string[] args)
        {
            int[,] m=new int[3,3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    m[i, j] =int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                int sum = 0;
                for (int j = 0; j < 3; j++)
                {
                   sum = sum + m[i, j];
                }
                Console.WriteLine("Sum of Row {0} = {1}",i,sum);
            }
        }
    }
}
