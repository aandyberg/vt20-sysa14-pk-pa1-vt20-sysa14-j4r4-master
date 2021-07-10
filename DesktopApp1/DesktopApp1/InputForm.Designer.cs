namespace DesktopApp1
{
    partial class InputForm
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
            this.textBoxUserInput = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.labelLicenseNbr = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxUserInput
            // 
            this.textBoxUserInput.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBoxUserInput.Location = new System.Drawing.Point(49, 27);
            this.textBoxUserInput.MaxLength = 6;
            this.textBoxUserInput.Name = "textBoxUserInput";
            this.textBoxUserInput.Size = new System.Drawing.Size(122, 20);
            this.textBoxUserInput.TabIndex = 0;
            this.textBoxUserInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNbr_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(59, 53);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 22);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Lägg till";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // labelLicenseNbr
            // 
            this.labelLicenseNbr.AutoSize = true;
            this.labelLicenseNbr.Location = new System.Drawing.Point(56, 9);
            this.labelLicenseNbr.Name = "labelLicenseNbr";
            this.labelLicenseNbr.Size = new System.Drawing.Size(105, 13);
            this.labelLicenseNbr.TabIndex = 2;
            this.labelLicenseNbr.Text = "Registreringsnummer";
            // 
            // InputForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(217, 98);
            this.Controls.Add(this.labelLicenseNbr);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.textBoxUserInput);
            this.Name = "InputForm";
            this.Text = "Lägg till bil";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxUserInput;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labelLicenseNbr;
    }
}