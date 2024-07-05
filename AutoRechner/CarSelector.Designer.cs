namespace AutoRechner
{
    partial class CarSelector
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarSelector));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.CarMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExtraMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.StatisticsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.AboutMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LanguageMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DataBaseMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReloadDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExportDBMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listViewCars = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.rechnungToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CarMenu,
            this.ExtraMenuItem,
            this.DataBaseMenuItem,
            this.HelpMenuItem,
            this.ExitMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1164, 24);
            this.menuStrip1.TabIndex = 1;
            // 
            // CarMenu
            // 
            this.CarMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuItem,
            this.LoadMenuItem,
            this.EditMenuItem,
            this.DeleteMenuItem,
            this.rechnungToolStripMenuItem});
            this.CarMenu.Name = "CarMenu";
            this.CarMenu.Size = new System.Drawing.Size(45, 20);
            this.CarMenu.Text = global::AutoRechner.Properties.GUIStrings.ButtonCar;
            // 
            // NewMenuItem
            // 
            this.NewMenuItem.Name = "NewMenuItem";
            this.NewMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuItem.Size = new System.Drawing.Size(180, 22);
            this.NewMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonNew;
            this.NewMenuItem.Click += new System.EventHandler(this.neuesAutoToolStripMenuItem_Click);
            // 
            // LoadMenuItem
            // 
            this.LoadMenuItem.Name = "LoadMenuItem";
            this.LoadMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.LoadMenuItem.Size = new System.Drawing.Size(180, 22);
            this.LoadMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonLoad;
            this.LoadMenuItem.Click += new System.EventHandler(this.LoadCarMenuItem_Click);
            // 
            // EditMenuItem
            // 
            this.EditMenuItem.Name = "EditMenuItem";
            this.EditMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.EditMenuItem.Size = new System.Drawing.Size(180, 22);
            this.EditMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonEdit;
            this.EditMenuItem.Click += new System.EventHandler(this.EditEntryMenuItem_Click);
            // 
            // DeleteMenuItem
            // 
            this.DeleteMenuItem.Name = "DeleteMenuItem";
            this.DeleteMenuItem.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this.DeleteMenuItem.Size = new System.Drawing.Size(180, 22);
            this.DeleteMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonDelete;
            this.DeleteMenuItem.Click += new System.EventHandler(this.löschenToolStripMenuItem_Click);
            // 
            // ExtraMenuItem
            // 
            this.ExtraMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.StatisticsMenuItem,
            this.SettingsMenuItem,
            this.toolStripSeparator1,
            this.AboutMenuItem,
            this.LanguageMenuItem});
            this.ExtraMenuItem.Name = "ExtraMenuItem";
            this.ExtraMenuItem.Size = new System.Drawing.Size(45, 20);
            this.ExtraMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonExtra;
            // 
            // StatisticsMenuItem
            // 
            this.StatisticsMenuItem.Name = "StatisticsMenuItem";
            this.StatisticsMenuItem.Size = new System.Drawing.Size(145, 22);
            this.StatisticsMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonStats;
            this.StatisticsMenuItem.Click += new System.EventHandler(this.StatsMenuItem_Click);
            // 
            // SettingsMenuItem
            // 
            this.SettingsMenuItem.Name = "SettingsMenuItem";
            this.SettingsMenuItem.Size = new System.Drawing.Size(145, 22);
            this.SettingsMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonSettings;
            this.SettingsMenuItem.Click += new System.EventHandler(this.einstellungenToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(142, 6);
            // 
            // AboutMenuItem
            // 
            this.AboutMenuItem.Name = "AboutMenuItem";
            this.AboutMenuItem.Size = new System.Drawing.Size(145, 22);
            this.AboutMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonAbout;
            this.AboutMenuItem.Click += new System.EventHandler(this.InfoMenuItem_Click);
            // 
            // LanguageMenuItem
            // 
            this.LanguageMenuItem.Name = "LanguageMenuItem";
            this.LanguageMenuItem.Size = new System.Drawing.Size(145, 22);
            this.LanguageMenuItem.Text = global::AutoRechner.Properties.GUIStrings.LabelLanguage;
            // 
            // DataBaseMenuItem
            // 
            this.DataBaseMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadDBMenuItem,
            this.SaveDBMenuItem,
            this.ClearDBMenuItem,
            this.ExportDBMenuItem});
            this.DataBaseMenuItem.Name = "DataBaseMenuItem";
            this.DataBaseMenuItem.Size = new System.Drawing.Size(76, 20);
            this.DataBaseMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonDatabase;
            // 
            // ReloadDBMenuItem
            // 
            this.ReloadDBMenuItem.Name = "ReloadDBMenuItem";
            this.ReloadDBMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.ReloadDBMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ReloadDBMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonReload;
            this.ReloadDBMenuItem.Click += new System.EventHandler(this.ReloadDBMenuItem_Click);
            // 
            // SaveDBMenuItem
            // 
            this.SaveDBMenuItem.Name = "SaveDBMenuItem";
            this.SaveDBMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveDBMenuItem.Size = new System.Drawing.Size(169, 22);
            this.SaveDBMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonSave;
            this.SaveDBMenuItem.Click += new System.EventHandler(this.SaveDBMenuItem_Click);
            // 
            // ClearDBMenuItem
            // 
            this.ClearDBMenuItem.Name = "ClearDBMenuItem";
            this.ClearDBMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ClearDBMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonClear;
            this.ClearDBMenuItem.Click += new System.EventHandler(this.ClearDBMenuItem_Click);
            // 
            // ExportDBMenuItem
            // 
            this.ExportDBMenuItem.Name = "ExportDBMenuItem";
            this.ExportDBMenuItem.Size = new System.Drawing.Size(169, 22);
            this.ExportDBMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonExport;
            this.ExportDBMenuItem.Click += new System.EventHandler(this.exportierenToolStripMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonHelp;
            this.HelpMenuItem.Click += new System.EventHandler(this.HelpMenuItem_Click);
            // 
            // ExitMenuItem
            // 
            this.ExitMenuItem.Name = "ExitMenuItem";
            this.ExitMenuItem.Size = new System.Drawing.Size(65, 20);
            this.ExitMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonExit;
            this.ExitMenuItem.Click += new System.EventHandler(this.beendenToolStripMenuItem_Click);
            // 
            // listViewCars
            // 
            this.listViewCars.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader10,
            this.columnHeader13,
            this.columnHeader2,
            this.columnHeader14,
            this.columnHeader15,
            this.columnHeader16,
            this.columnHeader17});
            this.listViewCars.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewCars.FullRowSelect = true;
            this.listViewCars.HideSelection = false;
            this.listViewCars.Location = new System.Drawing.Point(0, 24);
            this.listViewCars.MultiSelect = false;
            this.listViewCars.Name = "listViewCars";
            this.listViewCars.Size = new System.Drawing.Size(1164, 515);
            this.listViewCars.TabIndex = 2;
            this.listViewCars.UseCompatibleStateImageBehavior = false;
            this.listViewCars.View = System.Windows.Forms.View.Details;
            this.listViewCars.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewCars_ColumnClick);
            this.listViewCars.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewCars_KeyDown);
            this.listViewCars.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewCars_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = global::AutoRechner.Properties.GUIStrings.LabelID;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = global::AutoRechner.Properties.GUIStrings.LabelBrand;
            this.columnHeader10.Width = 86;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = global::AutoRechner.Properties.GUIStrings.LabelModel;
            this.columnHeader13.Width = 98;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = global::AutoRechner.Properties.GUIStrings.LabelComment;
            this.columnHeader2.Width = 200;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = global::AutoRechner.Properties.GUIStrings.LabelCost;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = global::AutoRechner.Properties.GUIStrings.LabelProfit;
            this.columnHeader15.Width = 111;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = global::AutoRechner.Properties.GUIStrings.LabelWin;
            this.columnHeader16.Width = 104;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = global::AutoRechner.Properties.GUIStrings.LabelDate;
            this.columnHeader17.Width = 154;
            // 
            // rechnungToolStripMenuItem
            // 
            this.rechnungToolStripMenuItem.Name = "rechnungToolStripMenuItem";
            this.rechnungToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rechnungToolStripMenuItem.Text = "Rechnung";
            this.rechnungToolStripMenuItem.Click += new System.EventHandler(this.rechnungToolStripMenuItem_Click);
            // 
            // CarSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 539);
            this.Controls.Add(this.listViewCars);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CarSelector";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AutoRechner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CarSelector_FormClosing);
            this.Load += new System.EventHandler(this.CarSelector_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ListView listViewCars;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ToolStripMenuItem ExtraMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutMenuItem;
        private System.Windows.Forms.ToolStripMenuItem StatisticsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DataBaseMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReloadDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SaveDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ClearDBMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ToolStripMenuItem CarMenu;
        private System.Windows.Forms.ToolStripMenuItem NewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SettingsMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExportDBMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ExitMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeleteMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LanguageMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rechnungToolStripMenuItem;
    }
}