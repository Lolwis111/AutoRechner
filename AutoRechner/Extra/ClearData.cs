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
    public partial class ClearData : Form
    {
        private string code_ = string.Empty;

        public ClearData()
        {
            InitializeComponent();
            DialogResult = DialogResult.Cancel ;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if(code_ == textBoxCode.Text)
            {
                if(MessageBox.Show(Properties.GUIStrings.DropDBLastChance, Properties.GUIStrings.Warning, MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    DialogResult = DialogResult.OK;
                    Close();
                }
            }
            else
            {
                MessageBox.Show(Properties.GUIStrings.CaptchaMismatch, Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxCode.Text = string.Empty;
                GenerateCode();
            }
        }

        private void ClearData_Load(object sender, EventArgs e)
        {
            GenerateCode();
        }

        private void GenerateCode()
        {
            Random random = new Random(DateTime.Now.Millisecond);

            List<char> characters = new List<char>();

            for (char c = 'a'; c < 'z'; c++)
            {
                characters.Add(c);
            }

            for (char c = 'A'; c < 'Z'; c++)
            {
                characters.Add(c);
            }

            for (char c = '0'; c < '9'; c++)
            {
                characters.Add(c);
            }

            code_ = string.Empty;

            for (int i = 0; i < 6; i++)
            {
                code_ += characters[random.Next(0, characters.Count)];
            }

            Bitmap bmp = new Bitmap(pictureBoxCode.Width, pictureBoxCode.Height);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.DrawString(code_, new Font(FontFamily.GenericSerif, 16, FontStyle.Italic), Brushes.Black, 0, 0);
            }

            pictureBoxCode.Image = bmp;
        }
    }
}
