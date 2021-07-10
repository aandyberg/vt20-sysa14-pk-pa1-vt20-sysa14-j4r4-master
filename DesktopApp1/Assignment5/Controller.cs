using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Data;

namespace Assignment5
{
    public class Controller
    {
        DALCronus cronus = new DALCronus();

        public void AddEmployee(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            try
            {
                cronus.AddEmployee(no, firstName, lastName, jobTitle, eMail);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void UpdateEmployee(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            try
            {
                cronus.UpdateEmployee(no, firstName, lastName, jobTitle, eMail);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void RemoveEmployee(string no)
        {
            try
            {
                cronus.RemoveEmployee(no);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public DataTable SearchEmployee(string no)
        {
            try
            {
                return cronus.SearchEmployee(no);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}