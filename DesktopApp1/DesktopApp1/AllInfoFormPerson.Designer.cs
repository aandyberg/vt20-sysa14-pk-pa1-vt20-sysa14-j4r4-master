namespace DesktopApp1
{
    partial class AllInfoFormPerson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridViewCars = new System.Windows.Forms.DataGridView();
            this.textBoxNbr = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelNbr = new System.Windows.Forms.Label();
            this.labelNameBrand = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.btnDeletePerson = new System.Windows.Forms.Button();
            this.btnAddCar = new System.Windows.Forms.Button();
            this.btnRemoveCar = new System.Windows.Forms.Button();
            this.labelCurrentCars = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewCars
            // 
            this.dataGridViewCars.AllowUserToAddRows = false;
            this.dataGridViewCars.AllowUserToOrderColumns = true;
            this.dataGridViewCars.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCars.Location = new System.Drawing.Point(12, 224);
            this.dataGridViewCars.MultiSelect = false;
            this.dataGridViewCars.Name = "dataGridViewCars";
            this.dataGridViewCars.ReadOnly = true;
            this.dataGridViewCars.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCars.Size = new System.Drawing.Size(348, 165);
            this.dataGridViewCars.TabIndex = 0;
            this.dataGridViewCars.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCars_CellDoubleClick);
            // 
            // textBoxNbr
            // 
            this.textBoxNbr.BackColor = System.Drawing.SystemColors.Control;
            this.textBoxNbr.Location = new System.Drawing.Point(93, 27);
            this.textBoxNbr.MaxLength = 10;
            this.textBoxNbr.Name = "textBoxNbr";
            this.textBoxNbr.Size = new System.Drawing.Size(187, 20);
            this.textBoxNbr.TabIndex = 1;
            this.textBoxNbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbr_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(93, 67);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 2;
            this.textBoxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxName_KeyPress);
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(93, 105);
            this.textBoxEmail.MaxLength = 100;
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(187, 20);
            this.textBoxEmail.TabIndex = 3;
            this.textBoxEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEmail_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 141);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(81, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Spara";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelNbr
            // 
            this.labelNbr.AutoSize = true;
            this.labelNbr.Location = new System.Drawing.Point(9, 30);
            this.labelNbr.Name = "labelNbr";
            this.labelNbr.Size = new System.Drawing.Size(77, 13);
            this.labelNbr.TabIndex = 5;
            this.labelNbr.Text = "Personnummer";
            // 
            // labelNameBrand
            // 
            this.labelNameBrand.AutoSize = true;
            this.labelNameBrand.Location = new System.Drawing.Point(9, 67);
            this.labelNameBrand.Name = "labelNameBrand";
            this.labelNameBrand.Size = new System.Drawing.Size(35, 13);
            this.labelNameBrand.TabIndex = 6;
            this.labelNameBrand.Text = "Namn";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 105);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(32, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Email";
            // 
            // btnDeletePerson
            // 
            this.btnDeletePerson.ForeColor = System.Drawing.Color.Red;
            this.btnDeletePerson.Location = new System.Drawing.Point(195, 141);
            this.btnDeletePerson.Name = "btnDeletePerson";
            this.btnDeletePerson.Size = new System.Drawing.Size(85, 23);
            this.btnDeletePerson.TabIndex = 8;
            this.btnDeletePerson.Text = "Ta bort person";
            this.btnDeletePerson.UseVisualStyleBackColor = true;
            this.btnDeletePerson.Click += new System.EventHandler(this.btnDeletePerson_Click);
            // 
            // btnAddCar
            // 
            this.btnAddCar.Location = new System.Drawing.Point(195, 395);
            this.btnAddCar.Name = "btnAddCar";
            this.btnAddCar.Size = new System.Drawing.Size(75, 23);
            this.btnAddCar.TabIndex = 9;
            this.btnAddCar.Text = "Lägg till";
            this.btnAddCar.UseVisualStyleBackColor = true;
            this.btnAddCar.Click += new System.EventHandler(this.btnAddCar_Click);
            // 
            // btnRemoveCar
            // 
            this.btnRemoveCar.ForeColor = System.Drawing.Color.Red;
            this.btnRemoveCar.Location = new System.Drawing.Point(285, 395);
            this.btnRemoveCar.Name = "btnRemoveCar";
            this.btnRemoveCar.Size = new System.Drawing.Size(75, 23);
            this.btnRemoveCar.TabIndex = 10;
            this.btnRemoveCar.Text = "Ta bort";
            this.btnRemoveCar.UseVisualStyleBackColor = true;
            this.btnRemoveCar.Click += new System.EventHandler(this.btnRemoveCar_Click);
            // 
            // labelCurrentCars
            // 
            this.labelCurrentCars.AutoSize = true;
            this.labelCurrentCars.Location = new System.Drawing.Point(12, 208);
            this.labelCurrentCars.Name = "labelCurrentCars";
            this.labelCurrentCars.Size = new System.Drawing.Size(89, 13);
            this.labelCurrentCars.TabIndex = 11;
            this.labelCurrentCars.Text = "Registrerade bilar";
            // 
            // AllInfoFormPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 449);
            this.Controls.Add(this.labelCurrentCars);
            this.Controls.Add(this.btnRemoveCar);
            this.Controls.Add(this.btnAddCar);
            this.Controls.Add(this.btnDeletePerson);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNameBrand);
            this.Controls.Add(this.labelNbr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNbr);
            this.Controls.Add(this.dataGridViewCars);
            this.Name = "AllInfoFormPerson";
            this.Text = "AllInfoFormPerson";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCars)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox textBoxNbr;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.TextBox textBoxEmail;
        public System.Windows.Forms.Label labelNbr;
        public System.Windows.Forms.Label labelNameBrand;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.DataGridView dataGridViewCars;
        private System.Windows.Forms.Button btnDeletePerson;
        private System.Windows.Forms.Button btnAddCar;
        private System.Windows.Forms.Button btnRemoveCar;
        private System.Windows.Forms.Label labelCurrentCars;
    }
}