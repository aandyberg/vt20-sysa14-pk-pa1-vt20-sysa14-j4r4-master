using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data.SqlClient;
using System.Data;
using System.Web.Script.Serialization;

namespace Assignment5
{
    /// <summary>
    /// Summary description for WebServiceAss5
    /// </summary>
    [WebService(Namespace = "http://rentacar.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAss5 : System.Web.Services.WebService
    {
        Controller controller = new Controller();

        public class Employee
        {
            public string no { get; set; }
            public string firstName { get; set; }
            public string lastName { get; set; }
            public string jobTitle { get; set; }
            public string eMail { get; set; }

            public Employee () { }
            public Employee (string no, string firstName, string lastName, string jobTitle, string eMail)
            {
                this.no = no;
                this.firstName = firstName;
                this.lastName = lastName;
                this.jobTitle = jobTitle;
                this.eMail = eMail;
            }

        }
        
        public WebServiceAss5() { }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        public string AddEmployee(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            string returnMessage = "";
            try
            {
                controller.AddEmployee(no, firstName, lastName, jobTitle, eMail);
                returnMessage = "Employee was added";
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2627)
                {
                    returnMessage = "Employe already exist";
                }
            }
            catch (Exception)
            {
                returnMessage = "Something went wrong";
            }
            return returnMessage;
        }
        [WebMethod]
        public string RemoveEmployee(string no)
        {
            string returnMessage = "";
            try
            {
                if(searchEmployee(no).no == null)
                {
                    returnMessage = "No employee with this number was found";
                }
                else
                {
                    controller.RemoveEmployee(no);
                    returnMessage = "Employee was removed";
                }
            }
            catch (Exception)
            {
                returnMessage = "Something went wrong, did you write a correct employee number?";
            }
            return returnMessage;
        }
        [WebMethod]
        public string updateEmployee(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            string returnMessage = "";

            try
            {
                if (searchEmployee(no).no == null)
                {
                    returnMessage = "Employee doesn't exist, try with a correct employee number";
                }
                else
                {
                    controller.UpdateEmployee(no, firstName, lastName, jobTitle, eMail);
                    returnMessage = "Employee updated";
                }
            }
            catch (Exception e)
            {
                returnMessage = "Something went wrong, did you write a correct employee number?" + e.Message.ToString();
            }
            return returnMessage;
        }
        [WebMethod]
        public Employee searchEmployee(string no)
        {
            Employee emp = new Employee();
            try
            {
                DataTable tempDT = controller.SearchEmployee(no);
                emp.no = tempDT.Rows[0][0].ToString();
                emp.firstName = tempDT.Rows[0][1].ToString();
                emp.lastName = tempDT.Rows[0][2].ToString();
                emp.jobTitle = tempDT.Rows[0][3].ToString();
                emp.eMail = tempDT.Rows[0][4].ToString();
            }
            catch (IndexOutOfRangeException)
            {
                emp.firstName = "There is no employee with this number";

            }
            catch (Exception)
            {
                emp.firstName = "Something wrong";
            }

            return emp;
        }

    }
}
