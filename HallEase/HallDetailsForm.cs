using HallsProjects;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class HallDetailsForm : Form
    {
        private User _currentUser;
        private Hall _hall;

        public HallDetailsForm(User user, Hall hall)
        {
            _currentUser = user;
            _hall = hall;
            InitializeComponent();

            // Populate designer controls
            lblName.Text = _hall.Name;
            lblLocation.Text = $"📍 {_hall.Location}";
            lblCapacity.Text = $"👥 Capacity: {_hall.Capacity} Guests";
            lblPrice.Text = $"💰 Price: ${_hall.Price}";
            lblDesc.Text = _hall.Description;

            if (!string.IsNullOrEmpty(_hall.ImagePath) && System.IO.File.Exists(_hall.ImagePath))
            {
                pbHallImage.Image = System.Drawing.Image.FromFile(_hall.ImagePath);
            }
            else
            {
                // Optional: Set a default image or leave empty
                pbHallImage.BackColor = System.Drawing.Color.LightGray;
            }

            btnBookNow.Click += BtnBookNow_Click;
            btnBack.Click += (s, e) => this.Close();
        }

        private void BtnBookNow_Click(object sender, EventArgs e)
        {
            BookingForm form = new BookingForm(_currentUser, _hall);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }
    }
}



