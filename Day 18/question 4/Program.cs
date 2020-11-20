using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

//Q4. Create a table product having column Id, Name ,Qty, price.
//    Using like query display all product starting from letter ‘t’. try SQL Injection.

namespace ConsoleApplication66
{
    public class demo
    {
        public void disp(string str)
        {
            string connString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using(SqlConnection con=new SqlConnection(connString))
            {
                SqlCommand cmd = new SqlCommand("select *from Product where Name like '"+str+"%'",con);
                con.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                while (rd.Read())
                {
                    Console.WriteLine("{0} {1} {2}  {3}",rd["Id"],rd["Name"],rd["Qty"],rd["Price"]);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.disp("T");
        }
    }
}
