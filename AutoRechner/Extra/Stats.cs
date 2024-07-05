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
    public partial class Stats : Form
    {
        private List<Car> cars_;

        public Stats(List<Car> cars)
        {
            cars_ = cars;
            InitializeComponent();

        }

        private void Stats_Load(object sender, EventArgs e)
        {
            ListViewItem lvi1 = new ListViewItem(Properties.GUIStrings.LabelCarsInDatabase);
            lvi1.SubItems.Add(cars_.Count.ToString());
            listViewStats.Items.Add(lvi1);

            if (cars_.Count > 0)
            {
                float avgsell = cars_.Average(c => c.SellPrice);
                float avgwin = cars_.Average(c => c.Win);
                float avgcost = cars_.Average(c => c.TotalCost);

                ListViewItem lvi2 = new ListViewItem(Properties.GUIStrings.LabelAverageSell);
                lvi2.SubItems.Add(string.Format("{0:C}", avgsell));

                ListViewItem lvi3 = new ListViewItem(Properties.GUIStrings.LabelAverageCost);
                lvi3.SubItems.Add(string.Format("{0:C}", avgcost));

                ListViewItem lvi4 = new ListViewItem(Properties.GUIStrings.LabelAverageProfit);
                lvi4.SubItems.Add(string.Format("{0:C}", avgwin));

                listViewStats.Items.Add(lvi2);
                listViewStats.Items.Add(lvi3);

                var yearGroups = cars_.GroupBy(x => x.BuyDate.Year);
                foreach(var yearGroup in yearGroups)
                {
                    ListViewItem lvi = new ListViewItem($"{Properties.GUIStrings.LabelTotalProfit} {yearGroup.Key}");
                    lvi.SubItems.Add(string.Format("{0:C}", yearGroup.Sum(x => x.Win)));
                    listViewStats.Items.Add(lvi);
                }
            }
        }       
    }
}
