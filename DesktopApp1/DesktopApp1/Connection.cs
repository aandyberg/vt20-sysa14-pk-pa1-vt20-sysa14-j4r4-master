using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DesktopApp1
{
    public class Connection
    {
        static string connectionString = "DATA SOURCE = localhost;INITIAL CATALOG = Grupp6DB;User ID=app;Password=123";
        SqlConnection conn = new SqlConnection(connectionString);
        static string connectionString2 = "DATA SOURCE = uwdb18.srv.lu.se\\icssql001; INITIAL CATALOG = SYSA14_PK_ProgAssignment2; USER ID = sysa14reader; Password=INFreader1";
        SqlConnection conn2 = new SqlConnection(connectionString2);
        static string connectionStringAss5 = "DATA SOURCE = localhost;INITIAL CATALOG = Demo Database NAV (5-0);User ID=app;Password=123";
        SqlConnection connAss5 = new SqlConnection(connectionStringAss5);

        public SqlConnection Conn { get => conn; set => conn = value; }
        public SqlConnection Conn2 { get => conn2; set => conn2 = value; }
        public SqlConnection ConnAss5 { get => connAss5; set => connAss5 = value; }

        public void DBConnectionOpen()  
        {
            try {
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
            catch(SqlException)
            {
                Console.WriteLine("ERROR");
            }
        }
        public void DBConnectionOpen2()
        {
            try
            {
                Conn2.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
        }
        public void DBConnectionClose2()
        {
            try
            {
                Conn2.Close();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
        }
        public void DBConnectionOpenAss5()
        {
            try
            {
                ConnAss5.Open();
            }
            catch (SqlException)
            {
                Console.WriteLine("Error");
            }
        }
        public void DBConnectionCloseAss5()
        {
            try
            {
                ConnAss5.Close();
                //Conn.Dispose();
            }
            catch (SqlException)
            {
                Console.WriteLine("ERROR");
            }
        }


    }
}
