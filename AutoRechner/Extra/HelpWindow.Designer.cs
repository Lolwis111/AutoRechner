namespace AutoRechner.Extra
{
    partial class HelpWindow
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelPosition);
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelPrice);
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelPerson);
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelInclude);
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelInclude, new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelBrand);
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelModel);
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelComment);
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelDate);
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelCar, new System.Windows.Forms.TreeNode[] {
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode(Properties.GUIStrings.LabelPayout);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelpWindow));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.rtbHelp = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rtbHelp);
            this.splitContainer1.Size = new System.Drawing.Size(646, 311);
            this.splitContainer1.SplitterDistance = 215;
            this.splitContainer1.TabIndex = 0;
            // 
            // treeView1
            // 
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.Name = "Node2";
            treeNode1.Text = Properties.GUIStrings.LabelPosition;
            treeNode2.Name = "Node3";
            treeNode2.Text = Properties.GUIStrings.LabelPrice;
            treeNode3.Name = "Node4";
            treeNode3.Text = Properties.GUIStrings.LabelPerson;
            treeNode4.Name = "Node6";
            treeNode4.Text = Properties.GUIStrings.LabelInclude;
            treeNode5.Name = "Node0";
            treeNode5.Text = Properties.GUIStrings.LabelEntry;
            treeNode6.Name = "Node1";
            treeNode6.Text = Properties.GUIStrings.LabelBrand;
            treeNode7.Name = "Node2";
            treeNode7.Text = Properties.GUIStrings.LabelModel;
            treeNode8.Name = "Node3";
            treeNode8.Text = Properties.GUIStrings.LabelComment;
            treeNode9.Name = "Node4";
            treeNode9.Text = Properties.GUIStrings.LabelDate;
            treeNode10.Name = "Node0";
            treeNode10.Text = Properties.GUIStrings.LabelCar;
            treeNode11.Name = "Node0";
            treeNode11.Text = Properties.GUIStrings.LabelPayout;
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode10,
            treeNode11});
            this.treeView1.Size = new System.Drawing.Size(215, 311);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.TreeView1_AfterSelect);
            // 
            // rtbHelp
            // 
            this.rtbHelp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbHelp.Location = new System.Drawing.Point(0, 0);
            this.rtbHelp.Name = "rtbHelp";
            this.rtbHelp.ReadOnly = true;
            this.rtbHelp.Size = new System.Drawing.Size(427, 311);
            this.rtbHelp.TabIndex = 0;
            this.rtbHelp.Text = "";
            // 
            // HelpWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 311);
            this.Controls.Add(this.splitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "HelpWindow";
            this.Text = "AutoRechner - Hilfe";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.RichTextBox rtbHelp;
    }
}