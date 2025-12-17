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
    public partial class CarPaintForm : Form
    {
        public string InvoiceText { get; private set; }
        public CarPaintForm()
        {
            InitializeComponent();
        }

        private void btnPaint_Click(object sender, EventArgs e)
        {
            string type = radFullPaint.Checked ? "Full Paint" :
                  radPartialPaint.Checked ? "Partial Paint" :
                  "Touch Up";

            decimal price = 0;

            if (radFullPaint.Checked) price = 500;
            else if (radPartialPaint.Checked) price = 200;
            else price = 50;

            if (chkClearCoat.Checked) price += 100;

            InvoiceText =
                $"PAINT SERVICE\n" +
                $"Color: {cmbColor.Text}\n" +
                $"Area: {txtArea.Text}\n" +
                $"Type: {type}\n" +
                $"Clear Coat: {(chkClearCoat.Checked ? "Yes" : "No")}\n\n" +
                $"TOTAL PRICE: {price:C}";

            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
