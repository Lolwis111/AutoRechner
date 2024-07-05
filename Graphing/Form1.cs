using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Graphing
{
    public partial class Form1 : Form
    {
        private Random rand = new Random();
        private float[] data = new float[3];

        private Brush[] brushes = { Brushes.Red, Brushes.Green, Brushes.Yellow, Brushes.Blue, Brushes.Pink, Brushes.Violet };

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int size = rand.Next(2, 6);
            data = new float[size];

            for (int i = 0; i < data.Length; i++)
            {
                data[i] = rand.Next(15, 150);
            }

            float sum = data.Sum();

            for(int i = 0; i < data.Length; i++)
            {
                data[i] = (data[i] / sum) * 100 * 3.6f;
            }

            panel1.Refresh();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            Panel p = sender as Panel;

            int height = p.Height;
            int width = p.Width;

            int pw = width < height? width - 10 : height - 10;
            int ph = width < height ? width - 10 : height - 10;

            Rectangle center = new Rectangle(width / 2 - pw/2, height/2 - ph/2, pw, ph);

            float offset = 0;

            for (int i = 0; i < data.Length; i++)
            {
                g.FillPie(brushes[i], center, offset, data[i]);

                float middle = offset + (data[i] / 2);

                offset += data[i];

                float rad = middle * (float)Math.PI / 180f;

                float x1 = center.Right;
                float y1 = center.Y;

                float x2 = (float)(Math.Cos(rad) * x1 - Math.Sin(rad) * y1);
                float y2 = (float)(Math.Sin(rad) * x1 + Math.Cos(rad) * y1);

                g.FillRectangle(Brushes.Black, new RectangleF(x2, y2, 5, 5));

                // x2 = cosβ x1 − sinβ y1
                // y2 = sinβx1 + cosβy1
            }

            g.DrawPie(Pens.Black, center, 0, 360);

            g.Flush();

        }
    }
}
