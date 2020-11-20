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

//Q2. In the above example 
//    a. store employee record in database 
//    b. Update and delete one record 
//    using ExecutenonQuery() method

//Q3. Use aggregate function ie. Print max salary and count number of employee in database

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
                    SqlCommand cmd = new SqlCommand();
                    //cmd.CommandText = "insert into Employee values(08,'Pravin',20000)";
                    //cmd.Connection = con;
                    con.Open();
                    //int i=cmd.ExecuteNonQuery();
                    //Console.WriteLine("{0} Records inserted",i);
                    //cmd.CommandText = "update Employee set Salary=100000 where Name='Bhai'";
                    //int j = cmd.ExecuteNonQuery();
                    //Console.WriteLine("{0} row updated",j);
                    //cmd.CommandText = "delete from Employee where Id=06";
                    //j = cmd.ExecuteNonQuery();
                    //Console.WriteLine("{0} rowa deleted",j);
                    cmd.CommandText = "Select count(Id) from Employee";
                    cmd.Connection = con;
                    int c=(int)cmd.ExecuteScalar();
                    Console.WriteLine("No of Employee = {0}", c);

                    cmd.CommandText = "select Max(Salary) from Employee";
                    int d=(int)cmd.ExecuteScalar();
                    Console.WriteLine("Maximum Salary = {0}",d);
                    
                    cmd.CommandText = "Select *from Employee";
                    cmd.Connection = con;
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
