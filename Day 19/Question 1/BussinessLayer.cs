using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;

namespace ConsoleApplication68
{
    class BussinessLayer
    {
        public SqlConnection getconnection()
        {
            SqlConnection conn = new SqlConnection();
            string str = ConfigurationManager.ConnectionStrings["DatabaseConnectionString"].ConnectionString;
            conn.ConnectionString = str;
            return conn;
        }
        public Employee search(int id)
        {
            Employee e = null;
            SqlConnection con = null;
            try
            {
                con = getconnection();
                SqlCommand cmd = new SqlCommand("select *from Employee where Id=@id", con);
                cmd.Parameters.AddWithValue("@id", id);
                con.Open();
                SqlDataReader sdr = cmd.ExecuteReader();
                if (sdr.HasRows)
                {
                    while (sdr.Read())
                    {
                        e = new Employee();
                        e.Id = (int)sdr["Id"];
                        e.Name = (string)sdr["Name"];
                        e.Salary = (int)sdr["Salary"];
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                if(con!=null)
                con.Close();
            }
           return e;
            
        }
        public List<Employee> search(string name)
        {
            SqlConnection conn = null;
            List<Employee> l = null;
            try
            {
                conn = getconnection();
                SqlCommand md = new SqlCommand("select *from Employee where Name=@name", conn);
                md.Parameters.AddWithValue("@name", name);
                conn.Open();
                SqlDataReader sd = md.ExecuteReader();
                if (sd.HasRows)
                {
                    l = new List<Employee>();
                    while (sd.Read())
                    {
                        Employee e = new Employee();
                        e.Id = (int)sd["Id"];
                        e.Name = (String)sd["Name"];
                        e.Salary = (int)sd["Salary"];
                        l.Add(e);
                    }
                }
            }
            catch (Exception ee)
            {
                Console.WriteLine(ee.Message);
            }
            finally
            {
                if (conn != null)
                    conn.Close();
            }
            return l;

        }

    }
}
