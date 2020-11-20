using System;
using System.Data.SqlClient;

//Q1. Create table Emp having column Id, Name, Salary.using ADO.Net display all detail of the table.
//    Do not forget to add record in table.

// Q2. Solve above program using setter method connection string in SqlConnection class.

namespace ConsoleApplication63
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString =@"Data Source=(localdb)\Projects;Initial Catalog=mydb;Integrated Security=True";
                SqlCommand sq = new SqlCommand("select *from Emp", con);
                con.Open();
                SqlDataReader sd = sq.ExecuteReader();
                if(sd.HasRows)
                {
                    while (sd.Read())
                    {
                        Console.WriteLine("{0}  {1}  {2}",sd["Id"],sd["Name"],sd["salary"]);
                    }
                 }
             }
        }
    }
}
