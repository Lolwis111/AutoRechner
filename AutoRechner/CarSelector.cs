using AutoRechner.Edit;
using AutoRechner.Extra;
using AutoRechner.Settings;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Threading;
using System.Globalization;

namespace AutoRechner
{
    public partial class CarSelector : Form
    {
        private List<Car> cars_ = new List<Car>();
        private SettingsManager settings_ = new SettingsManager();

        private PartList partList_ = new PartList();
        private BrandList brandList_ = new BrandList();

        private ListViewColumnSorter lvwColumnSorter_;
        private List<ToolStripMenuItem> languageMenuItems_ = new List<ToolStripMenuItem>();

        public CarSelector()
        {
            Init();
        }

        private void Init()
        {
            Controls.Clear();
            InitializeComponent();

            lvwColumnSorter_ = new ListViewColumnSorter();
            listViewCars.ListViewItemSorter = lvwColumnSorter_;

            settings_ = IsolatedDiskStorage.LoadSettings();

            
            foreach(CultureInfo cultureInfo in LanguageSelection.GetSupportedCulture())
            {
                ToolStripMenuItem toolStripMenuItem = new ToolStripMenuItem($"{cultureInfo.DisplayName} | {cultureInfo.TwoLetterISOLanguageName}");

                toolStripMenuItem.Click += ToolStripMenuItem_Click;

                languageMenuItems_.Add(toolStripMenuItem);                
            }

            LanguageMenuItem.DropDownItems.AddRange(languageMenuItems_.ToArray());
        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem button = (ToolStripMenuItem)sender;
            ChangeLanguage(button.Text.Split('|')[1].Trim());
        }

        private void CarSelector_Load(object sender, EventArgs e)
        {
            cars_ = IsolatedDiskStorage.LoadCars();

            int i = 0;
            foreach(Car c in cars_)
            {
                if (!settings_.Users.Contains(c.DownPaymentPerson))
                {
                    settings_.Users.Add(c.DownPaymentPerson);
                    i++;
                }

                if (!settings_.Users.Contains(c.PaymentPerson))
                {
                    settings_.Users.Add(c.PaymentPerson);
                    i++;
                }

                foreach (Item item in c.Costs)
                {
                    if(!settings_.Users.Contains(item.Person))
                    {
                        settings_.Users.Add(item.Person);
                        i++;
                    }
                }
            }

            if(i > 0)
            {
                MessageBox.Show($"{i} {Properties.GUIStrings.LabelAddedUser}",
                    Properties.GUIStrings.Warning, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            LoadCars();

            if (settings_.Users.Count == 1 && settings_.Users[0] == Properties.Resources.UserNone)
            {
                DialogResult res = MessageBox.Show(
                    Properties.GUIStrings.NoUsersWarning, 
                    Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if(res == DialogResult.Yes)
                {
                    SettingsEditorWindow se = new SettingsEditorWindow(settings_, partList_, brandList_);
                    se.ShowDialog();
                }
            }

            if (settings_.SortByColumnCarSelect != -1)
            {
                SortByColumn(settings_.SortByColumnCarSelect);
            }
        }

        private void CarSelector_FormClosing(object sender, FormClosingEventArgs e)
        {
            IsolatedDiskStorage.SaveCars(cars_);
            IsolatedDiskStorage.SaveSettings(settings_);
            brandList_.Save();
        }

        #region Listview

        private void ListViewCars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                EditCar();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteCar();
            }
        }

        private void ListViewCars_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortByColumn(e.Column);
            settings_.SortByColumnCarSelect = e.Column;
        }

        private void ListViewCars_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditCar();
        }

        #endregion

        #region toolstrip

        private void LoadCarMenuItem_Click(object sender, EventArgs e)
        {
            EditCar();
        }

        private void InfoMenuItem_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }

        private void StatsMenuItem_Click(object sender, EventArgs e)
        {
            Stats stats = new Stats(cars_);
            stats.ShowDialog();
        }

        private void ReloadDBMenuItem_Click(object sender, EventArgs e)
        {
            cars_ = IsolatedDiskStorage.LoadCars();

            LoadCars();
        }

        private void SaveDBMenuItem_Click(object sender, EventArgs e)
        {
            IsolatedDiskStorage.SaveCars(cars_);
        }

        private void ClearDBMenuItem_Click(object sender, EventArgs e)
        {
            ClearData cd = new ClearData();
            if(cd.ShowDialog() == DialogResult.OK)
            {
                cars_ = new List<Car>();
                IsolatedDiskStorage.SaveCars(cars_);
                LoadCars();
            }
        }

        private void EditEntryMenuItem_Click(object sender, EventArgs e)
        {
            EditEntry();
        }

        private void einstellungenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SettingsEditorWindow se = new SettingsEditorWindow(settings_, partList_, brandList_);
            se.ShowDialog();
        }

        private void exportierenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { CheckPathExists = true, Filter =$"{Properties.GUIStrings.DatabaseExportFilter}|*.xml" })
            {
                if(sfd.ShowDialog() == DialogResult.OK)
                {
                    IsolatedDiskStorage.ExporCars(cars_, sfd.FileName);
                }
            }
        }

        private void neuesAutoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewCar();
        }

        private void beendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(Properties.GUIStrings.ConfirmExit, Properties.GUIStrings.Warning, 
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Close();
            }
        }

        private void HelpMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow hw = new HelpWindow();
            hw.Show();
        }

        private void löschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DeleteCar();
        }

        #endregion

        #region Util functions

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.N))
            {
                AddNewCar();
            }
            else if (keyData == (Keys.Control | Keys.L))
            {
                EditCar();
            }
            else if (keyData == (Keys.Control | Keys.B))
            {
                EditEntry();
            }
            else if (keyData == (Keys.Control | Keys.S))
            {
                IsolatedDiskStorage.SaveCars(cars_);
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                cars_ = IsolatedDiskStorage.LoadCars();

                LoadCars();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void DeleteCar()
        {
            if (listViewCars.SelectedIndices.Count <= 0)
            {
                MessageBox.Show(Properties.GUIStrings.NoCarSelected, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listViewCars.SelectedItems[0].SubItems[0].Text);

            Car car = cars_.Find(c => c.ID == id);

            if (MessageBox.Show(string.Format(Properties.GUIStrings.FormatConfirmDelete, $"{car.Brand} {car.Model}"), Properties.GUIStrings.LabelDelete,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                cars_.Remove(car);
                LoadCars();
            }
        }

        private void LoadCars()
        {
            listViewCars.Items.Clear();

            foreach (Car c in cars_)
            {
                ListViewItem lvi = new ListViewItem(c.ID.ToString());
                lvi.SubItems.Add(c.Brand);
                lvi.SubItems.Add(c.Model);
                lvi.SubItems.Add(c.Comment);
                lvi.SubItems.Add(string.Format("{0:C}", c.TotalCost));
                lvi.SubItems.Add(string.Format("{0:C}", c.SellPrice));
                lvi.SubItems.Add(string.Format("{0:C}", c.Win));
                lvi.SubItems.Add(c.BuyDate.ToShortDateString());

                listViewCars.Items.Add(lvi);
            }
        }

        private void EditCar()
        {
            if (listViewCars.SelectedIndices.Count <= 0)
            {
                MessageBox.Show(Properties.GUIStrings.NoCarSelected, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listViewCars.SelectedItems[0].SubItems[0].Text);

            Car car = cars_.Find(c => c.ID == id);

            Hide();
            MainForm mf = new MainForm(car, settings_, partList_);
            mf.ShowDialog();
            Show();

            LoadCars();
        }

        private void AddNewCar()
        {
            Car newCar = new Car() { ID = cars_.Count };

            EditCar nc = new EditCar(newCar, brandList_);

            if (nc.ShowDialog() == DialogResult.OK)
            {
                cars_.Add(newCar);
                LoadCars();
            }
        }

        private void EditEntry()
        {
            if (listViewCars.SelectedIndices.Count <= 0)
            {
                MessageBox.Show(Properties.GUIStrings.NoCarSelected, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listViewCars.SelectedItems[0].SubItems[0].Text);

            Car car = cars_.Find(c => c.ID == id);

            EditCar nc = new EditCar(car, brandList_);

            if (nc.ShowDialog() == DialogResult.OK)
            {
                LoadCars();
            }
        }

        private void SortByColumn(int column)
        {
            if (column == lvwColumnSorter_.SortColumn)
            {
                if (lvwColumnSorter_.Order == SortOrder.Ascending)
                {
                    lvwColumnSorter_.Order = SortOrder.Descending;
                }
                else
                {
                    lvwColumnSorter_.Order = SortOrder.Ascending;
                }
            }
            else
            {
                lvwColumnSorter_.SortColumn = column;
                lvwColumnSorter_.Order = SortOrder.Ascending;
            }

            listViewCars.Sort();
        }

        #endregion


        private void ChangeLanguage(string language)
        {
            Thread.CurrentThread.CurrentUICulture = CultureInfo.GetCultureInfo(language);

            Init();
            LoadCars();
        }

        private void rechnungToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listViewCars.SelectedIndices.Count <= 0)
            {
                MessageBox.Show(Properties.GUIStrings.NoCarSelected, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int id = int.Parse(listViewCars.SelectedItems[0].SubItems[0].Text);

            Car car = cars_.Find(c => c.ID == id);

            CreateInvoice createInvoice = new CreateInvoice(settings_, car);
            createInvoice.ShowDialog();
                
        }
    }
}
