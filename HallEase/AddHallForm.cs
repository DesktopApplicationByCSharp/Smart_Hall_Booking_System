using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class AddHallForm : Form
    {
        private User _currentUser;
        private HallService _hallService;
        private string _selectedImagePath;

        public AddHallForm()
        {
            _hallService = new HallService();
            InitializeComponent();

            btnSave.Click += BtnSave_Click;
            btnCancel.Click += (s, e) => this.Close();
            btnBrowse.Click += BtnBrowse_Click;
        }

        public AddHallForm(User user) : this()
        {
            _currentUser = user;
        }

        private void BtnSave_Click(object sender, EventArgs e)
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

            Hall newHall = new Hall
            {
                Name = txtName.Text.Trim(),
                Location = txtLocation.Text.Trim(),
                Capacity = capacity,
                Price = price,
                Description = txtDescription.Text.Trim(),
                OwnerID = _currentUser?.UserID ?? 0,
                ImagePath = _selectedImagePath ?? ""
            };

            if (_hallService.AddHall(newHall))
            {
                MessageBox.Show("Hall added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void BtnBrowse_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                openFileDialog.Title = "Select Hall Image";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImagePath = openFileDialog.FileName;
                    pbImage.ImageLocation = _selectedImagePath;
                }
            }
        }
    }
}



