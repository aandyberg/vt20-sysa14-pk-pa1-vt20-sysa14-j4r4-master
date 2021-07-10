using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.IO;
using System.Data;
using System.Data.SqlClient;

namespace Assignment4
{
    /// <summary>
    /// Summary description for WebServiceAssignment4
    /// </summary>
    [WebService(Namespace = "http://rentacar.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAssignment4 : System.Web.Services.WebService
    {
        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public DataSet GetAllCars()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From Car";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.DBConnectionClose();
            return ds;
        }
        [WebMethod]
        public DataSet GetAllPersons()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From Person";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.DBConnectionClose();
            return ds;
        }
        [WebMethod]
        public DataSet GetAllOwners()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From Ownscar";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            conn.DBConnectionClose();
            return ds;
        }
        [WebMethod]
        public String[] getAllCarsJava()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From Car";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int rows = dt.Rows.Count;
            String[] array = new String[rows];
            for (int i=0; i < rows; i++)
            {
                DataRow row = dt.Rows[i];
                String input = row[0].ToString() +" " + row[1].ToString();
                array[i] = input;
            }
            return array;
        }
        [WebMethod]
        public String[] getAllOwnerJava()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From OwnsCar";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int rows = dt.Rows.Count;
            String[] array = new String[rows];
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.Rows[i];
                String input = row[0].ToString() + " " + row[1].ToString();
                array[i] = input;
            }
            return array;
        }
        [WebMethod]
        public String[] getAllPersonsJava()
        {
            conn.DBConnectionOpen();
            String queryString = "Select * From Person";
            adapter = new SqlDataAdapter(queryString, conn.Conn);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            int rows = dt.Rows.Count;
            String[] array = new String[rows];
            for (int i = 0; i < rows; i++)
            {
                DataRow row = dt.Rows[i];
                String input = row[0].ToString() + " " + row[1].ToString() + " " + row[2].ToString();
                array[i] = input;
            }
            return array;
        }

    }
}
