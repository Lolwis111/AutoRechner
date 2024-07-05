using AutoRechner.Edit;
using AutoRechner.Extra;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace AutoRechner
{
    public partial class MainForm : Form
    {
        private Car currentCar_ = null;
        private ListViewColumnSorter lvwColumnSorter_;

        private PartList partList_;
        private SettingsManager settings_;

        private Graph diagramCost_ = new Graph(Properties.GUIStrings.SpendingPerPerson);
        private Graph diagramWin_ = new Graph(Properties.GUIStrings.PayoutPerPerson);

        public MainForm(Car car, SettingsManager settings, PartList partList)
        {
            InitializeComponent();
            currentCar_ = car;

            lvwColumnSorter_ = new ListViewColumnSorter();
            listViewLoss.ListViewItemSorter = lvwColumnSorter_;

            settings_ = settings;
            partList_ = partList;
            
            if(settings.SortByColumnItemSelect != -1)
            {
                SortByColumn(settings.SortByColumnItemSelect);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Text = $"{currentCar_.Brand} {currentCar_.Model} ({currentCar_.Comment})";

            LoadCosts();
            Calculate();

            comboBoxPersonAnzahlung.Items.Clear();
            comboBoxPersonRest.Items.Clear();

            foreach (string user in settings_.Users)
            {
                if (user != Properties.Resources.UserNone)
                {
                    comboBoxPersonAnzahlung.Items.Add(user);
                    comboBoxPersonRest.Items.Add(user);
                }
            }

            for (int i = 0; i < comboBoxPersonAnzahlung.Items.Count; i++)
            {
                if (comboBoxPersonAnzahlung.Items[i].ToString() == currentCar_.DownPaymentPerson)
                {
                    comboBoxPersonAnzahlung.SelectedIndex = i;
                    break;
                }
            }

            for (int i = 0; i < comboBoxPersonRest.Items.Count; i++)
            {
                if (comboBoxPersonRest.Items[i].ToString() == currentCar_.PaymentPerson)
                {
                    comboBoxPersonRest.SelectedIndex = i;
                    break;
                }
            }

            TextBoxDownPayment.Text = currentCar_.DownPayment.ToString("0.00");
            TextBoxPayment.Text = currentCar_.Payment.ToString("0.00");

            listViewLoss.Select();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            partList_.Save();
        }

        #region Utils

        private void AddEntry()
        {
            Item newItem = new Item(currentCar_.Costs.Count, true, Properties.GUIStrings.LabelNewEntry, -1, Properties.Resources.UserNone);

            using (EditForm ef = new EditForm(partList_, newItem, settings_, true))
            {
                if (ef.ShowDialog() == DialogResult.OK)
                {
                    currentCar_.Costs.Add(newItem);
                    Recalculate();
                }
            }
        }

        private void EditEntry()
        {
            if (listViewLoss.SelectedIndices.Count <= 0) return;

            int id = int.Parse(listViewLoss.SelectedItems[0].SubItems[0].Text);

            Item it = currentCar_.Costs.First(x => x.ID == id);
            using (EditForm ef = new EditForm(partList_, it, settings_))
            {
                ef.ShowDialog();

                Recalculate();
            }
        }

        private void LoadCosts()
        {
            listViewLoss.Items.Clear();

            foreach (Item item in currentCar_.Costs)
            {
                ListViewItem lvi = new ListViewItem(item.ID.ToString());

                lvi.SubItems.Add(currentCar_.Brand);
                lvi.SubItems.Add(currentCar_.Model);
                lvi.SubItems.Add(item.Position);
                lvi.SubItems.Add(string.Format("{0:C}", item.Price));
                lvi.SubItems.Add(item.Person);
                lvi.SubItems.Add(item.Include ? Properties.GUIStrings.LabelYes : Properties.GUIStrings.LabelNo);

                listViewLoss.Items.Add(lvi);
            }



            toolStripCostSum.Text = string.Format("{1}: {0:C}", currentCar_.TotalCost, Properties.GUIStrings.LabelSum);
        }

        private void DeleteEntry()
        {
            if (listViewLoss.SelectedIndices.Count <= 0) return;

            int id = int.Parse(listViewLoss.SelectedItems[0].SubItems[0].Text);

            Item it = currentCar_.Costs.First(x => x.ID == id);

            if (MessageBox.Show(string.Format(Properties.GUIStrings.FormatConfirmDelete, it.Position), Properties.GUIStrings.LabelDelete,
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                currentCar_.Costs.Remove(it);

                Recalculate();
            }
        }

        private void ValidateAnzahlung()
        {
            if (comboBoxPersonAnzahlung.SelectedItem == null) return;

            if (ValidateNumber(TextBoxDownPayment.Text, out float f) == false)
            {
                TextBoxDownPayment.Focus();
            }
            else
            {
                currentCar_.DownPayment = f;
                currentCar_.DownPaymentPerson = comboBoxPersonAnzahlung.SelectedItem.ToString();
                Calculate();
            }
        }

        private bool ValidateNumber(string s, out float n)
        {
            string s2 = s.Replace('.', ',');
            if (float.TryParse(s2, out n))
            {
                if (n < 0)
                {
                    if (MessageBox.Show(Properties.GUIStrings.NegativeDownPaymentWarning, 
                        Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return false;
                    }
                }

                return true;
            }

            MessageBox.Show(Properties.GUIStrings.InvalidPriceError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);

            return false;
        }

        private void ValidateRest()
        {
            if (comboBoxPersonRest.SelectedItem == null) return;

            if (ValidateNumber(TextBoxPayment.Text, out float f) == false)
            {
                TextBoxPayment.Focus();
            }
            else
            {
                currentCar_.Payment = f;
                currentCar_.PaymentPerson = comboBoxPersonRest.SelectedItem.ToString();
                Calculate();
            }
        }

        private void Calculate()
        {
            listViewPayPerPerson.Items.Clear();
            listViewWinPerPerson.Items.Clear();

            HashSet<string> people = currentCar_.People;

            List<float> sumWins = new List<float>();
            List<float> sumCosts = new List<float>();

            foreach (string user in people)
            {
                IEnumerable<Item> items = currentCar_.Costs.Where(x => x.Person == user);

                float summe = items.Where(x => x.Include).Sum(x => x.Price);
                sumCosts.Add(summe);


                ListViewItem lvi = new ListViewItem(user);
                lvi.SubItems.Add(string.Format("{0:C}", summe));

                listViewPayPerPerson.Items.Add(lvi);

                if (user != Properties.Resources.UserNone)
                {
                    float win = (currentCar_.Win / people.Count);
                    float summe2 = summe + win;

                    sumWins.Add(summe2);

                    ListViewItem lvi2 = new ListViewItem(user);
                    lvi2.SubItems.Add(string.Format("{0:C}", summe2));
                    lvi2.SubItems.Add(string.Format("{0:C}", win));
                    listViewWinPerPerson.Items.Add(lvi2);
                }
            }

            float summeNotCalculated = currentCar_.Costs.Where(x => !x.Include).Sum(x => x.Price);

            ListViewItem lvi3 = new ListViewItem(Properties.GUIStrings.LabelNotInclude);
            lvi3.SubItems.Add(string.Format("{0:C}", summeNotCalculated));
            listViewPayPerPerson.Items.Add(lvi3);

            textBoxTotal.Text = string.Format("{0:C}", currentCar_.SellPrice);
            statusLabelWin.Text = string.Format("{0:C}", currentCar_.Win);

            diagramWin_.UpdateData(sumWins);
            diagramCost_.UpdateData(sumCosts);
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

            listViewLoss.Sort();
        }

        private void Recalculate()
        {
            LoadCosts();
            Calculate();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {

            if (keyData == (Keys.Control | Keys.D1))
            {
                tabControlMain.SelectTab(0);
            }
            else if (keyData == (Keys.Control | Keys.D2))
            {
                tabControlMain.SelectTab(1);
            }
            else if (keyData == (Keys.Control | Keys.D3))
            {
                tabControlMain.SelectTab(2);
            }
            else if (keyData == (Keys.Control | Keys.R))
            {
                Recalculate();
            }
            else if (keyData == Keys.Escape)
            {
                if (MessageBox.Show(Properties.GUIStrings.ConfirmBack, Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Close();
                }
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }

        #endregion

        #region Ausgaben

        private void EditLossItem_Click(object sender, EventArgs e)
        {
            EditEntry();
        }

        private void DeleteLossItem_Click(object sender, EventArgs e)
        {
            DeleteEntry();
        }

        private void AddlossItem_Click(object sender, EventArgs e)
        {
            AddEntry();
        }

        #region ListView

        private void ListViewLoss_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            SortByColumn(e.Column);
            settings_.SortByColumnItemSelect = e.Column;
        }

        private void ListViewLoss_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            EditEntry();
        }

        private void ListViewLoss_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.T)
            {
                if (listViewLoss.SelectedIndices.Count <= 0) return;

                int id = int.Parse(listViewLoss.SelectedItems[0].SubItems[0].Text);
                Item it = currentCar_.Costs.First(x => x.ID == id);

                it.Include = !it.Include;

                Recalculate();
            }
            else if (e.KeyCode == Keys.Enter)
            {
                EditEntry();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                DeleteEntry();
            }
            else if (e.KeyCode == Keys.Insert)
            {
                AddEntry();
            }
        }

        #endregion

        #endregion

        #region Einnahmen

        private void TextBoxAnzahlung_Leave(object sender, EventArgs e)
        {
            ValidateAnzahlung ();
        }

        private void TextBoxAnzahlung_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                ValidateAnzahlung();
            }
        }

        private void TextBoxRest_Leave(object sender, EventArgs e)
        {
            ValidateRest();
        }

        private void TextBoxRest_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ValidateRest();
            }
        }

        private void ComboBoxPersonAnzahlung_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateAnzahlung();
        }

        private void ComboBoxPersonRest_SelectedIndexChanged(object sender, EventArgs e)
        {
            ValidateRest();
        }

        private void ButtonSavePayments_Click(object sender, EventArgs e)
        {
            if (comboBoxPersonAnzahlung.SelectedItem == null)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyPersonError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPersonAnzahlung.Focus();
                return;
            }

            if (comboBoxPersonRest.SelectedItem == null)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyPersonError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                comboBoxPersonRest.Focus();
                return;
            }

            ValidateAnzahlung();
            ValidateRest();
        }

        #endregion

        #region ToolStripMenu

        private void RecalculateMenuItem_Click(object sender, EventArgs e)
        {
            Recalculate();
        }

        private void OpenPayMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(0);
        }

        private void OpenWinMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(1);
        }

        private void OpenResultMenuItem_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectTab(2);
        }

        private void BackHomeMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        private void AusgabenProPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagramCost_.Show();
        }

        private void AusschüttungProPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            diagramWin_.Show();
        }

        private void HilfeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HelpWindow hw = new HelpWindow();
            hw.Show();
        }

        #endregion

    }
}
