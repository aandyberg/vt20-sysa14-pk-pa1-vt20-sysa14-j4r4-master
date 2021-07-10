namespace DesktopApp1
{
    partial class AllInfoFormCar
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
            this.textBoxNbr = new System.Windows.Forms.TextBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelNbr = new System.Windows.Forms.Label();
            this.labelNameBrand = new System.Windows.Forms.Label();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxOwner = new System.Windows.Forms.TextBox();
            this.labelOwnerInfo = new System.Windows.Forms.Label();
            this.labelOwnerName = new System.Windows.Forms.Label();
            this.btnRemoveOwner = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxNbr
            // 
            this.textBoxNbr.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxNbr.Location = new System.Drawing.Point(93, 27);
            this.textBoxNbr.MaxLength = 6;
            this.textBoxNbr.Name = "textBoxNbr";
            this.textBoxNbr.Size = new System.Drawing.Size(187, 20);
            this.textBoxNbr.TabIndex = 1;
            this.textBoxNbr.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbr_KeyPress);
            // 
            // textBoxName
            // 
            this.textBoxName.BackColor = System.Drawing.SystemColors.Info;
            this.textBoxName.Location = new System.Drawing.Point(93, 67);
            this.textBoxName.MaxLength = 100;
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.ReadOnly = true;
            this.textBoxName.Size = new System.Drawing.Size(187, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(93, 161);
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
            this.labelNbr.Size = new System.Drawing.Size(64, 13);
            this.labelNbr.TabIndex = 5;
            this.labelNbr.Text = "Regnummer";
            // 
            // labelNameBrand
            // 
            this.labelNameBrand.AutoSize = true;
            this.labelNameBrand.Location = new System.Drawing.Point(9, 67);
            this.labelNameBrand.Name = "labelNameBrand";
            this.labelNameBrand.Size = new System.Drawing.Size(37, 13);
            this.labelNameBrand.TabIndex = 6;
            this.labelNameBrand.Text = "Märke";
            // 
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Location = new System.Drawing.Point(9, 135);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(77, 13);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "Personnummer";
            // 
            // textBoxOwner
            // 
            this.textBoxOwner.Location = new System.Drawing.Point(93, 135);
            this.textBoxOwner.MaxLength = 10;
            this.textBoxOwner.Name = "textBoxOwner";
            this.textBoxOwner.Size = new System.Drawing.Size(187, 20);
            this.textBoxOwner.TabIndex = 3;
            this.textBoxOwner.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxOwner_KeyPress);
            // 
            // labelOwnerInfo
            // 
            this.labelOwnerInfo.AutoSize = true;
            this.labelOwnerInfo.Location = new System.Drawing.Point(9, 104);
            this.labelOwnerInfo.Name = "labelOwnerInfo";
            this.labelOwnerInfo.Size = new System.Drawing.Size(76, 13);
            this.labelOwnerInfo.TabIndex = 8;
            this.labelOwnerInfo.Text = "Registrerad på";
            // 
            // labelOwnerName
            // 
            this.labelOwnerName.AutoSize = true;
            this.labelOwnerName.Location = new System.Drawing.Point(90, 104);
            this.labelOwnerName.Name = "labelOwnerName";
            this.labelOwnerName.Size = new System.Drawing.Size(86, 13);
            this.labelOwnerName.TabIndex = 9;
            this.labelOwnerName.Text = "Ingen registrerad";
            // 
            // btnRemoveOwner
            // 
            this.btnRemoveOwner.BackColor = System.Drawing.Color.Red;
            this.btnRemoveOwner.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRemoveOwner.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveOwner.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveOwner.Location = new System.Drawing.Point(257, 99);
            this.btnRemoveOwner.Name = "btnRemoveOwner";
            this.btnRemoveOwner.Size = new System.Drawing.Size(23, 23);
            this.btnRemoveOwner.TabIndex = 10;
            this.btnRemoveOwner.Text = "X";
            this.btnRemoveOwner.UseVisualStyleBackColor = false;
            this.btnRemoveOwner.Visible = false;
            this.btnRemoveOwner.Click += new System.EventHandler(this.btnRemoveOwner_Click);
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(192, 161);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "Ta bort bil";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AllInfoFormCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(372, 213);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnRemoveOwner);
            this.Controls.Add(this.labelOwnerName);
            this.Controls.Add(this.labelOwnerInfo);
            this.Controls.Add(this.labelEmail);
            this.Controls.Add(this.labelNameBrand);
            this.Controls.Add(this.labelNbr);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.textBoxOwner);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.textBoxNbr);
            this.Name = "AllInfoFormCar";
            this.Text = "AllInfoFormCar";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.TextBox textBoxNbr;
        public System.Windows.Forms.TextBox textBoxName;
        public System.Windows.Forms.Label labelNbr;
        public System.Windows.Forms.Label labelNameBrand;
        public System.Windows.Forms.Label labelEmail;
        public System.Windows.Forms.TextBox textBoxOwner;
        private System.Windows.Forms.Label labelOwnerInfo;
        public System.Windows.Forms.Label labelOwnerName;
        public System.Windows.Forms.Button btnRemoveOwner;
        private System.Windows.Forms.Button button1;
    }
}