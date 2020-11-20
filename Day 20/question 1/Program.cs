using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

//Q3. Display all employee record using disconnected architecture.
//Q1. Using disconnected architecture perform insert and update delete.

namespace ConsoleApplication69
{
    class Program
    {
        SqlConnection con = null;
        SqlDataAdapter adaptor = null;
        DataSet dataset = null;

        public void display()
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
                con = new SqlConnection(connection);
                adaptor = new SqlDataAdapter("select *from Employee", connection);
                 dataset = new DataSet();
                int i =adaptor.Fill(dataset);
                DataTable dt = dataset.Tables[0];
                foreach (DataRow row in dt.Rows)
                {
                    foreach (DataColumn col in dt.Columns)
                    {
                        Console.Write(row[col] + "  ");
                    }
                    Console.WriteLine();

                }
            }
            catch (Exception eee)
            {
                Console.WriteLine(eee.Message);
            }
        }
        public void insertdata()
        {
            DataRow dr = dataset.Tables[0].NewRow();
            dr["Id"] = 11;
            dr["Name"] = "Rakesh";
            dr["Salary"] = 300000;
            dataset.Tables[0].Rows.Add(dr);
            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptor);
            adaptor.Update(dataset);
        }
        public void dataDelete(int id)
        {
            DataRow dr = dataset.Tables[0].Rows.Find(id);
            dr.Delete();
            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptor);
            adaptor.Update(dataset);
            Console.WriteLine("Record No {0} is deleted",id);
        }
        public void dataUpdate(int i)
        {
            DataRow dr = dataset.Tables[0].Rows.Find(i);
            dr["Name"] = "abhijit";
            SqlCommandBuilder cmd = new SqlCommandBuilder(adaptor);
            adaptor.Update(dataset);
            Console.WriteLine("{0} id name change to Abhijit");
        }
        static void Main(string[] args)
        {
            Program p = new Program();
            p.display();
            //p.insertdata();
           // p.dataDelete(11);
            p.dataUpdate(2);
            p.display();
        }
    }
}
