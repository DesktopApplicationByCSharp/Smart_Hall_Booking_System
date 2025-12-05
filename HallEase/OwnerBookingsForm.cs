using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{

    public partial class OwnerBookingsForm : Form
    {
        private User _currentUser;
        private BookingService _bookingService;

        public OwnerBookingsForm(User user)
        {
            _currentUser = user;
            _bookingService = new BookingService();
            InitializeComponent();

            // Wire up designer events
            btnBack.Click += (s, e) => this.Close();

            LoadBookings();
        }

        private void LoadBookings()
        {
            DataTable dt = _bookingService.GetBookingsByOwner(_currentUser.UserID);
            dgvBookings.DataSource = dt;
        }
    }

}


