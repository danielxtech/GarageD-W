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
    public partial class OilChangeForm : Form
    {
        public string InvoiceText { get; private set; }
        public OilChangeForm()
        {
            InitializeComponent();
        }

        private void btnChangeOil_Click(object sender, EventArgs e)
        {
            string oilType = (cmbOilType.SelectedItem != null)
                     ? cmbOilType.SelectedItem.ToString().Trim()
                     : cmbOilType.Text.Trim();

            if (string.IsNullOrEmpty(oilType))
            {
                MessageBox.Show("Please select an oil type.");
                return;
            }

            var oilPrices = new Dictionary<string, decimal>(StringComparer.OrdinalIgnoreCase)
            
            {
              { "Conventional", 35m },
              { "Semi-Synthetic", 50m },
              { "Synthetic", 75m }
            };

            if (!oilPrices.TryGetValue(oilType, out decimal price))
            {
                if (oilType.IndexOf("conventional", StringComparison.OrdinalIgnoreCase) >= 0) price = 35m;
                else if (oilType.IndexOf("semi", StringComparison.OrdinalIgnoreCase) >= 0) price = 50m;
                else if (oilType.IndexOf("synthetic", StringComparison.OrdinalIgnoreCase) >= 0) price = 75m;
                else
                {
                    MessageBox.Show($"Unknown oil type: '{oilType}'. Please select a valid oil type.");
                    return;
                }
            }

            decimal filterPrice = chkOilFilter.Checked ? 15m : 0m;
            decimal totalPrice = price + filterPrice;

            StringBuilder s = new StringBuilder();
            s.AppendLine("OIL CHANGE SERVICE");
            s.AppendLine($"Oil Type: {price:C}");
            s.AppendLine($"Filter Change: {(chkOilFilter.Checked ? $"Yes (+{filterPrice:C})" : "No")}");
            s.AppendLine($"TOTAL PRICE: {totalPrice:C}");

            InvoiceText = s.ToString();
            DialogResult = DialogResult.OK;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
