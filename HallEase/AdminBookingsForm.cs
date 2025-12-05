using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public partial class AdminBookingsForm : Form
    {
        private BookingService _bookingService;

        public AdminBookingsForm()
        {
            _bookingService = new BookingService();
            InitializeComponent();

            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadBookings();
        }

        private void LoadBookings()
        {
            DataTable dt = _bookingService.GetAllBookings();
            dgvBookings.DataSource = dt;
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookings.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this booking?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int bookingId = Convert.ToInt32(dgvBookings.SelectedRows[0].Cells["BookingID"].Value);
                    var result = _bookingService.DeleteBooking(bookingId);
                    
                    if (result.IsSuccess)
                    {
                        MessageBox.Show("Booking deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadBookings();
                    }
                    else
                    {
                        MessageBox.Show($"Failed to delete booking. Error: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a booking to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


