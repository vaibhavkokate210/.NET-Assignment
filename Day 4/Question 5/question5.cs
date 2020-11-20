using System;
using ClassLibrary5;

//Q5. Create a class calculator having  static method square, cube, absolute, floor,ceil who’s job is to 
///    find square, cube, absolute (2.2 ==2)floor(eg. 2.7==O/P==2) , Ceil(eg 2.9==3) value respectively.

namespace ConsoleApplication17
{
    class question5
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Square = {0}", calculator.square(2));
            Console.WriteLine("Cube = {0}",calculator.cube(3));
            Console.WriteLine("Absolute value = {0}",calculator.absolute(2.2));
            Console.WriteLine("Floor value = {0}",calculator.floor(14.7));
            Console.WriteLine("Ceil value = {0}",calculator.ceil(36.7));
        }
    }
}
