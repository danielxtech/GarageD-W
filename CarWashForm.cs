using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GarageD_W
{
    public partial class CarWashForm : Form
    {
        public string InvoiceText { get; private set; }
        public CarWashForm()
        {
            InitializeComponent();
        }

        private void btnWash_Click(object sender, EventArgs e)
        {
            StringBuilder s = new StringBuilder("CAR WASH SERVICES:\n");
            decimal total = 0;

            if (chkStandard.Checked) { s.AppendLine("- Standard Wash"); total += 25; }
            if (chkExterior.Checked) { s.AppendLine("- Exterior Only"); total += 15; }
            if (chkInterior.Checked) { s.AppendLine("- Interior Cleaning"); total += 20; }
            if (chkFullDetailing.Checked) { s.AppendLine("- Full Detailing"); total += 80; }
            if (chkWaxPolish.Checked) { s.AppendLine("- Wax & Polish"); total += 40; }

            s.AppendLine($"\nTOTAL PRICE: {total:C}");

            InvoiceText = s.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
