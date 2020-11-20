using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

//Q3. Display all employee record using disconnected architecture.

namespace ConsoleApplication69
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection con = null;
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                con = new SqlConnection(connection);
                SqlDataAdapter sda = new SqlDataAdapter("select *from Employee", connection);
                DataSet ds = new DataSet();
                int i = sda.Fill(ds);
                DataTable dt = ds.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "  ");
                    }
                    Console.WriteLine();

                }
            }
            catch(Exception eee)
            {
                Console.WriteLine(eee.Message);
            }
        }
    }
}
