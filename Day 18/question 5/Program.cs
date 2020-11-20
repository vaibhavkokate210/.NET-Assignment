using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using System.Data.SqlClient;

//Q4. Create a table product having column Id, Name ,Qty, price.
//    Using like query display all product starting from letter ‘t’. try SQL Injection.

//Q5. Solve above SQL Injection problem with parameterised query.

namespace ConsoleApplication66
{
    public class demo
    {
        public void disp(string str)
        {
            string connString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using(SqlConnection con=new SqlConnection(connString))
            {
                //SqlCommand cmd = new SqlCommand("select *from Product where Name like '"+str+"%'",con);
                //con.Open();
                //SqlDataReader rd = cmd.ExecuteReader();

                //while (rd.Read())
                //{
                //    Console.WriteLine("{0} {1} {2}  {3}",rd["Id"],rd["Name"],rd["Qty"],rd["Price"]);
                //}

                SqlCommand sc = new SqlCommand("select *from Product where Name like @startName",con);
                sc.Parameters.AddWithValue("@startName",str+"%");
                con.Open();
                SqlDataReader rd1 = sc.ExecuteReader();
                while (rd1.Read())
                {
                    Console.WriteLine("{0} {1}  {2}  {3}",rd1["Id"],rd1["Name"],rd1["Qty"],rd1["Price"]);
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
