
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AutoRechner.Extra
{
    public partial class CreateInvoice : Form
    {
        private Car car;
        private SettingsManager settings;

        public CreateInvoice(SettingsManager settings, Car car)
        {
            InitializeComponent();

            this.car = car;
            this.settings = settings;
        }

        private void ButtonCreateInvoice_Click(object sender, EventArgs e)
        {
            if(textBoxName.TextLength == 0)
            {
                MessageBox.Show("Der Name darf nich leer sein!", Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxStreet.TextLength == 0)
            {
                MessageBox.Show("Die Straße darf nich leer sein!", Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxZipCode.TextLength == 0)
            {
                MessageBox.Show("Der Postleizahl darf nich leer sein!", Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (textBoxTown.TextLength == 0)
            {
                MessageBox.Show("Die Stadt darf nich leer sein!", Properties.GUIStrings.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Address address = new Address()
            {
                Name = textBoxName.Text,
                Street = textBoxStreet.Text,
                Zip = textBoxZipCode.Text,
                Town = textBoxTown.Text
            };

            using (SaveFileDialog svd = new SaveFileDialog() { CheckPathExists = true, Filter = $"{Properties.GUIStrings.InvoiceExportFilter}|*.pdf" })
            {
                if (svd.ShowDialog() == DialogResult.OK)
                {
                    Invoice invoice = new Invoice(settings);
                    invoice.Create(car, includeTax.Checked, address, "");
                    invoice.ExportAsPDF(svd.FileName);
                }

            }
        }
    }
}
