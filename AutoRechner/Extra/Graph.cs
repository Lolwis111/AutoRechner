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
    public partial class Graph : Form
    {
        private List<SolidBrush> brushes_ = new List<SolidBrush>();
        private List<float> data_ = new List<float>();
        private Random random_ = new Random();

        public Graph(string title)
        {
            InitializeComponent();

            Text = title;
        }

        private void panelRender_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Panel p = sender as Panel;

            int height = p.Height;
            int width = p.Width;

            int pw = width < height ? width - 10 : height - 10;
            int ph = width < height ? width - 10 : height - 10;

            Rectangle center = new Rectangle(width / 2 - pw / 2, height / 2 - ph / 2, pw, ph);

            float offset = 0;

            for (int i = 0; i < data_.Count; i++)
            {
                g.FillPie(brushes_[i], center, offset, data_[i]);
                offset += data_[i];
            }

            g.DrawPie(Pens.Black, center, 0, 360);

            g.Flush();
        }

        public void UpdateData(IEnumerable<float> newdata)
        {
            int nc = newdata.Count();

            if (nc != data_.Count)
            {
                brushes_.Clear();

                for (int i = 0; i < nc; i++)
                {
                    int r = random_.Next(0, 255);
                    int g = random_.Next(0, 255);
                    int b = random_.Next(0, 255);

                    brushes_.Add(new SolidBrush(Color.FromArgb(r, g, b)));
                }
            }

            data_ = new List<float>();

            float sum = newdata.Sum();

            foreach(float f in newdata)
            {
                data_.Add((f / sum) * 100 * 3.6f);
            }

            panelRender.Refresh();
        }

        private void Diagramm_Resize(object sender, EventArgs e)
        {
            panelRender.Refresh();
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(keyData == Keys.Escape)
            {
                Hide();
            }

            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
