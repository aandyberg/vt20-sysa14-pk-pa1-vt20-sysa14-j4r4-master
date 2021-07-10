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
    public partial class InputForm : Form
    {
        Controller controller = new Controller();
        AllInfoFormPerson allInfoFormP;
        public InputForm(AllInfoFormPerson allInfoFormPerson)
        {
            allInfoFormP = allInfoFormPerson;
            InitializeComponent();
        }

        private void textBoxNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.noWhiteSpace_KeyPress(sender, e);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string userInput = textBoxUserInput.Text;
            if(controller.SpecificCar(userInput) == false)
            {
                MessageBox.Show("Finns ingen bil i databasen med registreringsnummret " + userInput, "Bil finns ej", MessageBoxButtons.OK);
            }
            else
            {
                if(controller.FindCarsOwner(userInput).Count != 0)
                {
                    MessageBox.Show("Bilen har redan en ägare ", "Redan registrerad", MessageBoxButtons.OK);
                }
                else
                {
                    controller.AddOwner(allInfoFormP.currentPersonPID, userInput);
                    allInfoFormP.dataGridViewCars.DataSource = controller.FindPersonsCars(allInfoFormP.currentPersonPID);
                    this.Close();
                }
            }
        }
    }
}
