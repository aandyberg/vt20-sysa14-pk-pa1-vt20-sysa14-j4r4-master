using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DesktopApp1
{
    class Assignment2
    {
        Connection conn = new Connection();
        SqlDataAdapter adapter = new SqlDataAdapter();

        public DataTable ColumnName()       //Fills a datatable with table and column names, then creates a new datatable with a third column containing number of rows
        {
            conn.DBConnectionOpen2();
            string queryString = "SELECT TABLE_NAME AS Tabellnamn, COLUMN_NAME AS Kolumnnamn " +
                "FROM INFORMATION_SCHEMA.COLUMNS " +
                "WHERE TABLE_NAME IN (SELECT table_name " +
                "FROM information_schema.tables info, TablesOfInterest tab " +
                "WHERE info.TABLE_NAME = tab.tableName)";
            adapter = new SqlDataAdapter(queryString, conn.Conn2);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            DataTable table = new DataTable();
            DataColumn column = new DataColumn();
            column.DataType = Type.GetType("System.String");
            column.ColumnName = "Tabellnamn";
            column.ReadOnly = true;
            column.Unique = false;
            table.Columns.Add(column);
            DataColumn column2 = new DataColumn();
            column2.DataType = Type.GetType("System.String");
            column2.ColumnName = "Kolumnnamn";
            column2.ReadOnly = true;
            column2.Unique = false;
            table.Columns.Add(column2);
            DataColumn column3 = new DataColumn();
            column3.DataType = Type.GetType("System.String");
            column3.ColumnName = "Antal rader";
            column3.ReadOnly = true;
            column3.Unique = false;
            table.Columns.Add(column3);
            int rowLength = dataTable.Rows.Count;
            for (int i = 0; i < rowLength; i++)
            {
                DataRow row = dataTable.Rows[i];
                string columnOne = row[0].ToString();
                string columnTwo = row[1].ToString();
                string query = "SELECT COUNT(" + columnTwo + ") FROM " + columnOne;
                adapter = new SqlDataAdapter(query, conn.Conn2);
                DataTable nbrOfRows = new DataTable();
                adapter.Fill(nbrOfRows);
                DataRow row2 = nbrOfRows.Rows[0];
                string columnThree = row2[0].ToString();
                row = table.NewRow();
                row["Tabellnamn"] = columnOne;
                row["Kolumnnamn"] = columnTwo;
                row["Antal rader"] = columnThree;
                table.Rows.Add(row);
            }
            Console.WriteLine(dataTable);
            conn.DBConnectionClose2();
            return table;
        }
    }
}
