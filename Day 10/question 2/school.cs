﻿using System;

//Q2. Create a class school, having array of student object. 
//    Create a class student having member variable rollnumber, name, marks . rollnumber should be generated by application. 
//    When you load application display school name. Display all student name and marks.

namespace ConsoleApplication47
{
    class school
    {
        static school()
        {
            Console.WriteLine("TKIET, Warananagar");
        }
        static void Main(string[] args)
        {
            student[] s = new student[3];
            s[0] = new student("Ajay",85);
            s[1] = new student("Suajy", 80);
            s[2] = new student("Jay", 75);

            foreach(student st in s)
            {
                Console.WriteLine(st);
            }

        }
    }
}