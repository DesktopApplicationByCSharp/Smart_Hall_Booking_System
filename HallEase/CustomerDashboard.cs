using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class CustomerDashboard : Form
    {
        private User _currentUser;

        public CustomerDashboard(User user)
        {
            _currentUser = user;
            InitializeComponent();

            // Set welcome text and wire events
            lblWelcome.Text = $"Welcome, {_currentUser.Name}";

            btnViewHalls.Click += BtnViewHalls_Click;
            btnMyBookings.Click += BtnMyBookings_Click;
            btnProfile.Click += BtnProfile_Click;
            btnLogout.Click += (s, e) => this.Close();
        }

        private void BtnViewHalls_Click(object sender, EventArgs e)
        {
            HallsListForm form = new HallsListForm(_currentUser);
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnMyBookings_Click(object sender, EventArgs e)
        {
            MyBookingsForm form = new MyBookingsForm(_currentUser);
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
    }
}


