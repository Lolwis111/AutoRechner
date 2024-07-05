namespace AutoRechner
{
    partial class MainForm
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
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Globalization", "CA1303:Do not pass literals as localized parameters", MessageId = "System.Windows.Forms.ToolStripItem.set_Text(System.String)")]
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageSpendings = new System.Windows.Forms.TabPage();
            this.listViewLoss = new System.Windows.Forms.ListView();
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripCostSum = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.addlossItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editLossItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteLossItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabPageProfit = new System.Windows.Forms.TabPage();
            this.buttonSavePayments = new System.Windows.Forms.Button();
            this.textBoxTotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxPersonRest = new System.Windows.Forms.ComboBox();
            this.comboBoxPersonAnzahlung = new System.Windows.Forms.ComboBox();
            this.TextBoxPayment = new System.Windows.Forms.TextBox();
            this.TextBoxDownPayment = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPageConculsion = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.listViewPayPerPerson = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label4 = new System.Windows.Forms.Label();
            this.listViewWinPerPerson = new System.Windows.Forms.ListView();
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label5 = new System.Windows.Forms.Label();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusLabelWin = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.optionenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RecalculateMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BackHomeMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ViewMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenPayMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenWinMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenResultMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.GraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpendingsPerPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ProfitPerPersonMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain.SuspendLayout();
            this.tabPageSpendings.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.tabPageProfit.SuspendLayout();
            this.tabPageConculsion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageSpendings);
            this.tabControlMain.Controls.Add(this.tabPageProfit);
            this.tabControlMain.Controls.Add(this.tabPageConculsion);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 24);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1419, 555);
            this.tabControlMain.TabIndex = 2;
            // 
            // tabPageSpendings
            // 
            this.tabPageSpendings.Controls.Add(this.listViewLoss);
            this.tabPageSpendings.Controls.Add(this.statusStrip1);
            this.tabPageSpendings.Controls.Add(this.menuStrip2);
            this.tabPageSpendings.Location = new System.Drawing.Point(4, 22);
            this.tabPageSpendings.Name = "tabPageSpendings";
            this.tabPageSpendings.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSpendings.Size = new System.Drawing.Size(1411, 529);
            this.tabPageSpendings.TabIndex = 0;
            this.tabPageSpendings.Text = global::AutoRechner.Properties.GUIStrings.Spendings;
            this.tabPageSpendings.UseVisualStyleBackColor = true;
            // 
            // listViewLoss
            // 
            this.listViewLoss.BackColor = System.Drawing.SystemColors.Window;
            this.listViewLoss.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader6,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader9});
            this.listViewLoss.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewLoss.ForeColor = System.Drawing.SystemColors.WindowText;
            this.listViewLoss.FullRowSelect = true;
            this.listViewLoss.GridLines = true;
            this.listViewLoss.HideSelection = false;
            this.listViewLoss.Location = new System.Drawing.Point(3, 27);
            this.listViewLoss.MultiSelect = false;
            this.listViewLoss.Name = "listViewLoss";
            this.listViewLoss.Size = new System.Drawing.Size(1405, 477);
            this.listViewLoss.TabIndex = 3;
            this.listViewLoss.UseCompatibleStateImageBehavior = false;
            this.listViewLoss.View = System.Windows.Forms.View.Details;
            this.listViewLoss.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.ListViewLoss_ColumnClick);
            this.listViewLoss.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ListViewLoss_KeyDown);
            this.listViewLoss.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ListViewLoss_MouseDoubleClick);
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = global::AutoRechner.Properties.GUIStrings.LabelID;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = global::AutoRechner.Properties.GUIStrings.LabelBrand;
            this.columnHeader1.Width = 108;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = global::AutoRechner.Properties.GUIStrings.LabelModel;
            this.columnHeader2.Width = 111;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = global::AutoRechner.Properties.GUIStrings.LabelPosition;
            this.columnHeader3.Width = 504;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = global::AutoRechner.Properties.GUIStrings.LabelPrice;
            this.columnHeader4.Width = 136;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = global::AutoRechner.Properties.GUIStrings.LabelPerson;
            this.columnHeader5.Width = 137;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = global::AutoRechner.Properties.GUIStrings.LabelInclude;
            this.columnHeader9.Width = 185;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripCostSum});
            this.statusStrip1.Location = new System.Drawing.Point(3, 504);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1405, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = string.Empty;
            // 
            // toolStripCostSum
            // 
            this.toolStripCostSum.Name = "toolStripCostSum";
            this.toolStripCostSum.Size = new System.Drawing.Size(84, 17);
            this.toolStripCostSum.Text = string.Format("{1}: {0:C}", 0, Properties.GUIStrings.LabelSum);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addlossItem,
            this.editLossItem,
            this.deleteLossItem});
            this.menuStrip2.Location = new System.Drawing.Point(3, 3);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1405, 24);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = string.Empty;
            // 
            // addlossItem
            // 
            this.addlossItem.Name = "addlossItem";
            this.addlossItem.Size = new System.Drawing.Size(66, 20);
            this.addlossItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonInsert;
            this.addlossItem.Click += new System.EventHandler(this.AddlossItem_Click);
            // 
            // editLossItem
            // 
            this.editLossItem.Name = "editLossItem";
            this.editLossItem.Size = new System.Drawing.Size(75, 20);
            this.editLossItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonEdit;
            this.editLossItem.Click += new System.EventHandler(this.EditLossItem_Click);
            // 
            // deleteLossItem
            // 
            this.deleteLossItem.Name = "deleteLossItem";
            this.deleteLossItem.Size = new System.Drawing.Size(63, 20);
            this.deleteLossItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonDelete;
            this.deleteLossItem.Click += new System.EventHandler(this.DeleteLossItem_Click);
            // 
            // tabPageProfit
            // 
            this.tabPageProfit.Controls.Add(this.buttonSavePayments);
            this.tabPageProfit.Controls.Add(this.textBoxTotal);
            this.tabPageProfit.Controls.Add(this.label3);
            this.tabPageProfit.Controls.Add(this.comboBoxPersonRest);
            this.tabPageProfit.Controls.Add(this.comboBoxPersonAnzahlung);
            this.tabPageProfit.Controls.Add(this.TextBoxPayment);
            this.tabPageProfit.Controls.Add(this.TextBoxDownPayment);
            this.tabPageProfit.Controls.Add(this.label2);
            this.tabPageProfit.Controls.Add(this.label1);
            this.tabPageProfit.Location = new System.Drawing.Point(4, 22);
            this.tabPageProfit.Name = "tabPageProfit";
            this.tabPageProfit.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProfit.Size = new System.Drawing.Size(1411, 529);
            this.tabPageProfit.TabIndex = 1;
            this.tabPageProfit.Text = global::AutoRechner.Properties.GUIStrings.LabelProfit;
            this.tabPageProfit.UseVisualStyleBackColor = true;
            // 
            // buttonSavePayments
            // 
            this.buttonSavePayments.Location = new System.Drawing.Point(9, 97);
            this.buttonSavePayments.Name = "buttonSavePayments";
            this.buttonSavePayments.Size = new System.Drawing.Size(318, 23);
            this.buttonSavePayments.TabIndex = 8;
            this.buttonSavePayments.Text = global::AutoRechner.Properties.GUIStrings.ButtonSave;
            this.buttonSavePayments.UseVisualStyleBackColor = true;
            this.buttonSavePayments.Click += new System.EventHandler(this.ButtonSavePayments_Click);
            // 
            // textBoxTotal
            // 
            this.textBoxTotal.Location = new System.Drawing.Point(100, 60);
            this.textBoxTotal.Name = "textBoxTotal";
            this.textBoxTotal.ReadOnly = true;
            this.textBoxTotal.Size = new System.Drawing.Size(100, 20);
            this.textBoxTotal.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(38, 61);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = Properties.GUIStrings.LabelSum;
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // comboBoxPersonRest
            // 
            this.comboBoxPersonRest.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonRest.FormattingEnabled = true;
            this.comboBoxPersonRest.Location = new System.Drawing.Point(206, 34);
            this.comboBoxPersonRest.Name = "comboBoxPersonRest";
            this.comboBoxPersonRest.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersonRest.TabIndex = 3;
            this.comboBoxPersonRest.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPersonRest_SelectedIndexChanged);
            // 
            // comboBoxPersonAnzahlung
            // 
            this.comboBoxPersonAnzahlung.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPersonAnzahlung.FormattingEnabled = true;
            this.comboBoxPersonAnzahlung.Location = new System.Drawing.Point(206, 8);
            this.comboBoxPersonAnzahlung.Name = "comboBoxPersonAnzahlung";
            this.comboBoxPersonAnzahlung.Size = new System.Drawing.Size(121, 21);
            this.comboBoxPersonAnzahlung.TabIndex = 1;
            this.comboBoxPersonAnzahlung.SelectedIndexChanged += new System.EventHandler(this.ComboBoxPersonAnzahlung_SelectedIndexChanged);
            // 
            // TextBoxPayment
            // 
            this.TextBoxPayment.Location = new System.Drawing.Point(100, 34);
            this.TextBoxPayment.Name = "TextBoxPayment";
            this.TextBoxPayment.Size = new System.Drawing.Size(100, 20);
            this.TextBoxPayment.TabIndex = 2;
            this.TextBoxPayment.Text = 0.ToString("0.00");
            this.TextBoxPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxRest_KeyDown);
            this.TextBoxPayment.Leave += new System.EventHandler(this.TextBoxRest_Leave);
            // 
            // TextBoxDownPayment
            // 
            this.TextBoxDownPayment.Location = new System.Drawing.Point(100, 8);
            this.TextBoxDownPayment.Name = "TextBoxDownPayment";
            this.TextBoxDownPayment.Size = new System.Drawing.Size(100, 20);
            this.TextBoxDownPayment.TabIndex = 0;
            this.TextBoxDownPayment.Text = 0.ToString("0.00");
            this.TextBoxDownPayment.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TextBoxAnzahlung_KeyDown);
            this.TextBoxDownPayment.Leave += new System.EventHandler(this.TextBoxAnzahlung_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = Properties.GUIStrings.LabelRestPayment;
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = Properties.GUIStrings.LabelDownPayment;
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // tabPageConculsion
            // 
            this.tabPageConculsion.Controls.Add(this.splitContainer1);
            this.tabPageConculsion.Controls.Add(this.statusStrip2);
            this.tabPageConculsion.Location = new System.Drawing.Point(4, 22);
            this.tabPageConculsion.Name = "tabPageConculsion";
            this.tabPageConculsion.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageConculsion.Size = new System.Drawing.Size(1411, 529);
            this.tabPageConculsion.TabIndex = 2;
            this.tabPageConculsion.Text = global::AutoRechner.Properties.GUIStrings.Conclusion;
            this.tabPageConculsion.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.listViewPayPerPerson);
            this.splitContainer1.Panel1.Controls.Add(this.label4);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.listViewWinPerPerson);
            this.splitContainer1.Panel2.Controls.Add(this.label5);
            this.splitContainer1.Size = new System.Drawing.Size(1405, 498);
            this.splitContainer1.SplitterDistance = 566;
            this.splitContainer1.TabIndex = 2;
            // 
            // listViewPayPerPerson
            // 
            this.listViewPayPerPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8});
            this.listViewPayPerPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewPayPerPerson.HideSelection = false;
            this.listViewPayPerPerson.Location = new System.Drawing.Point(0, 22);
            this.listViewPayPerPerson.Name = "listViewPayPerPerson";
            this.listViewPayPerPerson.Size = new System.Drawing.Size(566, 476);
            this.listViewPayPerPerson.TabIndex = 2;
            this.listViewPayPerPerson.UseCompatibleStateImageBehavior = false;
            this.listViewPayPerPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = global::AutoRechner.Properties.GUIStrings.LabelPerson;
            this.columnHeader7.Width = 185;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = global::AutoRechner.Properties.GUIStrings.LabelSum;
            this.columnHeader8.Width = 110;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.label4.Size = new System.Drawing.Size(142, 22);
            this.label4.TabIndex = 1;
            this.label4.Text = Properties.GUIStrings.SpendingPerPerson;
            // 
            // listViewWinPerPerson
            // 
            this.listViewWinPerPerson.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader11,
            this.columnHeader12,
            this.columnHeader10});
            this.listViewWinPerPerson.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewWinPerPerson.HideSelection = false;
            this.listViewWinPerPerson.Location = new System.Drawing.Point(0, 22);
            this.listViewWinPerPerson.Name = "listViewWinPerPerson";
            this.listViewWinPerPerson.Size = new System.Drawing.Size(835, 476);
            this.listViewWinPerPerson.TabIndex = 3;
            this.listViewWinPerPerson.UseCompatibleStateImageBehavior = false;
            this.listViewWinPerPerson.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = global::AutoRechner.Properties.GUIStrings.LabelPerson;
            this.columnHeader11.Width = 185;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = global::AutoRechner.Properties.GUIStrings.LabelTotal;
            this.columnHeader12.Width = 110;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = global::AutoRechner.Properties.GUIStrings.LabelWin;
            this.columnHeader10.Width = 186;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Top;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(3);
            this.label5.Size = new System.Drawing.Size(162, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = Properties.GUIStrings.PayoutPerPerson;
            // 
            // statusStrip2
            // 
            this.statusStrip2.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.statusLabelWin});
            this.statusStrip2.Location = new System.Drawing.Point(3, 3);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Size = new System.Drawing.Size(1405, 25);
            this.statusStrip2.TabIndex = 0;
            this.statusStrip2.Text = string.Empty;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(58, 20);
            this.toolStripStatusLabel1.Text = global::AutoRechner.Properties.GUIStrings.LabelWin;
            // 
            // statusLabelWin
            // 
            this.statusLabelWin.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabelWin.Name = "statusLabelWin";
            this.statusLabelWin.Size = new System.Drawing.Size(36, 20);
            this.statusLabelWin.Text = 0.ToString("0.00");
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionenToolStripMenuItem,
            this.ViewMenuItem,
            this.HelpMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1419, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = string.Empty;
            // 
            // optionenToolStripMenuItem
            // 
            this.optionenToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RecalculateMenuItem,
            this.BackHomeMenuItem});
            this.optionenToolStripMenuItem.Name = "optionenToolStripMenuItem";
            this.optionenToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.optionenToolStripMenuItem.Text = global::AutoRechner.Properties.GUIStrings.MenuOptions;
            // 
            // RecalculateMenuItem
            // 
            this.RecalculateMenuItem.Name = "RecalculateMenuItem";
            this.RecalculateMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
            this.RecalculateMenuItem.Size = new System.Drawing.Size(196, 22);
            this.RecalculateMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonRecalculate;
            this.RecalculateMenuItem.Click += new System.EventHandler(this.RecalculateMenuItem_Click);
            // 
            // BackHomeMenuItem
            // 
            this.BackHomeMenuItem.Name = "BackHomeMenuItem";
            this.BackHomeMenuItem.Size = new System.Drawing.Size(196, 22);
            this.BackHomeMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonBackToOverview;
            this.BackHomeMenuItem.Click += new System.EventHandler(this.BackHomeMenuItem_Click);
            // 
            // ViewMenuItem
            // 
            this.ViewMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenPayMenuItem,
            this.OpenWinMenuItem,
            this.OpenResultMenuItem,
            this.GraphMenuItem});
            this.ViewMenuItem.Name = "ViewMenuItem";
            this.ViewMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ViewMenuItem.Text = global::AutoRechner.Properties.GUIStrings.MenuView;
            // 
            // OpenPayMenuItem
            // 
            this.OpenPayMenuItem.Name = "OpenPayMenuItem";
            this.OpenPayMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.OpenPayMenuItem.Size = new System.Drawing.Size(215, 22);
            this.OpenPayMenuItem.Text = global::AutoRechner.Properties.GUIStrings.Spendings;
            this.OpenPayMenuItem.Click += new System.EventHandler(this.OpenPayMenuItem_Click);
            // 
            // OpenWinMenuItem
            // 
            this.OpenWinMenuItem.Name = "OpenWinMenuItem";
            this.OpenWinMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.OpenWinMenuItem.Size = new System.Drawing.Size(215, 22);
            this.OpenWinMenuItem.Text = global::AutoRechner.Properties.GUIStrings.LabelProfit;
            this.OpenWinMenuItem.Click += new System.EventHandler(this.OpenWinMenuItem_Click);
            // 
            // OpenResultMenuItem
            // 
            this.OpenResultMenuItem.Name = "OpenResultMenuItem";
            this.OpenResultMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.OpenResultMenuItem.Size = new System.Drawing.Size(215, 22);
            this.OpenResultMenuItem.Text = global::AutoRechner.Properties.GUIStrings.Conclusion;
            this.OpenResultMenuItem.Click += new System.EventHandler(this.OpenResultMenuItem_Click);
            // 
            // GraphMenuItem
            // 
            this.GraphMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpendingsPerPersonMenuItem,
            this.ProfitPerPersonMenuItem});
            this.GraphMenuItem.Name = "GraphMenuItem";
            this.GraphMenuItem.Size = new System.Drawing.Size(215, 22);
            this.GraphMenuItem.Text = global::AutoRechner.Properties.GUIStrings.TitleGraph;
            // 
            // SpendingsPerPersonMenuItem
            // 
            this.SpendingsPerPersonMenuItem.Name = "SpendingsPerPersonMenuItem";
            this.SpendingsPerPersonMenuItem.Size = new System.Drawing.Size(208, 22);
            this.SpendingsPerPersonMenuItem.Text = global::AutoRechner.Properties.GUIStrings.SpendingPerPerson;
            this.SpendingsPerPersonMenuItem.Click += new System.EventHandler(this.AusgabenProPersonToolStripMenuItem_Click);
            // 
            // ProfitPerPersonMenuItem
            // 
            this.ProfitPerPersonMenuItem.Name = "ProfitPerPersonMenuItem";
            this.ProfitPerPersonMenuItem.Size = new System.Drawing.Size(208, 22);
            this.ProfitPerPersonMenuItem.Text = global::AutoRechner.Properties.GUIStrings.PayoutPerPerson;
            this.ProfitPerPersonMenuItem.Click += new System.EventHandler(this.AusschüttungProPersonToolStripMenuItem_Click);
            // 
            // HelpMenuItem
            // 
            this.HelpMenuItem.Name = "HelpMenuItem";
            this.HelpMenuItem.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuItem.Text = global::AutoRechner.Properties.GUIStrings.ButtonHelp;
            this.HelpMenuItem.Click += new System.EventHandler(this.HilfeToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1419, 579);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = string.Empty;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPageSpendings.ResumeLayout(false);
            this.tabPageSpendings.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.tabPageProfit.ResumeLayout(false);
            this.tabPageProfit.PerformLayout();
            this.tabPageConculsion.ResumeLayout(false);
            this.tabPageConculsion.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageSpendings;
        private System.Windows.Forms.ListView listViewLoss;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripCostSum;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem addlossItem;
        private System.Windows.Forms.ToolStripMenuItem editLossItem;
        private System.Windows.Forms.ToolStripMenuItem deleteLossItem;
        private System.Windows.Forms.TabPage tabPageProfit;
        private System.Windows.Forms.TextBox textBoxTotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxPersonRest;
        private System.Windows.Forms.ComboBox comboBoxPersonAnzahlung;
        private System.Windows.Forms.TextBox TextBoxPayment;
        private System.Windows.Forms.TextBox TextBoxDownPayment;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPageConculsion;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ListView listViewPayPerPerson;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListView listViewWinPerPerson;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelWin;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button buttonSavePayments;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ToolStripMenuItem optionenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RecalculateMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ViewMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenPayMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenWinMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenResultMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BackHomeMenuItem;
        private System.Windows.Forms.ToolStripMenuItem GraphMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpendingsPerPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ProfitPerPersonMenuItem;
        private System.Windows.Forms.ToolStripMenuItem HelpMenuItem;
    }
}

