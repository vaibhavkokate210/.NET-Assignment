using System;

//Q4. Write the process how c# file compile in interviwe book
//Q5. create a class demomaths having method Square , cube which will take float value and return square and cube of a number.
namespace ConsoleApplication3
{
    class demomaths
    {
        public float Square(float s)
        {
            return s * s;
        }
        public float cube(float c)
        {
            return c * c * c;
        }
        static void Main(string[] args)
        {
            demomaths d = new demomaths();
            Console.WriteLine("Square = {0}",d.Square(4));
            Console.WriteLine("Cube = {0}",d.cube(3));
            Console.ReadLine();
        }
    }
}
