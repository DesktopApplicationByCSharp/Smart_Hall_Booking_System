using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Windows.Forms;

namespace HallsProjects
{
    public partial class BookingForm : Form
    {
        private User _currentUser;
        private Hall _hall;
        private BookingService _bookingService;

        public BookingForm(User user, Hall hall)
        {
            _currentUser = user;
            _hall = hall;
            _booking_service_check();
            _bookingService = new BookingService();
            
              
            InitializeComponent();

            // Set hall label from designer control
            lblHall.Text = $"Hall: {_hall?.Name}";

            // Wire events
            btnConfirm.Click += BtnConfirm_Click;
            btnCancel.Click += (s, e) => this.Close();

            // Ensure combo has default if not set in designer
            if (cmbPayment.Items.Count == 0)
            {
                cmbPayment.Items.Add("Paid");
                cmbPayment.Items.Add("Not Paid");
                cmbPayment.SelectedIndex = 1;
            }
        }

        // helper to avoid name conflict earlier edits
        private void _booking_service_check() { }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            Booking booking = new Booking
            {
                UserID = _currentUser.UserID,
                HallID = _hall.HallID,
                BookingDate = dtpDate.Value,
                PaymentStatus = cmbPayment.SelectedItem?.ToString() ?? "Not Paid",
                BookingStatus = "Confirmed"
            };

            // Use TryCreateBooking to get a friendly error message for constraint violations
            if (_bookingService.TryCreateBooking(booking, out string errorMessage))
            {
                MessageBox.Show("تم تأكيد الحجز بنجاح!", "نجاح", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // If a friendly message was provided (e.g., duplicate booking), show it.
                if (!string.IsNullOrEmpty(errorMessage))
                {
                    MessageBox.Show(errorMessage, "تحذير", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    MessageBox.Show("فشل في إنشاء الحجز.", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}




