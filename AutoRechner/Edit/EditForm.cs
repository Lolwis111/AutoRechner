using AutoRechner.Edit;
using AutoRechner.Extra;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRechner
{
    public partial class EditForm : Form
    {
        private Item editItem;
        private PartList partList;
        private SettingsManager settings;

        public EditForm(PartList pl, Item item, SettingsManager settings, bool newitem = false)
        {
            partList = pl;
            editItem = item;
            this.settings = settings;

            InitializeComponent();

            if(newitem)
            {
                item.Include = settings.Einberechnen;
            }
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {

            if(textBoxPosition.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyPositionError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (comboBoxPerson.Text.Length == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyPersonError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string preis = textBoxPreis.Text.Replace('.', ',');

            if(float.TryParse(preis, out float price))
            {
                editItem.Position = textBoxPosition.Text;
                editItem.Price = price;
                editItem.Person = comboBoxPerson.Text;
                editItem.Include = checkBoxPart.Checked;

                if (price <= 0)
                {
                    if (MessageBox.Show(Properties.GUIStrings.NegativePriceWarning, Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                    {
                        return;
                    }
                }

                partList.AddPart(textBoxPosition.Text);

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                MessageBox.Show(Properties.GUIStrings.InvalidPriceError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void EditForm_Load(object sender, EventArgs e)
        {
            comboBoxPerson.Items.Clear();
            foreach (string user in settings.Users)
            {
                comboBoxPerson.Items.Add(user);
            }

            textBoxPosition.Text = editItem.Position;
            textBoxPreis.Text = editItem.Price.ToString("0.00");
            checkBoxPart.Checked = editItem.Include;
            listBoxRecommend.Visible = false;

            for (int i = 0; i < comboBoxPerson.Items.Count; i++)
            {
                if (comboBoxPerson.Items[i].ToString() == editItem.Person)
                {
                    comboBoxPerson.SelectedIndex = i;
                    break;
                }
            }
        }

        private void TextBoxPosition_Leave(object sender, EventArgs e)
        {
            if(!listBoxRecommend.Focused)
            {
                listBoxRecommend.Visible = false;
            }
        }

        private void TextBoxPosition_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Escape || e.KeyCode == Keys.Tab)
            {
                listBoxRecommend.Visible = false;
            }
            else if(e.KeyCode == Keys.Down)
            {
                listBoxRecommend.Visible = true;
                listBoxRecommend.Focus();
            }
        }

        private void ListBoxRecommend_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                textBoxPosition.Text = listBoxRecommend.SelectedItem.ToString();
                listBoxRecommend.Visible = false;
            }
            else if(e.KeyCode == Keys.Escape)
            {
                listBoxRecommend.Visible = false;
            }
        }

        private void ListBoxRecommend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxPosition.Text = listBoxRecommend.SelectedItem.ToString();
        }

        private void TextBoxPosition_TextChanged(object sender, EventArgs e)
        {
            listBoxRecommend.Visible = true;
            listBoxRecommend.Items.Clear();

            bool any = false;
            foreach (string item in partList.FindMatching(textBoxPosition.Text))
            {
                listBoxRecommend.Items.Add(item);
                any = true;
            }

            if (any)
            {
                listBoxRecommend.SelectedIndex = 0;
            }
            else
            {
                listBoxRecommend.Visible = false;
            }
        }

        private void EditForm_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            HelpWindow hw = new HelpWindow();
            hw.Show();
        }
    }
}
