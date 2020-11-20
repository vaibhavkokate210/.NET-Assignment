using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q5. Accept 5 name from user and store it in an array store all name starting from “v” in to another array and print  
//    eg input [vita, vidya, dac, edac,dbda] O/P [vita, vidya]
namespace ConsoleApplication60
{
    class question4
    {
        static void Main(string[] args)
        {
            string[] str = new string[5];
            for (int i = 0; i < str.Length; i++)
            {
                str[i] = Console.ReadLine();
            }
           IEnumerable<string> arr = str.Where(q => q.StartsWith("v"));
           Console.Write("Name starting with v = ");
            foreach(string s in arr)
            {
                Console.Write(s+"   ");
            }
        }
    }
}
