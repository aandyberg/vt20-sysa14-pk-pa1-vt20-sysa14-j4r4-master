using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace Assignment5
{
    public class Connection
    {
        static string connectionStringAss5 = "DATA SOURCE = localhost;INITIAL CATALOG = Demo Database NAV (5-0);User ID=app;Password=123";
        SqlConnection conn = new SqlConnection(connectionStringAss5);

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