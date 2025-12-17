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
    public partial class MainForm : Form
    {
        private string invoiceText = "";
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            Vehicle v = new Vehicle()
            {
                PlateNumber = txtPlateNumber.Text,
                Brand = txtBrand.Text,
                Year = txtYear.Text,
                FuelType = txtFuelType.Text,
                OwnerName = txtClientName.Text,
                OwnerPhone = txtClientPhone.Text,
            };

            DatabaseHelper.InsertVehicle(v);

            MessageBox.Show("Vehicle saved successfully!");
        }

        private void btnCheckTires_Click_1(object sender, EventArgs e) 
        {
            ChangeTiresForm f = new ChangeTiresForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                invoiceText = f.InvoiceText;
                MessageBox.Show(invoiceText, "Invoice");
            }
        }

        private void btnCarWash_Click_1(object sender, EventArgs e)
        {
            CarWashForm f = new CarWashForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                invoiceText = f.InvoiceText;
                MessageBox.Show(invoiceText, "Invoice");

            }
        }

        private void btnOilChange_Click_1(object sender, EventArgs e)
        {
            OilChangeForm f = new OilChangeForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                invoiceText = f.InvoiceText;
                MessageBox.Show(invoiceText, "Invoice");
            }
        }

        private void btnCarPaint_Click_1(object sender, EventArgs e){
            CarPaintForm f = new CarPaintForm();
            if (f.ShowDialog() == DialogResult.OK)
            {
                invoiceText = f.InvoiceText;
                MessageBox.Show(invoiceText, "Invoice");
            }
        }

        private void List_Click(object sender, EventArgs e) => new VehicleListForm().ShowDialog();

    }
}
