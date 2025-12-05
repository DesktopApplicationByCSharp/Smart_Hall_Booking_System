using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class OwnerDashboard : Form
    {
        private User _currentUser;

        public OwnerDashboard(User user)
        {
            _currentUser = user;
            InitializeComponent();

            // Set welcome text and wire up events from designer
            lblWelcome.Text = $"Welcome, {_currentUser.Name}";

            btnMyHalls.Click += BtnMyHalls_Click;
            btnAddHall.Click += BtnAddHall_Click;
            btnMyBookings.Click += BtnMyBookings_Click;
            btnProfile.Click += BtnProfile_Click;
            btnLogout.Click += (s, e) => this.Close();
        }

        private void BtnMyHalls_Click(object sender, EventArgs e)
        {
            OwnerHallsForm form = new OwnerHallsForm(_currentUser);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnAddHall_Click(object sender, EventArgs e)
        {
            AddHallForm form = new AddHallForm(_currentUser);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnMyBookings_Click(object sender, EventArgs e)
        {
            OwnerBookingsForm form = new OwnerBookingsForm(_currentUser);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnProfile_Click(object sender, EventArgs e)
        {
            ProfileForm form = new ProfileForm(_currentUser);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void OwnerDashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAddHall_Click_1(object sender, EventArgs e)
        {

        }
    }
}




