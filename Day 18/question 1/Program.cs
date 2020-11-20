using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

//Q1.Create a table Employee having column  Id, Name, Salary. Create a class Employee having member Id, Name, Salary. 
//   Create a class BusinessLayer with a getter method who’s job is to return list of the employee retrieved 
//   from database and map to the class Employee.

namespace ConsoleApplication65
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Salary { get; set; }
    }
    public class BusinessLayer
    {
        public List<Employee> deunTak
        {
            get
            {
                List<Employee> e = new List<Employee>();
                string connString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                using(SqlConnection con=new SqlConnection(connString))
                {
                    SqlCommand cmd = new SqlCommand("select *from Employee", con);
                    con.Open();
                    SqlDataReader rd = cmd.ExecuteReader();
                    while(rd.Read())
                    {
                        Employee em = new Employee();
                        em.Id=Convert.ToInt32(rd["Id"]);
                        em.Name = rd["Name"].ToString();
                        em.Salary = Convert.ToDouble(rd["Salary"]);

                        e.Add(em);
                    }
                }
                return e;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            BusinessLayer b = new BusinessLayer();
            foreach(Employee e in b.deunTak)
            {
                Console.WriteLine("{0} {1} {2}",e.Id,e.Name,e.Salary);
            }
        }
    }
}
