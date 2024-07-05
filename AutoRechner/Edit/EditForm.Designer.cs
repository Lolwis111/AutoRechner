namespace AutoRechner
{
    partial class EditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditForm));
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxPerson = new System.Windows.Forms.ComboBox();
            this.textBoxPreis = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.checkBoxPart = new System.Windows.Forms.CheckBox();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.listBoxRecommend = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = Properties.GUIStrings.LabelPosition;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = Properties.GUIStrings.LabelPrice;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = Properties.GUIStrings.LabelPerson;
            // 
            // comboBoxPerson
            // 
            this.comboBoxPerson.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPerson.FormattingEnabled = true;
            this.comboBoxPerson.Location = new System.Drawing.Point(60, 65);
            this.comboBoxPerson.Name = "comboBoxPerson";
            this.comboBoxPerson.Size = new System.Drawing.Size(172, 21);
            this.comboBoxPerson.TabIndex = 2;
            // 
            // textBoxPreis
            // 
            this.textBoxPreis.Location = new System.Drawing.Point(60, 39);
            this.textBoxPreis.Name = "textBoxPreis";
            this.textBoxPreis.Size = new System.Drawing.Size(172, 20);
            this.textBoxPreis.TabIndex = 1;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(10, 117);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(108, 23);
            this.buttonSave.TabIndex = 4;
            this.buttonSave.Text = Properties.GUIStrings.ButtonSave;
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonCancel.Location = new System.Drawing.Point(124, 117);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(108, 23);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = Properties.GUIStrings.ButtonCancel;
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // checkBoxPart
            // 
            this.checkBoxPart.AutoSize = true;
            this.checkBoxPart.Location = new System.Drawing.Point(60, 94);
            this.checkBoxPart.Name = "checkBoxPart";
            this.checkBoxPart.Size = new System.Drawing.Size(92, 17);
            this.checkBoxPart.TabIndex = 3;
            this.checkBoxPart.Text = Properties.GUIStrings.LabelInclude;
            this.checkBoxPart.UseVisualStyleBackColor = true;
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(60, 13);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(172, 20);
            this.textBoxPosition.TabIndex = 0;
            this.textBoxPosition.TextChanged += new System.EventHandler(this.TextBoxPosition_TextChanged);
            this.textBoxPosition.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxPosition_KeyDown);
            this.textBoxPosition.Leave += new System.EventHandler(this.TextBoxPosition_Leave);
            // 
            // listBoxRecommend
            // 
            this.listBoxRecommend.FormattingEnabled = true;
            this.listBoxRecommend.Location = new System.Drawing.Point(60, 32);
            this.listBoxRecommend.Name = "listBoxRecommend";
            this.listBoxRecommend.Size = new System.Drawing.Size(172, 43);
            this.listBoxRecommend.TabIndex = 18;
            this.listBoxRecommend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxRecommend_KeyDown);
            this.listBoxRecommend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxRecommend_MouseDoubleClick);
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonCancel;
            this.ClientSize = new System.Drawing.Size(242, 152);
            this.Controls.Add(this.listBoxRecommend);
            this.Controls.Add(this.textBoxPosition);
            this.Controls.Add(this.checkBoxPart);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.textBoxPreis);
            this.Controls.Add(this.comboBoxPerson);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Properties.GUIStrings.TitleEditEntry;
            this.HelpButtonClicked += new System.ComponentModel.CancelEventHandler(this.EditForm_HelpButtonClicked);
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxPerson;
        private System.Windows.Forms.TextBox textBoxPreis;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.CheckBox checkBoxPart;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.ListBox listBoxRecommend;
    }
}