namespace AutoRechner.Settings
{
    partial class SettingsEditorWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsEditorWindow));
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.buttonDeleteUser = new System.Windows.Forms.Button();
            this.listBoxUsers = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.SaveSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.radioButtonInclude2 = new System.Windows.Forms.RadioButton();
            this.radioButtonInclude1 = new System.Windows.Forms.RadioButton();
            this.buttonAddPart = new System.Windows.Forms.Button();
            this.listBoxParts = new System.Windows.Forms.ListBox();
            this.textBoxPart = new System.Windows.Forms.TextBox();
            this.buttonDeletePart = new System.Windows.Forms.Button();
            this.buttonAddBrand = new System.Windows.Forms.Button();
            this.listBoxBrands = new System.Windows.Forms.ListBox();
            this.buttonDeleteBrand = new System.Windows.Forms.Button();
            this.textBoxBrand = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.Location = new System.Drawing.Point(6, 162);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(196, 23);
            this.buttonAddUser.TabIndex = 3;
            this.buttonAddUser.Text = global::AutoRechner.Properties.GUIStrings.ButtonAddUser;
            this.buttonAddUser.UseVisualStyleBackColor = true;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(6, 136);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(196, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // buttonDeleteUser
            // 
            this.buttonDeleteUser.Location = new System.Drawing.Point(6, 107);
            this.buttonDeleteUser.Name = "buttonDeleteUser";
            this.buttonDeleteUser.Size = new System.Drawing.Size(196, 23);
            this.buttonDeleteUser.TabIndex = 1;
            this.buttonDeleteUser.Text = global::AutoRechner.Properties.GUIStrings.ButtonDeleteUser;
            this.buttonDeleteUser.UseVisualStyleBackColor = true;
            this.buttonDeleteUser.Click += new System.EventHandler(this.buttonDeleteUser_Click);
            // 
            // listBoxUsers
            // 
            this.listBoxUsers.FormattingEnabled = true;
            this.listBoxUsers.Location = new System.Drawing.Point(6, 6);
            this.listBoxUsers.Name = "listBoxUsers";
            this.listBoxUsers.Size = new System.Drawing.Size(196, 95);
            this.listBoxUsers.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveSettingsMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // SaveSettingsMenuItem
            // 
            this.SaveSettingsMenuItem.Name = "SaveSettingsMenuItem";
            this.SaveSettingsMenuItem.Size = new System.Drawing.Size(144, 20);
            this.SaveSettingsMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonSaveAndClose;
            this.SaveSettingsMenuItem.Click += new System.EventHandler(this.SaveSettingsMenuItem_Click);
            // 
            // radioButtonInclude2
            // 
            this.radioButtonInclude2.AutoSize = true;
            this.radioButtonInclude2.Location = new System.Drawing.Point(6, 29);
            this.radioButtonInclude2.Name = "radioButtonInclude2";
            this.radioButtonInclude2.Size = new System.Drawing.Size(115, 17);
            this.radioButtonInclude2.TabIndex = 2;
            this.radioButtonInclude2.TabStop = true;
            this.radioButtonInclude2.Text = global::AutoRechner.Properties.GUIStrings.LabelNotInclude;
            this.radioButtonInclude2.UseVisualStyleBackColor = true;
            // 
            // radioButtonInclude1
            // 
            this.radioButtonInclude1.AutoSize = true;
            this.radioButtonInclude1.Location = new System.Drawing.Point(6, 6);
            this.radioButtonInclude1.Name = "radioButtonInclude1";
            this.radioButtonInclude1.Size = new System.Drawing.Size(91, 17);
            this.radioButtonInclude1.TabIndex = 1;
            this.radioButtonInclude1.TabStop = true;
            this.radioButtonInclude1.Text = global::AutoRechner.Properties.GUIStrings.LabelInclude;
            this.radioButtonInclude1.UseVisualStyleBackColor = true;
            // 
            // buttonAddPart
            // 
            this.buttonAddPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddPart.Location = new System.Drawing.Point(6, 320);
            this.buttonAddPart.Name = "buttonAddPart";
            this.buttonAddPart.Size = new System.Drawing.Size(476, 23);
            this.buttonAddPart.TabIndex = 7;
            this.buttonAddPart.Text = global::AutoRechner.Properties.GUIStrings.ButtonAddPart;
            this.buttonAddPart.UseVisualStyleBackColor = true;
            this.buttonAddPart.Click += new System.EventHandler(this.ButtonAddPart_Click);
            // 
            // listBoxParts
            // 
            this.listBoxParts.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxParts.FormattingEnabled = true;
            this.listBoxParts.Location = new System.Drawing.Point(6, 6);
            this.listBoxParts.Name = "listBoxParts";
            this.listBoxParts.Size = new System.Drawing.Size(476, 238);
            this.listBoxParts.TabIndex = 4;
            // 
            // textBoxPart
            // 
            this.textBoxPart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxPart.Location = new System.Drawing.Point(6, 294);
            this.textBoxPart.Name = "textBoxPart";
            this.textBoxPart.Size = new System.Drawing.Size(476, 20);
            this.textBoxPart.TabIndex = 6;
            // 
            // buttonDeletePart
            // 
            this.buttonDeletePart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeletePart.Location = new System.Drawing.Point(6, 265);
            this.buttonDeletePart.Name = "buttonDeletePart";
            this.buttonDeletePart.Size = new System.Drawing.Size(476, 23);
            this.buttonDeletePart.TabIndex = 5;
            this.buttonDeletePart.Text = global::AutoRechner.Properties.GUIStrings.ButtonDeletePart;
            this.buttonDeletePart.UseVisualStyleBackColor = true;
            this.buttonDeletePart.Click += new System.EventHandler(this.buttonDeletePart_Click);
            // 
            // buttonAddBrand
            // 
            this.buttonAddBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddBrand.Location = new System.Drawing.Point(6, 322);
            this.buttonAddBrand.Name = "buttonAddBrand";
            this.buttonAddBrand.Size = new System.Drawing.Size(478, 23);
            this.buttonAddBrand.TabIndex = 11;
            this.buttonAddBrand.Text = global::AutoRechner.Properties.GUIStrings.ButtonAddBrand;
            this.buttonAddBrand.UseVisualStyleBackColor = true;
            this.buttonAddBrand.Click += new System.EventHandler(this.ButtonAddBrand_Click);
            // 
            // listBoxBrands
            // 
            this.listBoxBrands.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listBoxBrands.FormattingEnabled = true;
            this.listBoxBrands.Location = new System.Drawing.Point(6, 6);
            this.listBoxBrands.Name = "listBoxBrands";
            this.listBoxBrands.Size = new System.Drawing.Size(478, 251);
            this.listBoxBrands.TabIndex = 8;
            // 
            // buttonDeleteBrand
            // 
            this.buttonDeleteBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonDeleteBrand.Location = new System.Drawing.Point(6, 267);
            this.buttonDeleteBrand.Name = "buttonDeleteBrand";
            this.buttonDeleteBrand.Size = new System.Drawing.Size(478, 23);
            this.buttonDeleteBrand.TabIndex = 9;
            this.buttonDeleteBrand.Text = global::AutoRechner.Properties.GUIStrings.ButtonDeleteBrand;
            this.buttonDeleteBrand.UseVisualStyleBackColor = true;
            this.buttonDeleteBrand.Click += new System.EventHandler(this.ButtonDeleteBrand_Click);
            // 
            // textBoxBrand
            // 
            this.textBoxBrand.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxBrand.Location = new System.Drawing.Point(6, 296);
            this.textBoxBrand.Name = "textBoxBrand";
            this.textBoxBrand.Size = new System.Drawing.Size(478, 20);
            this.textBoxBrand.TabIndex = 10;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(498, 377);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonAddPart);
            this.tabPage1.Controls.Add(this.listBoxParts);
            this.tabPage1.Controls.Add(this.textBoxPart);
            this.tabPage1.Controls.Add(this.buttonDeletePart);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(490, 351);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Teile";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonAddBrand);
            this.tabPage2.Controls.Add(this.listBoxBrands);
            this.tabPage2.Controls.Add(this.buttonDeleteBrand);
            this.tabPage2.Controls.Add(this.textBoxBrand);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(490, 351);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Marken";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonAddUser);
            this.tabPage3.Controls.Add(this.textBoxUsername);
            this.tabPage3.Controls.Add(this.listBoxUsers);
            this.tabPage3.Controls.Add(this.buttonDeleteUser);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(490, 351);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Benutzer";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radioButtonInclude2);
            this.tabPage4.Controls.Add(this.radioButtonInclude1);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(490, 351);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Berechnung";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // SettingsEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 401);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsEditorWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Einstellungen";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ListBox listBoxUsers;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Button buttonDeleteUser;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem SaveSettingsMenuItem;
        private System.Windows.Forms.RadioButton radioButtonInclude2;
        private System.Windows.Forms.RadioButton radioButtonInclude1;
        private System.Windows.Forms.Button buttonAddPart;
        private System.Windows.Forms.ListBox listBoxParts;
        private System.Windows.Forms.TextBox textBoxPart;
        private System.Windows.Forms.Button buttonDeletePart;
        private System.Windows.Forms.Button buttonAddBrand;
        private System.Windows.Forms.ListBox listBoxBrands;
        private System.Windows.Forms.Button buttonDeleteBrand;
        private System.Windows.Forms.TextBox textBoxBrand;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
    }
}