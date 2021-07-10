using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Assignment4
{
    public class Connection
    {
        static string connectionString = "DATA SOURCE = localhost;INITIAL CATALOG = Grupp6DB;User ID=app;Password=123";
        SqlConnection conn = new SqlConnection(connectionString);

        public SqlConnection Conn { get => conn; set => conn = value; }

        public void DBConnectionOpen()
        {
            try
            {
                Conn.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
        }
        public void DBConnectionClose()
        {
            try
            {
                Conn.Close();
                //Conn.Dispose();
            }
            catch (SqlException)
            {
                Console.WriteLine("ERROR");
            }
        }
    }
}