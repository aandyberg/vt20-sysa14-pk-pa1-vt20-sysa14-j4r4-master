using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace DesktopApp1
{
    class DALCar
    {
        private string licenseNbr;
        private string brand;

    

        public string LicenseNbr { get => licenseNbr; set => licenseNbr = value; }
        public string Brand { get => brand; set => brand = value; }

        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();
        SqlCommand command;
        SqlDataReader dataReader;

        public void UpdateCarBrand(string brand, string licenseNbr) // Uppdaterar bilmärke i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "UPDATE CAR SET brand = '" + brand + "'" + " WHERE licenseNbr = '" + licenseNbr + "'";
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
        public void UpdateCarLicenseNbr(string oldLicenseNbr, string newLicenseNbr) // Uppdaterar bils regnummer i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "UPDATE CAR SET licenseNbr = '" + newLicenseNbr + "'" + " WHERE licenseNbr = '" + oldLicenseNbr + "'";
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
        public void RemoveCar(string licenseNbr) // Tar bort bil från databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "DELETE FROM CAR WHERE licenseNbr =" + "'" + licenseNbr + "'";
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
        public void AddOwner(string pID, string licenseNbr) // Lägger till en ägare till bil i datasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "INSERT INTO OWNSCAR VALUES(" + "'" + pID + "'" + ", " + "'" + licenseNbr + "'" + ")";
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
        public void RemoveOwner(string pID, string licenseNbr) // Tar bort ägare från bil i databasen
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "DELETE FROM OWNSCAR WHERE pID = " + "'" + pID + "' AND licenseNbr = '" + licenseNbr + "'";
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

        public void AddCar(string brand, string licenseNbr, int price)
        {
            try
            {
                conn.DBConnectionOpen();
                string queryString = "INSERT INTO CAR VALUES(" + "'" + brand + "'" + ", " + "'" + licenseNbr + "'" + "," + price + ")";
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

        public DataTable FindCarsOwner(string licenseNbr) // Letar upp bils ägare i databasen och retunerar den
        {
            DataTable ownerID = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT pID FROM OwnsCar WHERE licenseNbr = '" + licenseNbr + "'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                adapter.Fill(ownerID);
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                try { conn.DBConnectionClose(); } catch { }
            }
            return ownerID;
        }

        public DataTable SearchAll(string search) // Söker genom databasen med sökord från använadern och retunerar resultatet
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT brand, licenseNbr FROM CAR WHERE brand LIKE '" + search + "%' " +
                    "OR licenseNbr like '" + search + "%' " +
                    "UNION ALL SELECT name, pID " +
                    "FROM PERSON WHERE name LIKE '" + search + "%' " +
                    "OR pID like '" + search + "%'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                adapter.Fill(dataTable);
                dataTable.Columns[0].ColumnName = "Person / Bil";
                dataTable.Columns[1].ColumnName = "Personnummber / Registringsnummer";
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

        public DataTable SearchCar(string search) // Söker genom car table i databasen med sökord från användaren och retunerar resultatet
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "SELECT brand AS Märke, licenseNbr AS Registreringsnummer, price AS Pris " +
                    "FROM CAR WHERE brand LIKE '" + search + "%' " +
                    "OR licenseNbr like '" + search + "%'";
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

        public DataTable SpecificCarOrPerson(string pID) // Söker genom databasen med sökord som är primary key och retunerar resultatet
        {
            DataTable dataTable = new DataTable();
            try
            {
                conn.DBConnectionOpen();
                string queryString = "IF EXISTS (SELECT * FROM PERSON WHERE pid = '" + pID + "') " +
                    "BEGIN " +
                    "SELECT* FROM Person where pid = '" + pID + "' " +
                    "END " +
                    "ELSE " +
                    "BEGIN " +
                    "SELECT* FROM Car where licenseNbr = '" + pID + "' " +
                    "END";
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
