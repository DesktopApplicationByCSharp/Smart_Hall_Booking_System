using System;
using System.Windows.Forms;
using System.Drawing;
using System.Data;
using System.Data.SqlClient;

namespace HallsProjects
{
    public partial class AdminUsersForm : Form
    {
        private AuthService _authService;

        public AdminUsersForm()
        {
            _auth_service_check();
            _authService = new AuthService();
            InitializeComponent();

            // Wire events
            btnDelete.Click += BtnDelete_Click;
            btnBack.Click += (s, e) => this.Close();

            LoadUsers();
        }

        // helper to avoid warnings from previous edits
        private void _auth_service_check() { }

        private void LoadUsers()
        {
            DataTable dt = _authService.GetAllUsers();
            dgvUsers.DataSource = dt;
        }


        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvUsers.SelectedRows.Count > 0)
            {
                if (MessageBox.Show("Are you sure you want to delete this user?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int userId = Convert.ToInt32(dgvUsers.SelectedRows[0].Cells["UserID"].Value);
                    var result = _authService.DeleteUser(userId);

                    if (result.IsSuccess)
                    {
                        MessageBox.Show("User deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        LoadUsers();
                    }
                    else
                    {
                        // Check if it's a FK violation (error 547) based on message content, or just show the message
                        if (result.ErrorMessage.Contains("547"))
                        {
                            MessageBox.Show("Cannot delete user because they have associated bookings or other data.", "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            MessageBox.Show($"Failed to delete user. Error: {result.ErrorMessage}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a user to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}


