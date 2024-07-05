namespace AutoRechner
{
    partial class Stats
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Stats));
            this.listViewStats = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // listViewStats
            // 
            this.listViewStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.listViewStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewStats.Location = new System.Drawing.Point(0, 0);
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(1100, 509);
            this.listViewStats.TabIndex = 1;
            this.listViewStats.UseCompatibleStateImageBehavior = false;
            this.listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = Properties.GUIStrings.LabelKey;
            this.columnHeader1.Width = 274;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = Properties.GUIStrings.LabelValue;
            this.columnHeader2.Width = 339;
            // 
            // Stats
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 509);
            this.Controls.Add(this.listViewStats);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Stats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = Properties.GUIStrings.TitleStats;
            this.Load += new System.EventHandler(this.Stats_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView listViewStats;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}