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
using System.Diagnostics;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace DesktopApp1
{
    public partial class RegistrationForm : Form
    {
        public string currentCarOwnerPID = "";
        public string currentLicenseNbr;
        public string currentPersonPID = "";
        public string currentPersonEmail = "";

        Controller controller = new Controller();

        public RegistrationForm()
        {
            InitializeComponent();
            showSearch();
            showMetadata();
            
        }


        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Click on the link below to continue learning how to build a desktop app using WinForms!
            System.Diagnostics.Process.Start("http://aka.ms/dotnet-get-started-desktop");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thanks!");
        }

        private void InitializeComponent()
        {
            this.radioBtnCar = new System.Windows.Forms.RadioButton();
            this.radioBtnPerson = new System.Windows.Forms.RadioButton();
            this.labelNbr = new System.Windows.Forms.Label();
            this.txtBoxSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.checkBoxPerson = new System.Windows.Forms.CheckBox();
            this.checkBoxCar = new System.Windows.Forms.CheckBox();
            this.groupBoxSearch = new System.Windows.Forms.GroupBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.textBoxNameBrand = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.lblNameBrand = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.textBoxNbr = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnConsoleClient = new System.Windows.Forms.Button();
            this.btnJavaGUI3 = new System.Windows.Forms.Button();
            this.richTextBoxOutPut = new System.Windows.Forms.RichTextBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.labelFileName = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridAss4 = new System.Windows.Forms.DataGridView();
            this.btnAss4Java = new System.Windows.Forms.Button();
            this.btnAss4Console = new System.Windows.Forms.Button();
            this.btnAss4ShowOwners = new System.Windows.Forms.Button();
            this.btnAss4ShowPersons = new System.Windows.Forms.Button();
            this.btnAss4ShowCars = new System.Windows.Forms.Button();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnJavaAss5 = new System.Windows.Forms.Button();
            this.labelMessageAss5 = new System.Windows.Forms.Label();
            this.labelEmailAss5 = new System.Windows.Forms.Label();
            this.labelJobTitle = new System.Windows.Forms.Label();
            this.labelLastNameAss5 = new System.Windows.Forms.Label();
            this.labelNameAss5 = new System.Windows.Forms.Label();
            this.labelNbrAss5 = new System.Windows.Forms.Label();
            this.txtBoxEmail = new System.Windows.Forms.TextBox();
            this.txtBoxJob = new System.Windows.Forms.TextBox();
            this.txtBoxLastName = new System.Windows.Forms.TextBox();
            this.txtBoxNbr = new System.Windows.Forms.TextBox();
            this.txtBoxFirstName = new System.Windows.Forms.TextBox();
            this.btnSearchAss5 = new System.Windows.Forms.Button();
            this.btnDeleteAss5 = new System.Windows.Forms.Button();
            this.btnUpdateAss5 = new System.Windows.Forms.Button();
            this.btnAddAss5 = new System.Windows.Forms.Button();
            this.dataGridViewAss5 = new System.Windows.Forms.DataGridView();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.btnJavaAss6 = new System.Windows.Forms.Button();
            this.btnShowAss6 = new System.Windows.Forms.Button();
            this.comboBoxAss6 = new System.Windows.Forms.ComboBox();
            this.dataGridViewAss6 = new System.Windows.Forms.DataGridView();
            this.groupBoxSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAss4)).BeginInit();
            this.tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAss5)).BeginInit();
            this.tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAss6)).BeginInit();
            this.SuspendLayout();
            // 
            // radioBtnCar
            // 
            this.radioBtnCar.AutoSize = true;
            this.radioBtnCar.Location = new System.Drawing.Point(8, 189);
            this.radioBtnCar.Name = "radioBtnCar";
            this.radioBtnCar.Size = new System.Drawing.Size(36, 17);
            this.radioBtnCar.TabIndex = 7;
            this.radioBtnCar.TabStop = true;
            this.radioBtnCar.Text = "Bil";
            this.radioBtnCar.UseVisualStyleBackColor = true;
            this.radioBtnCar.CheckedChanged += new System.EventHandler(this.radioBtnCar_CheckedChanged);
            // 
            // radioBtnPerson
            // 
            this.radioBtnPerson.AutoSize = true;
            this.radioBtnPerson.Checked = true;
            this.radioBtnPerson.Location = new System.Drawing.Point(8, 151);
            this.radioBtnPerson.Name = "radioBtnPerson";
            this.radioBtnPerson.Size = new System.Drawing.Size(58, 17);
            this.radioBtnPerson.TabIndex = 6;
            this.radioBtnPerson.TabStop = true;
            this.radioBtnPerson.Text = "Person";
            this.radioBtnPerson.UseVisualStyleBackColor = true;
            this.radioBtnPerson.CheckedChanged += new System.EventHandler(this.radioBtnPerson_CheckedChanged);
            // 
            // labelNbr
            // 
            this.labelNbr.AutoSize = true;
            this.labelNbr.Location = new System.Drawing.Point(8, 12);
            this.labelNbr.Name = "labelNbr";
            this.labelNbr.Size = new System.Drawing.Size(126, 13);
            this.labelNbr.TabIndex = 7;
            this.labelNbr.Text = "Personnummer (10 siffror)";
            // 
            // txtBoxSearch
            // 
            this.txtBoxSearch.Location = new System.Drawing.Point(44, 31);
            this.txtBoxSearch.Name = "txtBoxSearch";
            this.txtBoxSearch.Size = new System.Drawing.Size(170, 20);
            this.txtBoxSearch.TabIndex = 8;
            this.txtBoxSearch.TextChanged += new System.EventHandler(this.txtBoxSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(91, 80);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(86, 23);
            this.btnSearch.TabIndex = 11;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // checkBoxPerson
            // 
            this.checkBoxPerson.AutoSize = true;
            this.checkBoxPerson.Location = new System.Drawing.Point(44, 57);
            this.checkBoxPerson.Name = "checkBoxPerson";
            this.checkBoxPerson.Size = new System.Drawing.Size(59, 17);
            this.checkBoxPerson.TabIndex = 9;
            this.checkBoxPerson.Text = "Person";
            this.checkBoxPerson.UseVisualStyleBackColor = true;
            // 
            // checkBoxCar
            // 
            this.checkBoxCar.AutoSize = true;
            this.checkBoxCar.Location = new System.Drawing.Point(155, 57);
            this.checkBoxCar.Name = "checkBoxCar";
            this.checkBoxCar.Size = new System.Drawing.Size(42, 17);
            this.checkBoxCar.TabIndex = 10;
            this.checkBoxCar.Text = "Car";
            this.checkBoxCar.UseVisualStyleBackColor = true;
            // 
            // groupBoxSearch
            // 
            this.groupBoxSearch.Controls.Add(this.checkBoxCar);
            this.groupBoxSearch.Controls.Add(this.checkBoxPerson);
            this.groupBoxSearch.Controls.Add(this.btnSearch);
            this.groupBoxSearch.Controls.Add(this.txtBoxSearch);
            this.groupBoxSearch.Location = new System.Drawing.Point(430, 109);
            this.groupBoxSearch.Name = "groupBoxSearch";
            this.groupBoxSearch.Size = new System.Drawing.Size(260, 122);
            this.groupBoxSearch.TabIndex = 0;
            this.groupBoxSearch.TabStop = false;
            this.groupBoxSearch.Text = "Search";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(159, 151);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 22);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // textBoxNameBrand
            // 
            this.textBoxNameBrand.Location = new System.Drawing.Point(159, 53);
            this.textBoxNameBrand.MaxLength = 100;
            this.textBoxNameBrand.Name = "textBoxNameBrand";
            this.textBoxNameBrand.Size = new System.Drawing.Size(173, 20);
            this.textBoxNameBrand.TabIndex = 3;
            this.textBoxNameBrand.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNameBrand_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(159, 98);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(173, 20);
            this.textBoxEmail.TabIndex = 4;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // lblNameBrand
            // 
            this.lblNameBrand.AutoSize = true;
            this.lblNameBrand.Location = new System.Drawing.Point(8, 56);
            this.lblNameBrand.Name = "lblNameBrand";
            this.lblNameBrand.Size = new System.Drawing.Size(35, 13);
            this.lblNameBrand.TabIndex = 12;
            this.lblNameBrand.Text = "Namn";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(8, 101);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 13;
            this.lblEmail.Text = "Email";
            // 
            // textBoxNbr
            // 
            this.textBoxNbr.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxNbr.Location = new System.Drawing.Point(159, 9);
            this.textBoxNbr.MaxLength = 10;
            this.textBoxNbr.Name = "textBoxNbr";
            this.textBoxNbr.Size = new System.Drawing.Size(173, 20);
            this.textBoxNbr.TabIndex = 2;
            this.textBoxNbr.TextChanged += new System.EventHandler(this.textBoxNbr_TextChanged);
            this.textBoxNbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbr_KeyPress);
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(11, 250);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(690, 164);
            this.dataGridView.TabIndex = 1;
            this.dataGridView.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellDoubleClick);
            this.dataGridView.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView_KeyDownDelete);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Location = new System.Drawing.Point(0, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(764, 492);
            this.tabControl1.TabIndex = 16;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnDelete);
            this.tabPage1.Controls.Add(this.btnEdit);
            this.tabPage1.Controls.Add(this.labelNbr);
            this.tabPage1.Controls.Add(this.radioBtnCar);
            this.tabPage1.Controls.Add(this.btnAdd);
            this.tabPage1.Controls.Add(this.radioBtnPerson);
            this.tabPage1.Controls.Add(this.textBoxNbr);
            this.tabPage1.Controls.Add(this.groupBoxSearch);
            this.tabPage1.Controls.Add(this.lblEmail);
            this.tabPage1.Controls.Add(this.dataGridView);
            this.tabPage1.Controls.Add(this.lblNameBrand);
            this.tabPage1.Controls.Add(this.textBoxNameBrand);
            this.tabPage1.Controls.Add(this.textBoxEmail);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(756, 466);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Assignment 1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.ForeColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(615, 420);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Ta bort";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(534, 420);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(75, 23);
            this.btnEdit.TabIndex = 16;
            this.btnEdit.Text = "Redigera";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(756, 466);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Assignment 2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(8, 39);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(735, 406);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnConsoleClient);
            this.tabPage3.Controls.Add(this.btnJavaGUI3);
            this.tabPage3.Controls.Add(this.richTextBoxOutPut);
            this.tabPage3.Controls.Add(this.btnShow);
            this.tabPage3.Controls.Add(this.labelFileName);
            this.tabPage3.Controls.Add(this.textBoxFileName);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(756, 466);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Assignment 3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnConsoleClient
            // 
            this.btnConsoleClient.Location = new System.Drawing.Point(576, 59);
            this.btnConsoleClient.Name = "btnConsoleClient";
            this.btnConsoleClient.Size = new System.Drawing.Size(97, 23);
            this.btnConsoleClient.TabIndex = 5;
            this.btnConsoleClient.Text = "Console client";
            this.btnConsoleClient.UseVisualStyleBackColor = true;
            this.btnConsoleClient.Click += new System.EventHandler(this.btnConsoleClient_Click);
            // 
            // btnJavaGUI3
            // 
            this.btnJavaGUI3.Location = new System.Drawing.Point(576, 21);
            this.btnJavaGUI3.Name = "btnJavaGUI3";
            this.btnJavaGUI3.Size = new System.Drawing.Size(97, 23);
            this.btnJavaGUI3.TabIndex = 4;
            this.btnJavaGUI3.Text = "Java client";
            this.btnJavaGUI3.UseVisualStyleBackColor = true;
            this.btnJavaGUI3.Click += new System.EventHandler(this.btnJavaGUI3_Click);
            // 
            // richTextBoxOutPut
            // 
            this.richTextBoxOutPut.Location = new System.Drawing.Point(36, 106);
            this.richTextBoxOutPut.Name = "richTextBoxOutPut";
            this.richTextBoxOutPut.Size = new System.Drawing.Size(680, 257);
            this.richTextBoxOutPut.TabIndex = 3;
            this.richTextBoxOutPut.Text = "";
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(209, 36);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(75, 23);
            this.btnShow.TabIndex = 2;
            this.btnShow.Text = "Visa";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // labelFileName
            // 
            this.labelFileName.AutoSize = true;
            this.labelFileName.Location = new System.Drawing.Point(21, 39);
            this.labelFileName.Name = "labelFileName";
            this.labelFileName.Size = new System.Drawing.Size(43, 13);
            this.labelFileName.TabIndex = 1;
            this.labelFileName.Text = "Filnamn";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(87, 36);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileName.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.dataGridAss4);
            this.tabPage4.Controls.Add(this.btnAss4Java);
            this.tabPage4.Controls.Add(this.btnAss4Console);
            this.tabPage4.Controls.Add(this.btnAss4ShowOwners);
            this.tabPage4.Controls.Add(this.btnAss4ShowPersons);
            this.tabPage4.Controls.Add(this.btnAss4ShowCars);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(756, 466);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Assignment 4";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // dataGridAss4
            // 
            this.dataGridAss4.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridAss4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridAss4.Location = new System.Drawing.Point(8, 175);
            this.dataGridAss4.Name = "dataGridAss4";
            this.dataGridAss4.Size = new System.Drawing.Size(742, 285);
            this.dataGridAss4.TabIndex = 5;
            // 
            // btnAss4Java
            // 
            this.btnAss4Java.Location = new System.Drawing.Point(591, 27);
            this.btnAss4Java.Name = "btnAss4Java";
            this.btnAss4Java.Size = new System.Drawing.Size(89, 23);
            this.btnAss4Java.TabIndex = 4;
            this.btnAss4Java.Text = "Open Java";
            this.btnAss4Java.UseVisualStyleBackColor = true;
            this.btnAss4Java.Click += new System.EventHandler(this.btnAss4Java_Click);
            // 
            // btnAss4Console
            // 
            this.btnAss4Console.Location = new System.Drawing.Point(591, 65);
            this.btnAss4Console.Name = "btnAss4Console";
            this.btnAss4Console.Size = new System.Drawing.Size(89, 23);
            this.btnAss4Console.TabIndex = 3;
            this.btnAss4Console.Text = "Open console";
            this.btnAss4Console.UseVisualStyleBackColor = true;
            this.btnAss4Console.Click += new System.EventHandler(this.btnAss4Console_Click);
            // 
            // btnAss4ShowOwners
            // 
            this.btnAss4ShowOwners.Location = new System.Drawing.Point(28, 106);
            this.btnAss4ShowOwners.Name = "btnAss4ShowOwners";
            this.btnAss4ShowOwners.Size = new System.Drawing.Size(128, 23);
            this.btnAss4ShowOwners.TabIndex = 2;
            this.btnAss4ShowOwners.Text = "Show all owners";
            this.btnAss4ShowOwners.UseVisualStyleBackColor = true;
            this.btnAss4ShowOwners.Click += new System.EventHandler(this.btnAss4ShowOwners_Click);
            // 
            // btnAss4ShowPersons
            // 
            this.btnAss4ShowPersons.Location = new System.Drawing.Point(28, 65);
            this.btnAss4ShowPersons.Name = "btnAss4ShowPersons";
            this.btnAss4ShowPersons.Size = new System.Drawing.Size(128, 23);
            this.btnAss4ShowPersons.TabIndex = 1;
            this.btnAss4ShowPersons.Text = "Show all persons";
            this.btnAss4ShowPersons.UseVisualStyleBackColor = true;
            this.btnAss4ShowPersons.Click += new System.EventHandler(this.btnAss4ShowPersons_Click);
            // 
            // btnAss4ShowCars
            // 
            this.btnAss4ShowCars.Location = new System.Drawing.Point(28, 27);
            this.btnAss4ShowCars.Name = "btnAss4ShowCars";
            this.btnAss4ShowCars.Size = new System.Drawing.Size(128, 23);
            this.btnAss4ShowCars.TabIndex = 0;
            this.btnAss4ShowCars.Text = "Show all cars";
            this.btnAss4ShowCars.UseVisualStyleBackColor = true;
            this.btnAss4ShowCars.Click += new System.EventHandler(this.btnAss4ShowCars_Click);
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnJavaAss5);
            this.tabPage5.Controls.Add(this.labelMessageAss5);
            this.tabPage5.Controls.Add(this.labelEmailAss5);
            this.tabPage5.Controls.Add(this.labelJobTitle);
            this.tabPage5.Controls.Add(this.labelLastNameAss5);
            this.tabPage5.Controls.Add(this.labelNameAss5);
            this.tabPage5.Controls.Add(this.labelNbrAss5);
            this.tabPage5.Controls.Add(this.txtBoxEmail);
            this.tabPage5.Controls.Add(this.txtBoxJob);
            this.tabPage5.Controls.Add(this.txtBoxLastName);
            this.tabPage5.Controls.Add(this.txtBoxNbr);
            this.tabPage5.Controls.Add(this.txtBoxFirstName);
            this.tabPage5.Controls.Add(this.btnSearchAss5);
            this.tabPage5.Controls.Add(this.btnDeleteAss5);
            this.tabPage5.Controls.Add(this.btnUpdateAss5);
            this.tabPage5.Controls.Add(this.btnAddAss5);
            this.tabPage5.Controls.Add(this.dataGridViewAss5);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(756, 466);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Assignment 5";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnJavaAss5
            // 
            this.btnJavaAss5.Location = new System.Drawing.Point(604, 95);
            this.btnJavaAss5.Name = "btnJavaAss5";
            this.btnJavaAss5.Size = new System.Drawing.Size(75, 23);
            this.btnJavaAss5.TabIndex = 16;
            this.btnJavaAss5.Text = "Java client";
            this.btnJavaAss5.UseVisualStyleBackColor = true;
            this.btnJavaAss5.Click += new System.EventHandler(this.btnJavaAss5_Click);
            // 
            // labelMessageAss5
            // 
            this.labelMessageAss5.AutoSize = true;
            this.labelMessageAss5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.labelMessageAss5.Location = new System.Drawing.Point(302, 107);
            this.labelMessageAss5.Name = "labelMessageAss5";
            this.labelMessageAss5.Size = new System.Drawing.Size(0, 13);
            this.labelMessageAss5.TabIndex = 15;
            // 
            // labelEmailAss5
            // 
            this.labelEmailAss5.AutoSize = true;
            this.labelEmailAss5.Location = new System.Drawing.Point(8, 178);
            this.labelEmailAss5.Name = "labelEmailAss5";
            this.labelEmailAss5.Size = new System.Drawing.Size(32, 13);
            this.labelEmailAss5.TabIndex = 14;
            this.labelEmailAss5.Text = "Email";
            // 
            // labelJobTitle
            // 
            this.labelJobTitle.AutoSize = true;
            this.labelJobTitle.Location = new System.Drawing.Point(8, 152);
            this.labelJobTitle.Name = "labelJobTitle";
            this.labelJobTitle.Size = new System.Drawing.Size(40, 13);
            this.labelJobTitle.TabIndex = 13;
            this.labelJobTitle.Text = "Jobtitel";
            // 
            // labelLastNameAss5
            // 
            this.labelLastNameAss5.AutoSize = true;
            this.labelLastNameAss5.Location = new System.Drawing.Point(8, 129);
            this.labelLastNameAss5.Name = "labelLastNameAss5";
            this.labelLastNameAss5.Size = new System.Drawing.Size(55, 13);
            this.labelLastNameAss5.TabIndex = 12;
            this.labelLastNameAss5.Text = "Efternamn";
            // 
            // labelNameAss5
            // 
            this.labelNameAss5.AutoSize = true;
            this.labelNameAss5.Location = new System.Drawing.Point(8, 100);
            this.labelNameAss5.Name = "labelNameAss5";
            this.labelNameAss5.Size = new System.Drawing.Size(48, 13);
            this.labelNameAss5.TabIndex = 11;
            this.labelNameAss5.Text = "Förnamn";
            // 
            // labelNbrAss5
            // 
            this.labelNbrAss5.AutoSize = true;
            this.labelNbrAss5.Location = new System.Drawing.Point(8, 74);
            this.labelNbrAss5.Name = "labelNbrAss5";
            this.labelNbrAss5.Size = new System.Drawing.Size(24, 13);
            this.labelNbrAss5.TabIndex = 10;
            this.labelNbrAss5.Text = "No.";
            // 
            // txtBoxEmail
            // 
            this.txtBoxEmail.Location = new System.Drawing.Point(95, 178);
            this.txtBoxEmail.Name = "txtBoxEmail";
            this.txtBoxEmail.Size = new System.Drawing.Size(164, 20);
            this.txtBoxEmail.TabIndex = 9;
            // 
            // txtBoxJob
            // 
            this.txtBoxJob.Location = new System.Drawing.Point(95, 152);
            this.txtBoxJob.Name = "txtBoxJob";
            this.txtBoxJob.Size = new System.Drawing.Size(164, 20);
            this.txtBoxJob.TabIndex = 8;
            // 
            // txtBoxLastName
            // 
            this.txtBoxLastName.Location = new System.Drawing.Point(95, 126);
            this.txtBoxLastName.Name = "txtBoxLastName";
            this.txtBoxLastName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxLastName.TabIndex = 7;
            // 
            // txtBoxNbr
            // 
            this.txtBoxNbr.Location = new System.Drawing.Point(95, 74);
            this.txtBoxNbr.Name = "txtBoxNbr";
            this.txtBoxNbr.Size = new System.Drawing.Size(164, 20);
            this.txtBoxNbr.TabIndex = 6;
            // 
            // txtBoxFirstName
            // 
            this.txtBoxFirstName.Location = new System.Drawing.Point(95, 100);
            this.txtBoxFirstName.Name = "txtBoxFirstName";
            this.txtBoxFirstName.Size = new System.Drawing.Size(164, 20);
            this.txtBoxFirstName.TabIndex = 5;
            // 
            // btnSearchAss5
            // 
            this.btnSearchAss5.Location = new System.Drawing.Point(604, 26);
            this.btnSearchAss5.Name = "btnSearchAss5";
            this.btnSearchAss5.Size = new System.Drawing.Size(75, 23);
            this.btnSearchAss5.TabIndex = 4;
            this.btnSearchAss5.Text = "Sök";
            this.btnSearchAss5.UseVisualStyleBackColor = true;
            this.btnSearchAss5.Click += new System.EventHandler(this.btnSearchAss5_Click);
            // 
            // btnDeleteAss5
            // 
            this.btnDeleteAss5.Location = new System.Drawing.Point(265, 26);
            this.btnDeleteAss5.Name = "btnDeleteAss5";
            this.btnDeleteAss5.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAss5.TabIndex = 3;
            this.btnDeleteAss5.Text = "Ta bort";
            this.btnDeleteAss5.UseVisualStyleBackColor = true;
            this.btnDeleteAss5.Click += new System.EventHandler(this.btnDeleteAss5_Click);
            // 
            // btnUpdateAss5
            // 
            this.btnUpdateAss5.Location = new System.Drawing.Point(147, 26);
            this.btnUpdateAss5.Name = "btnUpdateAss5";
            this.btnUpdateAss5.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateAss5.TabIndex = 2;
            this.btnUpdateAss5.Text = "Updatera";
            this.btnUpdateAss5.UseVisualStyleBackColor = true;
            this.btnUpdateAss5.Click += new System.EventHandler(this.btnUpdateAss5_Click);
            // 
            // btnAddAss5
            // 
            this.btnAddAss5.Location = new System.Drawing.Point(28, 26);
            this.btnAddAss5.Name = "btnAddAss5";
            this.btnAddAss5.Size = new System.Drawing.Size(75, 23);
            this.btnAddAss5.TabIndex = 1;
            this.btnAddAss5.Text = "Lägg till";
            this.btnAddAss5.UseVisualStyleBackColor = true;
            this.btnAddAss5.Click += new System.EventHandler(this.btnAddAss5_Click);
            // 
            // dataGridViewAss5
            // 
            this.dataGridViewAss5.AllowUserToAddRows = false;
            this.dataGridViewAss5.AllowUserToDeleteRows = false;
            this.dataGridViewAss5.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAss5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAss5.Location = new System.Drawing.Point(19, 224);
            this.dataGridViewAss5.Name = "dataGridViewAss5";
            this.dataGridViewAss5.ReadOnly = true;
            this.dataGridViewAss5.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewAss5.Size = new System.Drawing.Size(724, 223);
            this.dataGridViewAss5.TabIndex = 0;
            // 
            // tabPage6
            // 
            this.tabPage6.Controls.Add(this.btnJavaAss6);
            this.tabPage6.Controls.Add(this.btnShowAss6);
            this.tabPage6.Controls.Add(this.comboBoxAss6);
            this.tabPage6.Controls.Add(this.dataGridViewAss6);
            this.tabPage6.Location = new System.Drawing.Point(4, 22);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage6.Size = new System.Drawing.Size(756, 466);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Assignment 6";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // btnJavaAss6
            // 
            this.btnJavaAss6.Location = new System.Drawing.Point(659, 51);
            this.btnJavaAss6.Name = "btnJavaAss6";
            this.btnJavaAss6.Size = new System.Drawing.Size(75, 23);
            this.btnJavaAss6.TabIndex = 3;
            this.btnJavaAss6.Text = "Java Client";
            this.btnJavaAss6.UseVisualStyleBackColor = true;
            this.btnJavaAss6.Click += new System.EventHandler(this.btnJavaAss6_Click);
            // 
            // btnShowAss6
            // 
            this.btnShowAss6.Location = new System.Drawing.Point(232, 51);
            this.btnShowAss6.Name = "btnShowAss6";
            this.btnShowAss6.Size = new System.Drawing.Size(75, 23);
            this.btnShowAss6.TabIndex = 2;
            this.btnShowAss6.Text = "Show";
            this.btnShowAss6.UseVisualStyleBackColor = true;
            this.btnShowAss6.Click += new System.EventHandler(this.btnShowAss6_Click);
            // 
            // comboBoxAss6
            // 
            this.comboBoxAss6.FormattingEnabled = true;
            this.comboBoxAss6.ImeMode = System.Windows.Forms.ImeMode.On;
            this.comboBoxAss6.Items.AddRange(new object[] {
            "GetAllKeys",
            "GetAllConstraints",
            "GetAllTables1",
            "GetAllTables2",
            "GetAllColumnsFrom Emp1",
            "GetAllColumnsFromEmp2",
            "GetMostSickEmployee",
            "GetAllAbsense2004",
            "GetAllIndexes",
            "GetInformationAboutEmployeeAndRelatives",
            "GetMetaDataFromEmpAndRelated"});
            this.comboBoxAss6.Location = new System.Drawing.Point(21, 53);
            this.comboBoxAss6.Name = "comboBoxAss6";
            this.comboBoxAss6.Size = new System.Drawing.Size(205, 21);
            this.comboBoxAss6.TabIndex = 1;
            // 
            // dataGridViewAss6
            // 
            this.dataGridViewAss6.AllowUserToAddRows = false;
            this.dataGridViewAss6.AllowUserToDeleteRows = false;
            this.dataGridViewAss6.AllowUserToOrderColumns = true;
            this.dataGridViewAss6.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewAss6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAss6.Location = new System.Drawing.Point(21, 203);
            this.dataGridViewAss6.Name = "dataGridViewAss6";
            this.dataGridViewAss6.ReadOnly = true;
            this.dataGridViewAss6.Size = new System.Drawing.Size(713, 237);
            this.dataGridViewAss6.TabIndex = 0;
            // 
            // RegistrationForm
            // 
            this.ClientSize = new System.Drawing.Size(759, 528);
            this.Controls.Add(this.tabControl1);
            this.Name = "RegistrationForm";
            this.groupBoxSearch.ResumeLayout(false);
            this.groupBoxSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridAss4)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAss5)).EndInit();
            this.tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAss6)).EndInit();
            this.ResumeLayout(false);

        }

 

        private void radioBtnPerson_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnPerson.Checked == true)
            {
                labelNbr.Text = "Personnummer";
                lblEmail.Text = "Email";
                lblNameBrand.Text = "Namn";
                lblEmail.Visible = true;
                textBoxEmail.Visible = true;
                textBoxNbr.Text = "";
                textBoxNameBrand.Text = "";
                textBoxEmail.Text = "";
                textBoxNbr.MaxLength = 10;

            }
        }

        private void radioBtnCar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBtnCar.Checked == true)
            {
                lblEmail.Visible = true;
                textBoxEmail.Visible = true;
                labelNbr.Text = "Registreringsnummer";
                lblNameBrand.Text = "Märke";
                lblEmail.Text = "Price" ;
                textBoxEmail.Text = "";
                textBoxNbr.Text = "";
                textBoxNameBrand.Text = "";
                textBoxNbr.MaxLength = 6;
            }
                

        }

        public void showSearch()
        {
            try
            {
                if (checkBoxCar.Checked == true && checkBoxPerson.Checked == true)
                    dataGridView.DataSource = controller.SearchAll(txtBoxSearch.Text);
                else if (checkBoxPerson.Checked == true)
                {
                    dataGridView.DataSource = controller.SearchPerson(txtBoxSearch.Text);
                }
                else if (checkBoxCar.Checked == true)
                {
                    dataGridView.DataSource = controller.SearchCar(txtBoxSearch.Text);
                }
                else
                {
                    dataGridView.DataSource = controller.SearchAll(txtBoxSearch.Text);
                }
                dataGridView.ClearSelection();
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2)
                {
                    MessageBox.Show("No connection to the database", "error", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong", "error", MessageBoxButtons.OK);
            }

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            showSearch();

        }

        private void txtBoxSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxNbr_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {


                if (radioBtnPerson.Checked == true)
                {
                    if (String.Empty.Equals(textBoxNameBrand.Text.Trim()))
                    {
                        MessageBox.Show("Fyll i ett namn");
                    }
                    else if (textBoxNbr.TextLength == 0 || textBoxNbr.TextLength != 10)
                    {
                        MessageBox.Show("Fyll i ett personnummer");
                    }
                    else if (textBoxEmail.TextLength == 0)
                    {
                        MessageBox.Show("Fyll i email");
                    }
                    else
                    {
                        try
                        {
                            string pID = textBoxNbr.Text;
                            string name = textBoxNameBrand.Text.Trim();
                            string email = textBoxEmail.Text;
                            controller.AddPerson(name, pID, email);
                            MessageBox.Show(pID + ", " + name + " tillagd i databasen", "Ny person", MessageBoxButtons.OK);
                            textBoxNbr.Text = "";
                            textBoxNameBrand.Text = "";
                            textBoxEmail.Text = "";
                        }
                        catch (SqlException sqle)
                        {
                            if (sqle.Number == 2627)
                            {
                                MessageBox.Show("Personnummret finns redan i databasen");
                            }
                            else
                            {
                                MessageBox.Show("Något blev fel, kontakta support \n Errorkod: " + sqle.Number);
                            }
                        }


                    }

                }
                if (radioBtnCar.Checked == true)
                {
                    if (String.Empty.Equals(textBoxNameBrand.Text.Trim()))
                    {
                        MessageBox.Show("Fyll i ett märke");

                    }
                    else if (textBoxNbr.TextLength == 0)
                    {
                        MessageBox.Show("Fyll i ett registreringsnummer");
                    }
                    else
                    {
                        try
                        {
                            string licenseNbr = textBoxNbr.Text;
                            string brand = textBoxNameBrand.Text.Trim();
                            int price = int.Parse(textBoxEmail.Text);
                            controller.AddCar(brand, licenseNbr, price);
                            MessageBox.Show(licenseNbr + " tillagd i databasen", "Ny bil", MessageBoxButtons.OK);
                            textBoxNbr.Text = "";
                            textBoxNameBrand.Text = "";
                            textBoxEmail.Text = "";
                        }
                        catch (SqlException sqle)
                        {
                            if (sqle.Number == 2627)
                            {
                                MessageBox.Show("Registreringsnummer finns redan i databasen");
                            }
                            else
                            {
                                MessageBox.Show("Något blev fel, kontakta support \n Errorkod: " + sqle.Number);
                            }
                        }
                    }

                }

                showSearch();
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2)
                {
                    MessageBox.Show("No connection to the database", "error", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong", "error", MessageBoxButtons.OK);
            }
        }

        private void textBoxNbr_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioBtnPerson.Checked == true)
            {
                controller.onlyDigitsAndBackspace_KeyPress(sender, e);
            }
            else if (radioBtnCar.Checked == true)
            {
                controller.noWhiteSpace_KeyPress(sender, e);
                textBoxNbr.MaxLength = 6;
            }
        }

        private void textBoxEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
            controller.noWhiteSpace_KeyPress(sender, e);
        }
        
        private void textBoxNameBrand_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (radioBtnPerson.Checked == true)
            {

                controller.onlyLettersAndBackspaceAndWhitespace(sender, e);
            }
            
        }

        private void ShowException (string text)
        {
            MessageBox.Show(controller.ShowException(text));
        }


        internal void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string pk;
                DataTable tempDT;
                pk = dataGridView.CurrentRow.Cells[1].Value.ToString();
                tempDT = controller.SpecificRow(pk);
                if (tempDT.Columns.Contains("pID"))
                {
                    AllInfoFormPerson allInfoFormPerson = new AllInfoFormPerson(this);
                    allInfoFormPerson.currentPersonPID = pk;
                    allInfoFormPerson.currentPersonName = tempDT.Rows[0][0].ToString();
                    allInfoFormPerson.currentPersonEmail = tempDT.Rows[0][2].ToString();
                    allInfoFormPerson.textBoxNbr.Text = tempDT.Rows[0][1].ToString();
                    allInfoFormPerson.textBoxName.Text = tempDT.Rows[0][0].ToString();
                    allInfoFormPerson.textBoxEmail.Text = tempDT.Rows[0][2].ToString();
                    allInfoFormPerson.dataGridViewCars.DataSource = controller.FindPersonsCars(pk);

                    allInfoFormPerson.ShowDialog();
                }
                else
                {
                    AllInfoFormCar allInfoFormCar = new AllInfoFormCar(this);

                    allInfoFormCar.textBoxNbr.Text = tempDT.Rows[0][1].ToString();
                    allInfoFormCar.textBoxName.Text = tempDT.Rows[0][0].ToString();
                    allInfoFormCar.currentLicenseNbr = pk;


                    if (controller.FindCarsOwner(pk).Count != 0)
                    {
                        allInfoFormCar.textBoxOwner.Text = controller.FindCarsOwner(pk)[0];
                        allInfoFormCar.labelOwnerName.Text = controller.FindCarsOwner(pk)[1];
                        allInfoFormCar.btnRemoveOwner.Visible = true;
                        allInfoFormCar.currentCarOwnerPID = controller.FindCarsOwner(pk)[0];

                    }
                    allInfoFormCar.ShowDialog();
                }
            }
            catch (SqlException sqle)
            {
                if (sqle.Number == 2)
                {
                    MessageBox.Show("No connection to the database", "error", MessageBoxButtons.OK);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong", "error", MessageBoxButtons.OK);
            }
            
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void showMetadata()
        {
            dataGridView2.DataSource = controller.MetadataColumns();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewCellEventArgs tempE;
            if(dataGridView.SelectedRows.Count < 1)
            {

            }
            else
            {

                tempE = e as DataGridViewCellEventArgs;
                dataGridView_CellDoubleClick(sender, tempE);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dataGridView.SelectedRows.Count < 1)
            {

            }
            else {
                string pk;
                DataTable tempDT;
                pk = dataGridView.CurrentRow.Cells[1].Value.ToString();
                tempDT = controller.SpecificRow(pk);
                if (tempDT.Columns.Contains("pID"))
                {
                    DialogResult removePersonDR = MessageBox.Show("Är du säker på att du vill ta bort " + pk + " från databasen?", "Ta bort person", MessageBoxButtons.YesNo);
                    if (removePersonDR == DialogResult.Yes)
                    {
                        controller.RemovePerson(pk);
                        showSearch();
                        MessageBox.Show(pk + " har tagits bort", "Borttagen", MessageBoxButtons.OK);
                    }
                }
                else
                {
                    DialogResult removeCarDR = MessageBox.Show("Är du säker på att du vill ta bort " + pk + " från databasen?", "Ta bort bil", MessageBoxButtons.YesNo);
                    if (removeCarDR == DialogResult.Yes)
                    {
                        controller.RemoveCar(pk);
                        showSearch();
                        MessageBox.Show(pk + " har tagits bort", "Borttagen", MessageBoxButtons.OK);
                    }
                }
            }
        }
        private void dataGridView_KeyDownDelete(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)         
            {
                btnDelete_Click(sender, e);
            }
        } 

        private void btnShow_Click(object sender, EventArgs e)
        {
            string filename = textBoxFileName.Text;
            richTextBoxOutPut.Text = controller.ShowFile(filename);
        }

        private void btnJavaGUI3_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Desktop\\JavaGUI3.jar");
        }

        private void btnConsoleClient_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Documents\\GitHub\\vt20-sysa14-pk-pa1-vt20-sysa14-j4r4\\DesktopApp1\\WebserviceConsole\\Program.exe");
        }

        private void btnAss4ShowCars_Click(object sender, EventArgs e)
        {
            DataSet ds = controller.GetAllCars();
            DataTable dt = ds.Tables[0];
            dataGridAss4.DataSource = dt;
        }

        private void btnAss4ShowPersons_Click(object sender, EventArgs e)
        {
            DataSet ds = controller.GetAllPersons();
            DataTable dt = ds.Tables[0];
            dataGridAss4.DataSource = dt;
        }

        private void btnAss4ShowOwners_Click(object sender, EventArgs e)
        {
            DataSet ds = controller.GetAllOwners();
            DataTable dt = ds.Tables[0];
            dataGridAss4.DataSource = dt;
        }

        private void btnAss4Java_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Desktop\\Assignment4Java.jar");
        }

        private void btnAss4Console_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Documents\\GitHub\\vt20-sysa14-pk-pa1-vt20-sysa14-j4r4\\DesktopApp1\\WebserviceConsole2\\Assignment4Console.exe");
        }

        private void btnSearchAss5_Click(object sender, EventArgs e)
        {
            string no = txtBoxNbr.Text;
            dataGridViewAss5.Columns.Clear();
            if (controller.SearchEmployeeAss5(no).Rows.Count == 0)
            {
                labelMessageAss5.Text = "Employee could not be found";
            }
            else
            {
                dataGridViewAss5.DataSource = controller.SearchEmployeeAss5(no);
            }
            clearFieldsAss5();
        }

        private void btnAddAss5_Click(object sender, EventArgs e)
        {
            string no = txtBoxNbr.Text;
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            string jobTitle = txtBoxJob.Text;
            string email = txtBoxEmail.Text;
            if (string.Empty.Equals(no) || string.Empty.Equals(firstName) || string.Empty.Equals(lastName) || string.Empty.Equals(jobTitle) || string.Empty.Equals(email))
            {
                labelMessageAss5.Text = "Please fill out all text fields";
            }
            else
            {
                labelMessageAss5.Text = controller.AddEmployeeAss5(no, firstName, lastName, jobTitle, email);
                clearFieldsAss5();
            }
            
        }

        private void btnUpdateAss5_Click(object sender, EventArgs e)
        {
            string no = txtBoxNbr.Text;
            string firstName = txtBoxFirstName.Text;
            string lastName = txtBoxLastName.Text;
            string jobTitle = txtBoxJob.Text;
            string email = txtBoxEmail.Text;
            if (string.Empty.Equals(no) || string.Empty.Equals(firstName) || string.Empty.Equals(lastName) || string.Empty.Equals(jobTitle) || string.Empty.Equals(email))
            {
                labelMessageAss5.Text = "Please fill out all text fields";
            }
            else
            {
                labelMessageAss5.Text = controller.UpdateEmployeeAss5(no, firstName, lastName, jobTitle, email);
                clearFieldsAss5();
            }
            
        }

        private void btnDeleteAss5_Click(object sender, EventArgs e)
        {
            string no = txtBoxNbr.Text;
            labelMessageAss5.Text = controller.RemoveEmployeeAss5(no);
            clearFieldsAss5();
        }

        private void clearFieldsAss5()
        {
            txtBoxNbr.Text = "";
            txtBoxFirstName.Text = "";
            txtBoxLastName.Text = "";
            txtBoxJob.Text = "";
            txtBoxEmail.Text = "";
        }

        private void btnJavaAss5_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Desktop\\Assignment5Java.jar");
        }

        private void btnShowAss6_Click(object sender, EventArgs e)
        {
            
            if (comboBoxAss6.SelectedIndex == 0) //GetAllKeys
            {
                dataGridViewAss6.DataSource = controller.GetAllKeys();
            }
            else if (comboBoxAss6.SelectedIndex == 1) //GetAllConstraints
            {
                dataGridViewAss6.DataSource = controller.GetAllTableConstraints();
            }
            else if (comboBoxAss6.SelectedIndex == 2) //GetAllTables1
            {
                dataGridViewAss6.DataSource = controller.GetAllTablesDB1();
            }
            else if (comboBoxAss6.SelectedIndex == 3) //GetAllTables1
            {
                dataGridViewAss6.DataSource = controller.GetAllTablesDB2();
            }
            else if (comboBoxAss6.SelectedIndex == 4) //GetAllColumnsFromEmp1
            {
                dataGridViewAss6.DataSource = controller.GetAllColumnsFromEmp1();
            }
            else if (comboBoxAss6.SelectedIndex == 5) //GetAllColumnsFromEmp2
            {
                dataGridViewAss6.DataSource = controller.GetAllColumnsFromEmp2();
            }
            else if (comboBoxAss6.SelectedIndex == 6) //GetMostSickEmployee
            {
                dataGridViewAss6.DataSource = controller.GetNameAbsentMost();
            }
            else if (comboBoxAss6.SelectedIndex == 7) //GetAllAbsense2004
            {
                dataGridViewAss6.DataSource = controller.GetInfoEmpSickness2004();
            }
            else if (comboBoxAss6.SelectedIndex == 8) //GetAllIndexes
            {
                dataGridViewAss6.DataSource = controller.GetAllIndexes();
            }
            else if (comboBoxAss6.SelectedIndex == 9) //GetInformationAboutEmployeeAndRelatives
            {
                dataGridViewAss6.DataSource = controller.GetInfoFromEmpAndRelatives();
            }
            else if (comboBoxAss6.SelectedIndex == 10) //GetMetaDataFromEmpAndRelated
            {
                dataGridViewAss6.DataSource = controller.GetMetaDataFromEmpAndRelated();
            }



        }

        private void btnJavaAss6_Click(object sender, EventArgs e)
        {
            Process.Start("C:\\Users\\Administrator\\Desktop\\Assignment6Java.jar");
        }
    }
}
