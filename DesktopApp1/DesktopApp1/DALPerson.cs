using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApp1
{
    public class DALPerson
    {
        private string name;
        private int pID;

        public string Name { get => name; set => name = value; }
        public int PID { get => pID; set => pID = value; }
        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public void AddPerson(string name, string pID, string email) // Lägger till en person i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "INSERT INTO PERSON VALUES(" + "'" + name + "'" + ", " + "'" + pID + "'" + ",'" + email + "','password')";
                adapter.InsertCommand = new SqlCommand(queryString, conn.Conn);
                adapter.InsertCommand.ExecuteNonQuery();
            }
            catch(Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
        
        }
        public void RemovePerson(string pID) // Tar bort en person från databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "DELETE FROM PERSON WHERE pID =" + "'" + pID + "'";
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
        public void UpdatePersonName(string name, string pID) // Uppdaterar en persons namn i dataasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "UPDATE PERSON SET name = '" + name + "'" + " WHERE pID = '" + pID + "'";
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
        public void UpdatePersonPID(string oldPID, string newPID) // Uppdaterar en persons personnummer i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "UPDATE PERSON SET pID = '" + newPID + "'" + " WHERE pID = '" + oldPID + "'";
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
        public void UpdatePersonEmail(string email, string pID) // Uppdaterar en persons email i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "UPDATE PERSON SET email = '" + email + "'" + " WHERE pID = '" + pID + "'";
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

        public DataTable SearchPerson(string search) // Söker efter person i databasen som matcher användarens sökord och retunerar detta 
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT name AS Namn, pid AS Personnummer, email AS Email FROM PERSON WHERE name LIKE '" + search + "%' OR pID like '" + search + "%' OR email like '" + search + "%'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }

            return dataTable;
        }

        public DataTable FindPersonsCars(string pID) // söker efter en persons i databasen och retunerar alla bilar kopplade till denna
        {
            DataTable personsCars = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT licenseNbr FROM OwnsCar WHERE pID = '" + pID + "'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                adapter.Fill(personsCars);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }

            return personsCars;
        }

        public DataTable SpecificPerson(string pID) // Söker efter en specifik person i databasen
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT * FROM PERSON WHERE pID = '" + pID + "'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                adapter.Fill(dataTable);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
            return dataTable;
        }


    }


}
