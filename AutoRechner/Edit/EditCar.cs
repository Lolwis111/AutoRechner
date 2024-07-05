using AutoRechner.Edit;
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
    public partial class EditCar : Form
    {
        private Car car_;
        private BrandList brandList_;

        public EditCar(Car car, BrandList brandList, bool newCar=false)
        {
            car_ = car;
            brandList_ = brandList;

            InitializeComponent();

            textBoxBrand.Text = car_.Brand;
            textBoxComment.Text = car_.Comment;
            textBoxModel.Text = car_.Model;
            buyDateTime.Value = car_.BuyDate;

            if(newCar)
            {
                Text = Properties.GUIStrings.TitleNewCar;
            }
            else
            {
                Text = Properties.GUIStrings.TitleEditCar;
            }
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxBrand.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyBrandError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxModel.TextLength == 0)
            {
                MessageBox.Show(Properties.GUIStrings.EmptyModelError, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxComment.TextLength == 0)
            {
                if (MessageBox.Show(Properties.GUIStrings.EmptyCommentWarning, Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }
            }

            car_.Brand = textBoxBrand.Text;
            car_.Model = textBoxModel.Text;
            car_.BuyDate = buyDateTime.Value;
            car_.Comment = textBoxComment.Text;

            brandList_.AddBrand(textBoxBrand.Text);

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EditCar_Load(object sender, EventArgs e)
        {
            listBoxRecommend.Visible = false;
        }

        private void TextBoxBrand_Leave(object sender, EventArgs e)
        {
            if (!listBoxRecommend.Focused)
            {
                listBoxRecommend.Visible = false;
            }
        }

        private void TextBoxBrand_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape || e.KeyCode == Keys.Tab)
            {
                listBoxRecommend.Visible = false;
            }
            else if (e.KeyCode == Keys.Down)
            {
                listBoxRecommend.Visible = true;
                listBoxRecommend.Focus();
            }
        }

        private void ListBoxRecommend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBoxBrand.Text = listBoxRecommend.SelectedItem.ToString();
                listBoxRecommend.Visible = false;
            }
            else if (e.KeyCode == Keys.Escape)
            {
                listBoxRecommend.Visible = false;
            }
        }

        private void ListBoxRecommend_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            textBoxBrand.Text = listBoxRecommend.SelectedItem.ToString();
        }

        private void TextBoxBrand_TextChanged(object sender, EventArgs e)
        {
            listBoxRecommend.Visible = true;
            listBoxRecommend.Items.Clear();

            bool any = false;
            foreach (string item in brandList_.FindMatching(textBoxBrand.Text))
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
    }
}
