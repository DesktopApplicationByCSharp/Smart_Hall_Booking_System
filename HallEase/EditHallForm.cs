using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class EditHallForm : Form
    {
        private User _currentUser;
        private Hall _hallToEdit;
        private HallService _hallService;

        public EditHallForm(User user, Hall hall)
        {
            _currentUser = user;
            _hallToEdit = hall;
            _hallService = new HallService();
            InitializeComponent();

            // Wire designer events
            btnUpdate.Click += BtnUpdate_Click;
            btnCancel.Click += (s, e) => this.Close();

            LoadHallData();
        }

        private void LoadHallData()
        {
            if (_hallToEdit == null) return;
            txtName.Text = _hallToEdit.Name;
            txtLocation.Text = _hallToEdit.Location;
            txtCapacity.Text = _hallToEdit.Capacity.ToString();
            txtPrice.Text = _hallToEdit.Price.ToString();
            txtDescription.Text = _hallToEdit.Description;
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text) || string.IsNullOrWhiteSpace(txtLocation.Text) ||
                string.IsNullOrWhiteSpace(txtCapacity.Text) || string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtCapacity.Text, out int capacity) || !decimal.TryParse(txtPrice.Text, out decimal price))
            {
                MessageBox.Show("Capacity must be a number and Price must be a valid amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _hallToEdit.Name = txtName.Text.Trim();
            _hallToEdit.Location = txtLocation.Text.Trim();
            _hallToEdit.Capacity = capacity;
            _hallToEdit.Price = price;
            _hallToEdit.Description = txtDescription.Text.Trim();

            if (_hallService.UpdateHall(_hallToEdit))
            {
                MessageBox.Show("Hall updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to update hall.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}



