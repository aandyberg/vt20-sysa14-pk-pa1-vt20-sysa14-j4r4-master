using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Data;
using System.Reflection;

namespace Assignment6
{
    /// <summary>
    /// Summary description for WebServiceAss6
    /// </summary>
    [WebService(Namespace = "http://rentacar.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServiceAss6 : System.Web.Services.WebService
    {
        Controller controller = new Controller();

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public string GetAllIndexes()
        {
            return controller.GetAllIndexes();
        }
        [WebMethod]
        public string GetAllKeys()
        {
            return controller.GetAllKeys();
        }
        [WebMethod]
        public string GetAllTableConstraints()
        {
            return controller.GetAllTableConstraints();
        }
        [WebMethod]
        public string GetAllColumnsFromEmp1()
        {
            return controller.GetAllColumnsFromEmp1();
        }
        [WebMethod]
        public string GetAllColumnsFromEmp2()
        {
            return controller.GetAllColumnsFromEmp2();
        }
        [WebMethod]
        public string GetAllTablesDB1()
        {
            return controller.GetAllTablesDB1();
        }
        [WebMethod]
        public string GetAllTablesDB2()
        {
            return controller.GetAllTablesDB2();
        }
        [WebMethod]
        public string GetNameAbsentMost()
        {
            return controller.GetNameAbsentMost();
        }
        [WebMethod]
        public string GetInfoEmpSickness2004()
        {
            return controller.GetInfoEmpSickness2004();
        }
        [WebMethod]
        public string GetInfoFromEmpAndRelatives()
        {
            return controller.GetInfoFromEmpAndRelatives();
        }
        [WebMethod]
        public string GetMetaDataFromEmpAndRelated()
        {
            return controller.GetMetaDataFromEmpAndRelated();
        }


    }
}
