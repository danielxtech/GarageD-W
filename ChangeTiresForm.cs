using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace GarageD_W
{
    public partial class ChangeTiresForm : Form
    {
        public string InvoiceText { get; private set; }
        public ChangeTiresForm()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnchangetire_Click(object sender, EventArgs e)
        {
            if (cmbTireType.SelectedItem == null)
            {
                MessageBox.Show("Please select a tire type.");
                return;
            }

            string tireType = cmbTireType.SelectedItem.ToString().Trim();

            var tirePrices = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
            {
              { "Michelin", 120m },
              { "Yokohama", 100m },
              { "Bridgestone", 110m },
              { "Goodyear", 90m }
            };

            decimal pricePerWheel;

            if (!tirePrices.TryGetValue(tireType, out pricePerWheel))
            {
                if (tireType.IndexOf("Michelin", StringComparison.OrdinalIgnoreCase) >= 0)
                    pricePerWheel = 120m;
                else if (tireType.IndexOf("Yokohama", StringComparison.OrdinalIgnoreCase) >= 0)
                    pricePerWheel = 100m;
                else if (tireType.IndexOf("Bridgestone", StringComparison.OrdinalIgnoreCase) >= 0)
                    pricePerWheel = 110m;
                else if (tireType.IndexOf("Goodyear", StringComparison.OrdinalIgnoreCase) >= 0)
                    pricePerWheel = 90m;
                else
                {
                    MessageBox.Show($"Unknown tire type: '{tireType}'.");
                    return;
                }
            }

            decimal totalPrice = pricePerWheel * nudNumberOfWheels.Value;

            InvoiceText =
                $"TIRE CHANGE SERVICE\n" +
                $"Tire Type: {pricePerWheel:C} per wheel\n" +
                $"Number of Wheels: {nudNumberOfWheels.Value}\n" +
                $"Tire Size: {txtTireSize.Text}\n" +
                $"Last Change: {dtpLastChange.Value.ToShortDateString()}\n\n" +
                $"TOTAL PRICE: {totalPrice:C}";

            DialogResult = DialogResult.OK;
        }
    }
}
