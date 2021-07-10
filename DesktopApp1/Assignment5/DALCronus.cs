using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Assignment5
{
    class DALCronus
    {
        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public void AddEmployee(String no, String firstName, String lastName, String jobTitle, String eMail)
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "INSERT INTO[CRONUS Sverige AB$Employee]" +
                    "VALUES(DEFAULT, '" + no + "', '" + firstName + "', '', '" + lastName + "', '', '" + jobTitle + "', '', '', '', '', '', '', '', '', '" + eMail + "', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '', '')";
                adapter.InsertCommand = new SqlCommand(queryString, conn.Conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
        }

        public void UpdateEmployee(String no, String firstName, String lastName, String jobTitle, String eMail)
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "UPDATE [CRONUS Sverige AB$Employee] SET [First Name] = '" + firstName + "', [Last Name] = '" + lastName + "', [Job Title] = '" + jobTitle + "', [E-Mail] = '" + eMail + "' WHERE No_ = '" + no + "'";
                adapter.InsertCommand = new SqlCommand(queryString, conn.Conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }

        }

        public void RemoveEmployee(String no)
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "DELETE [CRONUS Sverige AB$Employee] WHERE No_ = '" + no + "'";
                adapter.InsertCommand = new SqlCommand(queryString, conn.Conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
        }

        public DataTable SearchEmployee(String no)
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT No_, [First Name], [Last Name], [Job Title], [E-Mail] FROM [CRONUS Sverige AB$Employee] WHERE No_ = '" + no + "'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                //adapter.SelectCommand = command;
                //adapter.InsertCommand.ExecuteNonQuery();
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                Console.WriteLine(dataTable);
                return dataTable;
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
        }
    }
}