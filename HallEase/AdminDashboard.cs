using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class AdminDashboard : Form
    {
        private User _currentUser;

        public AdminDashboard(User user)
        {
            _currentUser = user;
            InitializeComponent();

            lblWelcome.Text = $"Welcome, Admin {_currentUser.Name}";

            btnManageUsers.Click += BtnManageUsers_Click;
            btnManageHalls.Click += BtnManageHalls_Click;
            btnManageBookings.Click += BtnManageBookings_Click;
            btnLogout.Click += (s, e) => this.Close();
        }

        private void BtnManageUsers_Click(object sender, EventArgs e)
        {
            AdminUsersForm form = new AdminUsersForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnManageHalls_Click(object sender, EventArgs e)
        {
            AdminHallsForm form = new AdminHallsForm();//عند إغلاق نافذة AdminHallsForm، سيتم إظهار النافذة الأصلية مرة أخرى.
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }

        private void BtnManageBookings_Click(object sender, EventArgs e)
        {
            AdminBookingsForm form = new AdminBookingsForm();
            this.Hide();
            form.FormClosed += (s, args) => this.Show();
            form.Show();
        }
    }
}



