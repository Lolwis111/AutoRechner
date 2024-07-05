using AutoRechner.Edit;
using System;
using System.Windows.Forms;

namespace AutoRechner.Settings
{
    public partial class SettingsEditorWindow : Form
    {
        private SettingsManager settings_;
        private PartList partList_;
        private BrandList brandList_;

        public SettingsEditorWindow(SettingsManager settings, PartList partList, BrandList brandList)
        {
            settings_ = settings;
            brandList_ = brandList;
            partList_ = partList;
            InitializeComponent();

            Text = $"\'{Properties.GUIStrings.LabelInclude}\' {Properties.GUIStrings.LabelDefaultValue}";

            LoadUsers();

            if(settings.Einberechnen)
            {
                radioButtonInclude1.Checked = true;
            }
            else
            {
                radioButtonInclude2.Checked = true;
            }
        }

        private void buttonDeleteUser_Click(object sender, EventArgs e)
        {
            if (listBoxUsers.SelectedIndices.Count > 0)
            {
                string selectedUser = listBoxUsers.SelectedItem.ToString();

                if(MessageBox.Show(string.Format(Properties.GUIStrings.FormatConfirmDelete, selectedUser), Properties.GUIStrings.Warning, 
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    settings_.Users.Remove(selectedUser);
                    LoadUsers();
                }
            }
        }

        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyUsernameError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string username = textBoxUsername.Text;

            if(settings_.Users.Contains(username))
            {
                MessageBox.Show(string.Format(Properties.GUIStrings.FormatDuplicateWarning, username), Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            settings_.Users.Add(username);
            textBoxUsername.Clear();

            LoadUsers();
        }

        private void LoadUsers()
        {
            listBoxUsers.Items.Clear();

            foreach(string user in settings_.Users)
            {
                if (user != Properties.Resources.UserNone)
                {
                    listBoxUsers.Items.Add(user);
                }
            }
        }

        private void LoadParts()
        {
            listBoxParts.Items.Clear();

            foreach (string part in partList_.Parts)
            {
                listBoxParts.Items.Add(part);
            }
        }

        private void LoadBrands()
        {
            listBoxBrands.Items.Clear();

            foreach (string brand in brandList_.Brands)
            {
                listBoxBrands.Items.Add(brand);
            }
        }

        private void SaveSettingsMenuItem_Click(object sender, EventArgs e)
        {
            settings_.Einberechnen = false;
            if(radioButtonInclude1.Checked)
            {
                settings_.Einberechnen = true;
            }

            IsolatedDiskStorage.SaveSettings(settings_);

            Close();
        }

        private void buttonDeletePart_Click(object sender, EventArgs e)
        {
            if (listBoxParts.SelectedIndices.Count > 0)
            {
                string selectedPart = listBoxParts.SelectedItem.ToString();

                if (MessageBox.Show(string.Format(Properties.GUIStrings.FormatConfirmDelete, selectedPart), Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    partList_.RemovePart(selectedPart);
                    LoadParts();
                }
            }
        }

        private void ButtonAddPart_Click(object sender, EventArgs e)
        {
            if (textBoxPart.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyPartError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string part = textBoxPart.Text;

            if (partList_.Parts.Contains(part))
            {
                MessageBox.Show(string.Format(Properties.GUIStrings.FormatDuplicateWarning, part), Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            partList_.AddPart(part);
            textBoxPart.Clear();

            LoadParts();
        }

        private void ButtonDeleteBrand_Click(object sender, EventArgs e)
        {
            if (listBoxBrands.SelectedIndices.Count > 0)
            {
                string selectedBrand = listBoxBrands.SelectedItem.ToString();

                if (MessageBox.Show(string.Format(Properties.GUIStrings.FormatConfirmDelete, selectedBrand), Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    brandList_.RemoveBrand(selectedBrand);
                    LoadBrands();
                }
            }
        }

        private void ButtonAddBrand_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyBrandError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string brand = textBoxBrand.Text;

            if (brandList_.Brands.Contains(brand))
            {
                MessageBox.Show(string.Format(Properties.GUIStrings.FormatDuplicateWarning, brand), Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            brandList_.AddBrand(brand);
            textBoxBrand.Clear();

            LoadBrands();
        }
    }
}
