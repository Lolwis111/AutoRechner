
using System.Collections.Generic;

using System.Windows.Forms;

namespace AutoRechner.Extra
{
    public partial class HelpWindow : Form
    {
        private Dictionary<string, string> helpTexts = new Dictionary<string, string>();

        public HelpWindow()
        {
            InitializeComponent();

            helpTexts.Clear();

            helpTexts.Add(Properties.GUIStrings.LabelPosition, Properties.Resources.helpStrPosition);

            helpTexts.Add(Properties.GUIStrings.LabelPrice, Properties.Resources.helpStrPreis);

            helpTexts.Add(Properties.GUIStrings.LabelPerson, Properties.Resources.helpStrPerson);

            helpTexts.Add(Properties.GUIStrings.LabelInclude, Properties.Resources.helpStrEinberechnen);

            helpTexts.Add(Properties.GUIStrings.LabelPayout, Properties.Resources.helpStrPay);


            helpTexts.Add(Properties.GUIStrings.LabelBrand, Properties.Resources.helpStrMarke);

            helpTexts.Add(Properties.GUIStrings.LabelModel, Properties.Resources.helpStrModell);

            helpTexts.Add(Properties.GUIStrings.LabelComment, Properties.Resources.helpStrKommentar);

            helpTexts.Add(Properties.GUIStrings.LabelDate, Properties.Resources.helpStrDatum);

            helpTexts.Add(Properties.GUIStrings.LabelCar, Properties.Resources.helpStrAuto);

            helpTexts.Add(Properties.GUIStrings.LabelEntry, Properties.Resources.helpStrEintraege);

        }

        private void TreeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            string key = e.Node.Text;

            if(helpTexts.ContainsKey(key))
            {
                rtbHelp.Rtf = helpTexts[key];
            }
        }
    }
}
