using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using Newtonsoft.Json;

namespace Assignment6
{
    public class Controller
    {
        Dal dal = new Dal();

        public string GetAllIndexes()
        {
            return DataTableToJson(dal.GetAllIndexes().Tables[0]);
        }

        public string GetAllKeys()
        {
            return DataTableToJson(dal.GetAllKeys().Tables[0]);
        }

        public string GetAllTableConstraints()
        {
            return DataTableToJson(dal.GetAllTableConstraints().Tables[0]);
        }

        public string GetAllColumnsFromEmp1()
        {
            return DataTableToJson(dal.GetAllColumnsFromEmp1().Tables[0]);       
        }

        public string GetAllColumnsFromEmp2()
        {
            return DataTableToJson(dal.GetAllColumnsFromEmp2().Tables[0]);
        }

        public string GetAllTablesDB1()
        {
            return DataTableToJson(dal.GetAllTablesDB1().Tables[0]);
        }

        public string GetAllTablesDB2()
        {
            return DataTableToJson(dal.GetAllTablesDB2().Tables[0]);
        }

        public string GetNameAbsentMost()
        {
            return DataTableToJson(dal.GetNameAbsentMost().Tables[0]);
        }

        public string GetInfoEmpSickness2004()
        {
            return DataTableToJson(dal.GetInfoEmpSickness2004().Tables[0]);
        }

        public string GetInfoFromEmpAndRelatives()
        {
            return DataTableToJson(dal.GetInfoFromEmpAndRelatives().Tables[0]);
        }

        public string GetMetaDataFromEmpAndRelated()
        {
            return DataTableToJson(dal.GetMetaDataFromEmpAndRelated().Tables[0]);
        }

        public string DataTableToJson(DataTable dt)
        {
            string jsonString;

            jsonString = JsonConvert.SerializeObject(dt);
            return jsonString;
        }
    }
}