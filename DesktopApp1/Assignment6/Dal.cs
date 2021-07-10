using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using Newtonsoft.Json;

namespace Assignment6
{
    public class Dal
    {
        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataSet GetAllIndexes()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "select distinct top 100 name from sys.indexes";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllKeys()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT DISTINCT TOP 100 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.KEY_COLUMN_USAGE";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllTableConstraints()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT TOP 100 CONSTRAINT_NAME FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllTablesDB1()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT TOP 100 TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllTablesDB2()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT TOP 100 name FROM sys.tables";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllColumnsFromEmp1()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT COLUMN_NAME FROM INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = 'CRONUS Sverige AB$Employee'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetAllColumnsFromEmp2()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT C.name FROM sys.tables T JOIN sys.columns C ON T.object_id = C.object_id WHERE T.name = 'CRONUS Sverige AB$Employee'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetInfoFromEmpAndRelatives()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT [CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name], [CRONUS Sverige AB$Employee].No_, " +
                    "[CRONUS Sverige AB$Employee Relative].[First Name], [CRONUS Sverige AB$Employee Relative].[Last Name], [CRONUS Sverige AB$Employee Relative].[Relative Code]" +
                    "FROM[CRONUS Sverige AB$Employee] JOIN[CRONUS Sverige AB$Employee Relative] " +
                    "ON[CRONUS Sverige AB$Employee].No_ = [CRONUS Sverige AB$Employee Relative].[Employee No_]";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetInfoEmpSickness2004()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT DISTINCT[CRONUS Sverige AB$Employee Absence].[Employee No_], [CRONUS Sverige AB$Employee].[First Name], [CRONUS Sverige AB$Employee].[Last Name] " +
                    "FROM[CRONUS Sverige AB$Employee Absence] JOIN[CRONUS Sverige AB$Employee] " +
                    "ON[CRONUS Sverige AB$Employee].No_ = [CRONUS Sverige AB$Employee Absence].[Employee No_] WHERE[From Date] LIKE '%2004%' AND[Cause of Absence Code] = 'SJUK'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetNameAbsentMost()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT TOP 1 a.[First Name] FROM [CRONUS Sverige AB$Employee] a " +
                    "INNER JOIN [CRONUS Sverige AB$Employee Absence] b ON a.No_= b.[Employee No_] AND " +
                    "b.[Cause of Absence Code] = 'SJUK' GROUP BY a.[First Name] ORDER BY COUNT(*) DESC";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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

        public DataSet GetMetaDataFromEmpAndRelated()
        {
            try
            {
                conn.DBConnectionOpen();
                String queryString = "SELECT name, object_id, type, create_date, modify_date FROM sys.tables WHERE name LIKE '%Employee%'";
                adapter = new SqlDataAdapter(queryString, conn.Conn);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                return dataSet;
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