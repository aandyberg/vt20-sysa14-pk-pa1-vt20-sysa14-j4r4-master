using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Assignment_3.Assignment3Reference;
using Newtonsoft.Json;


namespace DesktopApp1
{
    class Controller
    {
        DALPerson person = new DALPerson();
        DALCar car = new DALCar();
        Assignment2 assignment2 = new Assignment2();

        public DataTable GetMetaDataFromEmpAndRelated()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetMetaDataFromEmpAndRelated());
            return dataTable;
        }

        public DataTable GetInfoFromEmpAndRelatives()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetInfoFromEmpAndRelatives());
            return dataTable;
        }

        public DataTable GetAllIndexes()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllIndexes());
            return dataTable;
        }

        public DataTable GetInfoEmpSickness2004()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetInfoEmpSickness2004());
            return dataTable;
        }

        public DataTable GetNameAbsentMost()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetNameAbsentMost());
            return dataTable;
        }

        public DataTable GetAllColumnsFromEmp2()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllColumnsFromEmp2());
            return dataTable;
        }

        public DataTable GetAllColumnsFromEmp1()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllColumnsFromEmp1());
            return dataTable;
        }

        public DataTable GetAllTablesDB2()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllTablesDB2());
            return dataTable;
        }

        public DataTable GetAllTablesDB1()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllTablesDB1());
            return dataTable;
        }

        public DataTable GetAllTableConstraints()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllTableConstraints());
            return dataTable;
        }

        public DataTable GetAllKeys()
        {
            Assignment6Reference.WebServiceAss6SoapClient wsClient = new Assignment6Reference.WebServiceAss6SoapClient();
            DataTable dataTable = JsonConvert.DeserializeObject<DataTable>(wsClient.GetAllKeys());
            return dataTable;
        }

        public string AddEmployeeAss5(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            Assignment5Reference.WebServiceAss5SoapClient wSClient = new Assignment5Reference.WebServiceAss5SoapClient();
            return wSClient.AddEmployee(no, firstName, lastName, jobTitle, eMail);
        }
        public string UpdateEmployeeAss5(string no, string firstName, string lastName, string jobTitle, string eMail)
        {
            Assignment5Reference.WebServiceAss5SoapClient wSClient = new Assignment5Reference.WebServiceAss5SoapClient();
            return wSClient.updateEmployee(no, firstName, lastName, jobTitle, eMail);
        }
        public string RemoveEmployeeAss5(string no)
        {
            Assignment5Reference.WebServiceAss5SoapClient wSClient = new Assignment5Reference.WebServiceAss5SoapClient();
            return wSClient.RemoveEmployee(no);
        }
        public DataTable SearchEmployeeAss5(string no)
        {
            Assignment5Reference.WebServiceAss5SoapClient wSClient = new Assignment5Reference.WebServiceAss5SoapClient();
            DataTable dt = new DataTable();
            if(string.IsNullOrEmpty(wSClient.searchEmployee(no).no))
            {
                
            }
            else
            {
                dt.Columns.Add("No.", typeof(string));
                dt.Columns.Add("First name", typeof(string));
                dt.Columns.Add("Last name", typeof(string));
                dt.Columns.Add("Job Title", typeof(string));
                dt.Columns.Add("Email", typeof(string));

                DataRow row = dt.NewRow();
                row["No."] = wSClient.searchEmployee(no).no;
                row["First name"] = wSClient.searchEmployee(no).firstName;
                row["Last name"] = wSClient.searchEmployee(no).lastName;
                row["Job Title"] = wSClient.searchEmployee(no).jobTitle;
                row["Email"] = wSClient.searchEmployee(no).eMail;
                dt.Rows.Add(row);
            }

            return dt;

        }

        public string ShowFile(string filename)
        {
            WebService3SoapClient wSClient = new WebService3SoapClient();
            return wSClient.rentacar(filename);
        }
        public DataSet GetAllCars()
        {
            Assignment4Reference.WebServiceAssignment4SoapClient wsClient = new Assignment4Reference.WebServiceAssignment4SoapClient();
            return wsClient.GetAllCars();
        }
        public DataSet GetAllPersons()
        {
            Assignment4Reference.WebServiceAssignment4SoapClient wsClient = new Assignment4Reference.WebServiceAssignment4SoapClient();
            return wsClient.GetAllPersons();
        }
        public DataSet GetAllOwners()
        {
            Assignment4Reference.WebServiceAssignment4SoapClient wsClient = new Assignment4Reference.WebServiceAssignment4SoapClient();
            return wsClient.GetAllOwners();
        }


        public void onlyDigitsAndBackspace_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr != 8)         //Tillåter endast siffror samt backspace (backspace har keycode 8)
            {
                e.Handled = true;
                MessageBox.Show("Enbart siffror är tillåtna");
            }
        }

        public void noWhiteSpace_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (Char.IsWhiteSpace(chr))                     //Tillåter inga whitespace
            {
                e.Handled = true;
                MessageBox.Show("Inga mellanrum tillåtna");
            }
        }
        public void onlyLettersAndBackspaceAndWhitespace(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsLetter(chr) && chr != 8 && chr != 32)         //Tillåter endast bokstäver samt backspace och space (backspace har keycode 8 och space 32)
            {
                e.Handled = true;
                MessageBox.Show("Enbart bokstäver är tillåtna");
            }
        }

        public void AddPerson(string name, string pID, string email)
        {
            try
            {
                person.AddPerson(name, pID, email);
            }
            catch (Exception) 
            {
                throw;
            }
        }
        public void RemovePerson(string pID)
        {
            person.RemovePerson(pID);
        }
        public void UpdatePersonName(string name, string pID)
        {
            person.UpdatePersonName(name, pID);
        }
        public void UpdatePersonPID(string oldPID, string newPID)
        {
            person.UpdatePersonPID(oldPID, newPID);
        }
        public void UpdatePersonEmail(string email, string pID)
        {
            person.UpdatePersonEmail(email, pID);
        }
        public void AddCar(string brand, string licenseNbr, int price)
        {
            try
            {
                car.AddCar(brand, licenseNbr, price);
            }
            catch (Exception)
            {
                throw;
            }
        }
        public void RemoveCar(string licenseNbr)
        {
            car.RemoveCar(licenseNbr);
        }
        public void UpdateCarBrand(string brand, string licenseNbr)
        {
            car.UpdateCarBrand(brand, licenseNbr);
        }
        public void UpdateCarLicenseNbr(string oldLicenseNbr, string newLicenseNbr)
        {
            car.UpdateCarLicenseNbr(oldLicenseNbr, newLicenseNbr);
        }
        public void AddOwner(string pID, string licenseNbr)
        {
            car.AddOwner(pID, licenseNbr);
        }
        public void RemoveOwner(string pID, string licenseNbr)
        {
            car.RemoveOwner(pID, licenseNbr);
        }
        public DataTable SearchAll(string search)
        {
            return car.SearchAll(search);
            
        }
        public DataTable SearchPerson(string search)
        {
            return person.SearchPerson(search);
        }
        public DataTable SearchCar(string search)
        {
            return car.SearchCar(search);
        }
        public string ShowException(string text)
        {
            return text;
        }
        public DataTable SpecificRow(string pk)
        {
            try
            {
                return car.SpecificCarOrPerson(pk);
               
            }
            catch (Exception)
            {
                throw;
            }
        }
        public List<string> FindCarsOwner(string licenseNbr)
        {
            List<string> ownerList = new List<string>();
            DataTable tempDTCar;
            tempDTCar = car.FindCarsOwner(licenseNbr);
            if (tempDTCar.Rows.Count != 0)
            {
                ownerList.Add(tempDTCar.Rows[0]["pID"].ToString());
                ownerList.Add(SearchPerson(ownerList[0]).Rows[0]["Namn"].ToString());
            }
            return ownerList;
        }

        public DataTable FindPersonsCars(string pID)
        {
            DataTable tempDTPerson;
            DataTable tempDTCars = new DataTable(); 
            tempDTPerson = person.FindPersonsCars(pID);
            foreach (DataRow row in tempDTPerson.Rows)
            {
                var tempCar = car.SearchCar(row["licenseNbr"].ToString());
                tempDTCars.Merge(tempCar);
            }
            return tempDTCars;
        }

        public Boolean SpecificPerson(string pID)
        {
            bool x = false;
            DataTable tempDTPerson;
            tempDTPerson = SearchPerson(pID);
            foreach(DataRow row in tempDTPerson.Rows)
            {
                if(row[1].ToString() == pID)
                {
                    x = true;
                }
                
            }
            return x;
        }

        public Boolean SpecificCar(string licenseNbr)
        {
            bool x = false;
            DataTable tempDTCar;
            tempDTCar = SearchCar(licenseNbr);
            foreach(DataRow row in tempDTCar.Rows)
            {
                if(row[1].ToString() == licenseNbr)
                {
                    x = true;
                }
            }
            return x;
        }
        public DataTable MetadataColumns()
        {
            return assignment2.ColumnName();
        }
    }
}
