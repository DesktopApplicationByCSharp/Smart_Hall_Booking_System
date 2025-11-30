using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class MyBookingsForm : Form
    {
        private User _currentUser;
        private BookingService _bookingService;

        public MyBookingsForm(User user)
        {
            _currentUser = user;
            _booking_service_check();
            _bookingService = new BookingService();
            InitializeComponent();

            // Wire events
            btnCancelBooking.Click += BtnCancelBooking_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadBookings();
        }

        // temporary helper to avoid name clash with field
        private void _booking_service_check() { }

        private void LoadBookings()
        {
            DataTable dt = _bookingService.GetBookingsByCustomer(_currentUser.UserID);
            dgvBookings.DataSource = dt;
        }

        private void BtnCancelBooking_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to cancel this booking?", "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    int bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
                    if (_bookingService.CancelBooking(bookingId))
                    {
                        MessageBox.Show("Booking cancelled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                    }
                    else
                    {
                        MessageBox.Show("Failed to cancel booking.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to cancel.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


