using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

//Q4. Create a table product having column Id, Name ,Qty, price. 
//    Using like query display all product starting from letter ‘t’. try SQL Injection.
//Q5. Solve above SQL Injection problem with parameterised query.
//Q6. Solve above SQL Injection problem with stored procedure.


namespace ConsoleApplication67
{
    public class demo
    {
        public void display(String str)
        {

            string connectionString = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            using (SqlConnection sc = new SqlConnection(connectionString))
            {
                SqlCommand sl = new SqlCommand("spGetProductsByName",sc);
                sl.CommandType = System.Data.CommandType.StoredProcedure;
                sl.Parameters.AddWithValue("@ProductName",str);
                try
                {
                    sc.Open();
                   SqlDataReader rd = sl.ExecuteReader();
                   while (rd.Read())
                   {
                       Console.WriteLine("{0} {1}  {2}  {3}",rd["Id"],rd["Name"],rd["Price"],rd["Qty"]);
                   }
                }
                catch (Exception e)
                {
                   Console.WriteLine(e.Message);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            demo d = new demo();
            d.display("B");

        }
    }
}
