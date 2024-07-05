namespace AutoRechner
{
    partial class EditCar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditCar));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.textBoxModel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buyDateTime = new System.Windows.Forms.DateTimePicker();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listBoxRecommend = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = Properties.GUIStrings.LabelBrand;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = Properties.GUIStrings.LabelModel;
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Location = new System.Drawing.Point(77, 6);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(207, 20);
            this.textBoxBrand.TabIndex = 0;
            this.textBoxBrand.TextChanged += new System.EventHandler(this.TextBoxBrand_TextChanged);
            this.textBoxBrand.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxBrand_KeyDown);
            this.textBoxBrand.Leave += new System.EventHandler(this.TextBoxBrand_Leave);
            // 
            // textBoxModel
            // 
            this.textBoxModel.Location = new System.Drawing.Point(77, 32);
            this.textBoxModel.Name = "textBoxModel";
            this.textBoxModel.Size = new System.Drawing.Size(207, 20);
            this.textBoxModel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = Properties.GUIStrings.LabelDate;
            // 
            // buyDateTime
            // 
            this.buyDateTime.Location = new System.Drawing.Point(77, 84);
            this.buyDateTime.Name = "buyDateTime";
            this.buyDateTime.Size = new System.Drawing.Size(207, 20);
            this.buyDateTime.TabIndex = 3;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(14, 110);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(130, 23);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = Properties.GUIStrings.ButtonSave;
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonSave.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSave.Location = new System.Drawing.Point(154, 110);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(130, 23);
            this.buttonSave.TabIndex = 5;
            this.buttonSave.Text = Properties.GUIStrings.ButtonSave;
            this.buttonSave.UseVisualStyleBackColor = true;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(77, 58);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(207, 20);
            this.textBoxComment.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 61);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = Properties.GUIStrings.LabelComment;
            // 
            // listBoxRecommend
            // 
            this.listBoxRecommend.FormattingEnabled = true;
            this.listBoxRecommend.Location = new System.Drawing.Point(77, 25);
            this.listBoxRecommend.Name = "listBoxRecommend";
            this.listBoxRecommend.Size = new System.Drawing.Size(207, 43);
            this.listBoxRecommend.TabIndex = 19;
            this.listBoxRecommend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListBoxRecommend_KeyDown);
            this.listBoxRecommend.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListBoxRecommend_MouseDoubleClick);
            // 
            // EditCar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.buttonSave;
            this.ClientSize = new System.Drawing.Size(296, 145);
            this.Controls.Add(this.listBoxRecommend);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buyDateTime);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxModel);
            this.Controls.Add(this.textBoxBrand);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EditCar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = string.Empty;
            this.Load += new System.EventHandler(this.EditCar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TextBox textBoxModel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker buyDateTime;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox listBoxRecommend;
    }
}