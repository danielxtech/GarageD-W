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
    public partial class VehicleListForm : Form
    {
        public VehicleListForm()
        {
            InitializeComponent();
        }

        private void VehicleListForm_Load(object sender, EventArgs e)
        {
            LoadVehicles();
        }
        private void LoadVehicles()
        {
            dgvVehicles.DataSource = DatabaseHelper.GetAllVehicles();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            DatabaseHelper.AddVehicle(
                txtPlate.Text,
                txtBrand.Text,
                txtYear.Text,
                txtFuel.Text,
                txtOwner.Text,
                txtPhone.Text
            );

            LoadVehicles();
            MessageBox.Show("Vehicle added successfully!");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select a row to update.");
                return;
            }

            DatabaseHelper.UpdateVehicle(
                int.Parse(txtID.Text),
                txtPlate.Text,
                txtBrand.Text,
                txtYear.Text,
                txtFuel.Text,
                txtOwner.Text,
                txtPhone.Text
            );

            LoadVehicles();
            MessageBox.Show("Vehicle updated successfully!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Select a row to delete.");
                return;
            }

            DatabaseHelper.DeleteVehicle(int.Parse(txtID.Text));

            LoadVehicles();
            MessageBox.Show("Vehicle deleted successfully!");
        }

        private void btnRefresh_Click(object sender, EventArgs e) => LoadVehicles();

        private void dgvVehicles_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dgvVehicles.Rows[e.RowIndex].Cells["VehicleID"].Value.ToString();
                txtPlate.Text = dgvVehicles.Rows[e.RowIndex].Cells["PlateNumber"].Value.ToString();
                txtBrand.Text = dgvVehicles.Rows[e.RowIndex].Cells["Brand"].Value.ToString();
                txtYear.Text = dgvVehicles.Rows[e.RowIndex].Cells["Year"].Value.ToString();
                txtFuel.Text = dgvVehicles.Rows[e.RowIndex].Cells["FuelType"].Value.ToString();
                txtOwner.Text = dgvVehicles.Rows[e.RowIndex].Cells["OwnerName"].Value.ToString();
                txtPhone.Text = dgvVehicles.Rows[e.RowIndex].Cells["OwnerPhone"].Value.ToString();
            }
        }

    }
    
}
