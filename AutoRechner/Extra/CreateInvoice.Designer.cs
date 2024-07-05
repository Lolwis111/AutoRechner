namespace AutoRechner.Extra
{
    partial class CreateInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateInvoice));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxZipCode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxTown = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxStreet = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.includeTax = new System.Windows.Forms.CheckBox();
            this.buttonCreateInvoice = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(63, 6);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(211, 20);
            this.textBoxName.TabIndex = 1;
            // 
            // textBoxZipCode
            // 
            this.textBoxZipCode.Location = new System.Drawing.Point(63, 58);
            this.textBoxZipCode.Name = "textBoxZipCode";
            this.textBoxZipCode.Size = new System.Drawing.Size(37, 20);
            this.textBoxZipCode.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "PLZ";
            // 
            // textBoxTown
            // 
            this.textBoxTown.Location = new System.Drawing.Point(133, 58);
            this.textBoxTown.Name = "textBoxTown";
            this.textBoxTown.Size = new System.Drawing.Size(141, 20);
            this.textBoxTown.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(106, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ort";
            // 
            // textBoxStreet
            // 
            this.textBoxStreet.Location = new System.Drawing.Point(63, 32);
            this.textBoxStreet.Name = "textBoxStreet";
            this.textBoxStreet.Size = new System.Drawing.Size(211, 20);
            this.textBoxStreet.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Straße";
            // 
            // includeTax
            // 
            this.includeTax.AutoSize = true;
            this.includeTax.Location = new System.Drawing.Point(194, 93);
            this.includeTax.Name = "includeTax";
            this.includeTax.Size = new System.Drawing.Size(80, 17);
            this.includeTax.TabIndex = 8;
            this.includeTax.Text = "19% Steuer";
            this.includeTax.UseVisualStyleBackColor = true;
            // 
            // buttonCreateInvoice
            // 
            this.buttonCreateInvoice.Location = new System.Drawing.Point(12, 116);
            this.buttonCreateInvoice.Name = "buttonCreateInvoice";
            this.buttonCreateInvoice.Size = new System.Drawing.Size(262, 23);
            this.buttonCreateInvoice.TabIndex = 9;
            this.buttonCreateInvoice.Text = "Rechnung speichern";
            this.buttonCreateInvoice.UseVisualStyleBackColor = true;
            this.buttonCreateInvoice.Click += new System.EventHandler(this.ButtonCreateInvoice_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(12, 145);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(262, 23);
            this.buttonCancel.TabIndex = 10;
            this.buttonCancel.Text = "Abbrechen";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // CreateInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(295, 184);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonCreateInvoice);
            this.Controls.Add(this.includeTax);
            this.Controls.Add(this.textBoxStreet);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxTown);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxZipCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CreateInvoice";
            this.Text = "Rechnung erstellen";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxZipCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxTown;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxStreet;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox includeTax;
        private System.Windows.Forms.Button buttonCreateInvoice;
        private System.Windows.Forms.Button buttonCancel;
    }
}