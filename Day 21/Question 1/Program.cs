using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Q1. Using entity frame work complete schema first approach and perform insert, delete, update
namespace ConsoleApplication74
{
    class Program
    {
        static void Main(string[] args)
        {
            mydbEntities m = new mydbEntities();
           List<Product> l =  m.Products.ToList<Product>();
            foreach(var r in l)
            {
                Console.WriteLine("{0}  {1}  {2}  {3}",r.Id, r.Name, r.Price, r.Qty);
            }
            //insertData();
           // deleteData();
            updateData();
        }
        public static void insertData()
        {
            mydbEntities m1 = new mydbEntities();
            Product p = new Product();
            p.Id = 09;
            p.Name = "Book";
            p.Price = 400;
            p.Qty = 9;
            m1.Products.Add(p);
            m1.SaveChanges();
        }
        public static void deleteData()
        {
            mydbEntities m2 = new mydbEntities();
            Product p = m2.Products.Find(1);
            try
            {
                m2.Products.Remove(p);
                m2.SaveChanges();
            }
            catch
            {
                Console.WriteLine("No Record find");
            }
        }
        public static void updateData()
        {
            mydbEntities m3 = new mydbEntities();
            Product p = m3.Products.Find(2);
            p.Name = "Headphones";
            m3.SaveChanges();
        }
    }
}
