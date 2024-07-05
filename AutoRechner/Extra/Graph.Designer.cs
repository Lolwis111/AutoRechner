namespace AutoRechner
{
    partial class Graph
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
            this.panelRender = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // panelRender
            // 
            this.panelRender.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelRender.Location = new System.Drawing.Point(0, 0);
            this.panelRender.Name = "panelRender";
            this.panelRender.Size = new System.Drawing.Size(284, 261);
            this.panelRender.TabIndex = 0;
            this.panelRender.Paint += new System.Windows.Forms.PaintEventHandler(this.panelRender_Paint);
            // 
            // Diagramm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.panelRender);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "Graph";
            this.Text = Properties.GUIStrings.TitleGraph;
            this.Resize += new System.EventHandler(this.Diagramm_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelRender;
    }
}