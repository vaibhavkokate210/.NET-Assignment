using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q2. Using model first approach generate database,  and classes .
//    [complete emp dept task] perform insert, delete, update

namespace ConsoleApplication75
{
    class Program
    {
        static void Main(string[] args)
        {
            Model_EmpContainer m1 = new Model_EmpContainer();
           List<EmpDemo> e = m1.EmpDemoes.ToList<EmpDemo>();
           foreach (EmpDemo ee in e)
           {
               Console.WriteLine("{0}  {1}  {2}  {3}",ee.Id,ee.Name,ee.Salary,ee.DeptDemoId);
           }
           // insertData();
           //updateData();
           deleteData();
        }
        public static void insertData()
        {
            Model_EmpContainer m = new Model_EmpContainer();
            EmpDemo e = new EmpDemo();
            e.Id = 01;
            e.Name = "Ajay";
            e.Salary = 30000;
            e.DeptDemoId = 01;
            m.EmpDemoes.Add(e);
            m.SaveChanges();
        }
        public static void updateData()
        {
            Model_EmpContainer m = new Model_EmpContainer();
            EmpDemo e =  m.EmpDemoes.Find(4);
            e.Name = "Paresh";
            m.SaveChanges();
        }
        public static void deleteData()
        {
            Model_EmpContainer m = new Model_EmpContainer();
            EmpDemo e = m.EmpDemoes.Find(3);
            m.EmpDemoes.Remove(e);
            m.SaveChanges();
        }
    }
}
