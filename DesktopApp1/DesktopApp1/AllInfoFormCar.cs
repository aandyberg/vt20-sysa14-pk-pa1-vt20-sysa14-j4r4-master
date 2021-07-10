using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopApp1
{
    public partial class AllInfoFormCar : Form
    {
        public string currentCarOwnerPID = "";
        public string currentLicenseNbr;
        Controller controller = new Controller();
        RegistrationForm regForm;


        public AllInfoFormCar(RegistrationForm registrationForm)
        {
            regForm = registrationForm;
            InitializeComponent();
            //textBoxOwner.KeyPress += regForm.onlyDigitsAndBackspace_KeyPress;
            //textBoxNbr.KeyPress += regForm.noWhiteSpace_KeyPress;
        }

        private void textBoxOwner_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.onlyDigitsAndBackspace_KeyPress(sender, e);
        }

        private void textBoxNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.noWhiteSpace_KeyPress(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string newLicenseNbr = textBoxNbr.Text;
            string newOwner = textBoxOwner.Text;
            if (newLicenseNbr.Equals(currentLicenseNbr) || String.Empty.Equals(newLicenseNbr))
            {
                if (newOwner.Equals(currentCarOwnerPID) || String.Empty.Equals(newLicenseNbr))
                {
                    
                }
                else if (controller.FindCarsOwner(currentLicenseNbr).Count != 0)
                {
                    MessageBox.Show("Ta bort befintlig ägare innan du kan lägga till en ny.", "Finns befintlig ägare", MessageBoxButtons.OK);
                }
                else if(controller.SpecificPerson(newOwner) == true)
                {
                    if(String.Empty.Equals(newLicenseNbr))
                    {
                        controller.AddOwner(newOwner, currentLicenseNbr);
                        labelOwnerName.Text = controller.FindCarsOwner(currentLicenseNbr)[1];
                        btnRemoveOwner.Visible = true;
                        //currentCarOwnerPID = newOwner;
                    }
                    else
                    {
                        controller.AddOwner(newOwner, newLicenseNbr);
                        labelOwnerName.Text = controller.FindCarsOwner(currentLicenseNbr)[1];
                        btnRemoveOwner.Visible = true;
                        currentCarOwnerPID = newOwner;
                    }
                }
                else
                {
                    MessageBox.Show("Ingen person registrerad med personummer " + newOwner);
                }

            }
            else if (controller.SpecificCar(newLicenseNbr) == true)
            {
                MessageBox.Show("Registreringsnummret " + newLicenseNbr + " är redan registrerat", "Redan registrerat", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                /*controller.UpdateCarLicenseNbr(currentLicenseNbr, newLicenseNbr);
                currentLicenseNbr = newLicenseNbr;
                MessageBox.Show("Registreringsnummret uppdaterad till: " + newLicenseNbr, "Nytt registreringsnummer", MessageBoxButtons.OK);
                controller.UpdateCarBrand(textBoxName.Text, newLicenseNbr);*/
                if (newOwner.Equals(currentCarOwnerPID))
                {
                    controller.UpdateCarLicenseNbr(currentLicenseNbr, newLicenseNbr);
                    currentLicenseNbr = newLicenseNbr;
                    MessageBox.Show("Registreringsnummret uppdaterad till: " + newLicenseNbr, "Nytt registreringsnummer", MessageBoxButtons.OK);
                    //controller.UpdateCarBrand(textBoxName.Text.Trim(), newLicenseNbr);
                }
                else if(controller.SpecificPerson(newOwner) == true)
                {
                    controller.UpdateCarLicenseNbr(currentLicenseNbr, newLicenseNbr);
                    currentLicenseNbr = newLicenseNbr;
                    MessageBox.Show("Registreringsnummret uppdaterad till: " + newLicenseNbr, "Nytt registreringsnummer", MessageBoxButtons.OK);
                    //controller.UpdateCarBrand(textBoxName.Text.Trim(), newLicenseNbr);

                    controller.AddOwner(newOwner, newLicenseNbr);
                    labelOwnerName.Text = controller.FindCarsOwner(currentLicenseNbr)[1];
                    btnRemoveOwner.Visible = true;
                    currentCarOwnerPID = newOwner;
                }
                else
                {
                    MessageBox.Show("Ingen person registrerad med personummer " + newOwner);
                }

            }
            textBoxNbr.Text = currentLicenseNbr;
            regForm.showSearch();
            
        }

        private void btnRemoveOwner_Click(object sender, EventArgs e) 
        {
            DialogResult removeOwnerDR = MessageBox.Show("Är du säker på att du vill ta bort " + labelOwnerName.Text + ", " + currentCarOwnerPID + " som ägare.","Ta bort ägare", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(removeOwnerDR == DialogResult.Yes)
            {
                controller.RemoveOwner(currentCarOwnerPID, currentLicenseNbr);
                labelOwnerName.Text = "Ingen registrerad ägare";
                textBoxOwner.Text = "";
                currentCarOwnerPID = "";
                btnRemoveOwner.Visible = false;
                textBoxNbr.Text = currentLicenseNbr;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult removeCarDR = MessageBox.Show("Är du säker på att du vill ta bort " + currentLicenseNbr + " från databasen?", "Ta bort bil", MessageBoxButtons.YesNo);
            if (removeCarDR == DialogResult.Yes)
            {
                controller.RemoveCar(currentLicenseNbr);
                regForm.showSearch();
                this.Close();
            }
        }
    }
}
