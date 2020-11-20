using System;

//Q3. Create struct emp having member name and salary, using constructor initialized member. 
//    Write display method which will display name and salary

namespace ConsoleApplication10
{
    struct emp
    {
        public string name;
        public int salary;
        public emp(string n,int s)
        {
            name = n;
            salary = s;
        }
        public void display()
        {
            Console.WriteLine("Name = {0} salary = {1}",name,salary);
        }
    }
    class question3
    {
        static void Main(string[] args)
        {
            emp e = new emp("Vaibhav",40000);
            e.display();
        }
    }
}
