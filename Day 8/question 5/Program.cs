using System;
using ClassLibrary11;

//Q5. Create class Animal having virtual method speak returning string” I don’t know how to speak”.
//    Create a child class dog having overridden speak method returning string “Bhow BHow”.
//    Create a child class cat having overridden speak method returning string “mewo mewo”
//    Create a child class donkey does not have any method.
//    Create class showpoly having method call who’s job is to call speak method using reference of Animal. 
//    Create object of all child class and then call showpoly’s class call method and pass child class object.

namespace ConsoleApplication37
{
    class showpoly
    {
        public static void call(Animal a)
        {
            string s = "";
            s=a.speak();
            Console.WriteLine(s);
        }
        static void Main(string[] args)
        {
            showpoly.call(new Dog());
            showpoly.call(new Cat());
            showpoly.call(new Donkey());
        }
    }
}
