using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace DesktopApp1
{
    public partial class AllInfoFormPerson : Form
    {
        public string currentPersonPID;
        public string currentPersonName;
        public string currentPersonEmail;
        Controller controller = new Controller();
        RegistrationForm regForm;
        public AllInfoFormPerson(RegistrationForm registrationForm)
        {
            regForm = registrationForm;
            InitializeComponent();
            //textBoxNbr.KeyPress += regForm.onlyDigitsAndBackspace_KeyPress;
            
        }
        private void textBoxNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.onlyDigitsAndBackspace_KeyPress(sender, e);
        }
        private void textBoxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.onlyLettersAndBackspaceAndWhitespace(sender, e);
        }
        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.noWhiteSpace_KeyPress(sender, e);
        }

         

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newPersonPid = textBoxNbr.Text.Trim();
            string newPersonName = textBoxName.Text.Trim();
            string newPersonEmail = textBoxEmail.Text;
            
            if (newPersonPid.Equals(currentPersonPID) || String.Empty.Equals(newPersonPid))
            { 
                if (!String.Empty.Equals(newPersonName))
                {
                    controller.UpdatePersonName(newPersonName, currentPersonPID);
                    currentPersonName = newPersonName;
                    //textBoxName.Text = newPersonName;
                }
                if(!String.Empty.Equals(newPersonEmail))
                {
                    controller.UpdatePersonEmail(newPersonEmail, currentPersonPID);
                    currentPersonEmail = newPersonEmail;
                }
                //textBoxNbr.Text = currentPersonPID;
            }
            else if (controller.SpecificPerson(newPersonPid) == true)
            {
                MessageBox.Show("Personnummret " + newPersonPid + " är redan registrerat", "Redan registrerat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(newPersonPid.Length != 10)
                {
                    MessageBox.Show("Personnummret måste vara 10 siffror långt", "Inkorrekt personnummer" , MessageBoxButtons.OK);
                }
                else
                {
                    if (!String.Empty.Equals(newPersonEmail))
                    {
                        controller.UpdatePersonEmail(newPersonEmail, currentPersonPID);
                        controller.UpdatePersonName(newPersonName, currentPersonPID);
                        controller.UpdatePersonPID(currentPersonPID, newPersonPid);
                        MessageBox.Show("Personnummer uppdaterat till " + newPersonPid);
                        currentPersonPID = newPersonPid;
                        currentPersonEmail = newPersonEmail;
                        //textBoxNbr.Text = currentPersonPID;

                    }
                    else
                    {
                        controller.UpdatePersonName(newPersonName, currentPersonPID);
                        controller.UpdatePersonPID(currentPersonPID, newPersonPid);
                        MessageBox.Show("Personnummer uppdaterat till " + newPersonPid);
                        currentPersonPID = newPersonPid;
                        //textBoxNbr.Text = currentPersonPID;
                        //textBoxEmail.Text = currentPersonEmail;

                    }
                }
            }
            textBoxNbr.Text = currentPersonPID;
            textBoxName.Text = currentPersonName;
            textBoxEmail.Text = currentPersonEmail;
            regForm.showSearch();
        }

        private void btnDeletePerson_Click(object sender, EventArgs e)
        {
            DialogResult removePersonDR = MessageBox.Show("Är du säker på att du vill ta bort " + currentPersonPID + " från databasen?", "Ta bort person", MessageBoxButtons.YesNo);
            if(removePersonDR == DialogResult.Yes)
            {
                controller.RemovePerson(currentPersonPID);
                regForm.showSearch();
                this.Close();
            }
        }

        private void btnRemoveCar_Click(object sender, EventArgs e)
        {
            if (dataGridViewCars.SelectedRows.Count < 1)
            {

            }
            else
            {
                string pk;
                DataTable tempDT;
                pk = dataGridViewCars.CurrentRow.Cells[1].Value.ToString();
                tempDT = controller.SpecificRow(pk);
                
                DialogResult removeCarDR = MessageBox.Show("Är du säker på att du vill ta bort " + pk + " från " + currentPersonPID + "?", "Ta bort bil", MessageBoxButtons.YesNo);
                if (removeCarDR == DialogResult.Yes)
                {
                    controller.RemoveOwner(currentPersonPID, pk);
                    dataGridViewCars.DataSource = controller.FindPersonsCars(currentPersonPID);
                    MessageBox.Show(pk + " har tagits bort från " + currentPersonPID, "Borttagen", MessageBoxButtons.OK);
                }
            }
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            InputForm inputForm = new InputForm(this);
            inputForm.ShowDialog();
        }

        private void dataGridViewCars_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string pk;
            DataTable tempDT;
            pk = dataGridViewCars.CurrentRow.Cells[1].Value.ToString();
            tempDT = controller.SpecificRow(pk);

            AllInfoFormCar allInfoFormCar = new AllInfoFormCar(regForm);
            allInfoFormCar.textBoxNbr.Text = tempDT.Rows[0][1].ToString();
            allInfoFormCar.textBoxName.Text = tempDT.Rows[0][0].ToString();
            allInfoFormCar.currentLicenseNbr = pk;

            allInfoFormCar.textBoxOwner.Text = controller.FindCarsOwner(pk)[0];
            allInfoFormCar.labelOwnerName.Text = controller.FindCarsOwner(pk)[1];
            allInfoFormCar.btnRemoveOwner.Visible = true;
            allInfoFormCar.currentCarOwnerPID = controller.FindCarsOwner(pk)[0];
            allInfoFormCar.Shown += (s, args) => this.Hide();       //Döljer nuvarande AllInfoFormPerson fönster när allInfoFormCar visas
            allInfoFormCar.ShowDialog();                           // AllInfoFormPerson fönstret stängs när man stänger allInfoFormCar
            this.Close();

        }
    }
}
